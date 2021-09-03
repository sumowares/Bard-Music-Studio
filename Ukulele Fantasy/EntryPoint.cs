using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI.Controls;
using DarkUI.Forms;
using NAudio.CoreAudioApi;
using NAudio.Wave;
using Newtonsoft.Json;
using Ukulele_Fantasy.AudioEngine;
using Ukulele_Fantasy.Models;
using Ukulele_Fantasy.Properties;



namespace Ukulele_Fantasy
{
    public partial class EntryPoint : DarkForm
    {
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);

        #region AudioVariables

        private BufferedWaveProvider _bufferedWaveProvider = null;
        private MMDevice _selectedInputDevice;
        private int _inputDevicePeakVolume = 0;

        #endregion

        #region DllImports

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        public static extern bool PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

        #endregion

        #region Constants

        private const uint WM_KEYDOWN = 0x0100;
        private const uint WM_KEYUP = 0x0101;

        #endregion

        #region BooleanValues

        private bool _isListening = false;
        private bool _isRecording = false;

        #endregion

        #region LoggingUtilities

        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        public Gvars GVars = new Gvars();

        #endregion

        #region Metronome

        private SoundPlayer _soundPlayer;
        private float _currentTempo;
        private Thread aThread;
        private ManualResetEvent stopClick = new ManualResetEvent(false);

        int Interval = 60;

        #endregion

        //Create your private font collection object.
        PrivateFontCollection pfc = new PrivateFontCollection();

        #region PlotData

        Queue<double> myQ;
        int n = 4000;

        #endregion

        public EntryPoint()
        {
            InitializeComponent();
            InitializeApplication();

            //Select your font from the resources.
            //My font here is "Digireu.ttf"
            int fontLength = Properties.Resources.Dot_Matrix_Unknown.Length;

            // create a buffer to read in to
            byte[] fontdata = Properties.Resources.Dot_Matrix_Unknown;

            // create an unsafe memory block for the font data
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            // copy the bytes to the unsafe memory block
            Marshal.Copy(fontdata, 0, data, fontLength);

            uint cFonts = 0;
            AddFontMemResourceEx(data, (uint)fontdata.Length, IntPtr.Zero, ref cFonts);

            // pass the font to the font collection
            pfc.AddMemoryFont(data, fontLength);



            lblClosestNote.Font = new Font(pfc.Families[0], lblClosestNote.Font.Size);
            lblBigHz.Font = new Font(pfc.Families[0], lblBigHz.Font.Size);
        }

        /// <summary>
        /// The main entry point for the application to enter and
        /// initialize all variables.
        /// </summary>
        /// <returns></returns>
        public bool InitializeApplication()
        {
            UpdateExternalLog("Application entry point initiated.");
            UpdateExternalLog("Setting up logging system.");
            if (!SetupLogger())
            {
                Application.Exit();
            }

            UpdateExternalLog("Refreshing input devices.");
            if (!RefreshInputDevices())
            {
                Application.Exit();
            }

            UpdateExternalLog("Creating supplemental windows.");
            if (!CreateWindows())
            {
                Application.Exit();
            }

            if (File.Exists("config.json"))
            {
                if (!LoadConfig())
                {
                    Application.Exit();
                }
            }
            else
            {
                GVars = new Gvars();
                SaveConfig();
                if (!LoadConfig())
                {
                    Application.Exit();
                }
            }

            iGVars.EntryPoint = this;
            myQ = new Queue<double>(Enumerable.Repeat(0.0, n).ToList()); // fill myQ w/ zeros
            lChart.ChartAreas[0].AxisY.Minimum = -10000;
            lChart.ChartAreas[0].AxisY.Maximum = 10000;

            lChart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            lChart.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

            lChart.Series[0].IsVisibleInLegend = false;

            this.lChart.ChartAreas[0].AxisX.LineColor = Color.FromName("Transparent");
            this.lChart.ChartAreas[0].AxisY.LineColor = Color.FromName("Transparent");
            this.lChart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.FromName("Transparent");
            this.lChart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.FromName("Transparent");
            this.lChart.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.FromArgb(220, 220, 220);
            this.lChart.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.FromArgb(220, 220, 220);

            _soundPlayer = new SoundPlayer(Properties.Resources.metronome);
            _soundPlayer.Load();

            UpdateExternalLog("Application has been initialized.");

            RefreshMusicFiles();

            return true;
        }

        private bool LoadConfig()
        {
            try
            {
                GVars = JsonConvert.DeserializeObject<Gvars>(File.ReadAllText("config.json"));
                pot1.Value = GVars.DelayBetweenNotes;
                pot2.Value = GVars.NoiseGate;
                tbThreshold.Value = GVars.Threshold;
                lblThreshold.Text = GVars.Threshold.ToString();
                lblLatency.Text = GVars.DelayBetweenNotes.ToString();
                lblNoiseGate.Text = GVars.NoiseGate.ToString();

            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        private bool SaveConfig()
        {
            try
            {
                File.WriteAllText("config.json", JsonConvert.SerializeObject(GVars));
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool CreateWindows()
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("A fatal error has been encountered, please see the stout.log file for further information.", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return true;
        }

        public bool RefreshInputDevices()
        {
            try
            {
                cbInputDevices.Items.Clear();
                foreach (var inputDevice in Microphone.GetInputDevices())
                {
                    cbInputDevices.Items.Add(inputDevice);
                }

                if (cbInputDevices.Items.Count > 0)
                {
                    cbInputDevices.SelectedIndex = 0;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("A fatal error has been encountered, please see the stout.log file for further information.", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Fatal("Cannot locate any audio input devices. {0}", e.Message);
                return false;
            }

            return true;
        }

        public bool SetupLogger()
        {
            return Models.Logger.SetupLogger();
        }

        private void btnSetInputDevice_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateExternalLog("Attempting to set " + cbInputDevices.Text + " to active device.");
                myQ = new Queue<double>(Enumerable.Repeat(0.0, n).ToList());

                var enumerator = new MMDeviceEnumerator();
                var devices = enumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active);

                _selectedInputDevice = devices.ElementAt(cbInputDevices.SelectedIndex);

                _isListening = true;
                UpdateSystemVolumeMeter();

                StartListening();
            }
            catch (Exception ex)
            {
                Logger.Fatal("Error occurred while setting device {0}", ex.Message);
                MessageBox.Show("A fatal error has been encountered, please see the stout.log file for further information.", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void StartListening()
        {
            try
            {
                var waveIn = new WaveInEvent
                {
                    DeviceNumber = cbInputDevices.SelectedIndex,
                    WaveFormat = new WaveFormat(44100, 1)
                };

                waveIn.DataAvailable += WaveIn_DataAvailable;
                _bufferedWaveProvider = new BufferedWaveProvider(waveIn.WaveFormat);

                waveIn.StartRecording();

                UpdateExternalLog(cbInputDevices.Text + " has been set to active and is now listening.");
            }
            catch (Exception ex)
            {
                Logger.Fatal("Error occurred while setting device {0}", ex.Message);
                MessageBox.Show("A fatal error has been encountered, please see the stout.log file for further information.", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void WaveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            try
            {
                if (_bufferedWaveProvider != null)
                {
                    _bufferedWaveProvider.AddSamples(e.Buffer, 0, e.BytesRecorded);
                    _bufferedWaveProvider.DiscardOnBufferOverflow = true;

                    float max = 0;
                    for (int index = 0; index < e.BytesRecorded; index += 2)
                    {
                        var sample = (short)((e.Buffer[index + 1] << 8) |
                                                e.Buffer[index + 0]);
                        // to floating point
                        var sample32 = sample / 44100f;
                        // absolute value 
                        if (sample32 < 0) sample32 = -sample32;
                        // is this the max value?
                        if (sample32 > max) max = sample32;
                    }

                    UpdateAudioLevelProgressBar((int)(100 * max));
                    GVars.CurrentVolume = (int)(100 * max);

                    GVars.LastVolumePlayed = 100 * max;

                    if ((int)(100 * max) > _inputDevicePeakVolume)
                    {
                        _inputDevicePeakVolume = (int)(100 * max);
                        UpdatePeakVolumeOutputLabel(_inputDevicePeakVolume.ToString());
                    }

                    for (int i = 0; i < e.BytesRecorded; i += 2)
                    {
                        myQ.Enqueue(BitConverter.ToInt16(e.Buffer, i));
                        myQ.Dequeue();
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Fatal("Error occurred while setting device {0}", ex.Message);
                MessageBox.Show("A fatal error has been encountered, please see the stout.log file for further information.", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void UpdateAudioLevelProgressBar(int value)
        {
            if (pbAudioLevel.InvokeRequired)
            {
                pbAudioLevel.Invoke((Action)(delegate
               {
                   pbAudioLevel.Value = value;
                   UpdateVolumeOutputLabel(value.ToString());
               }));
            }
            else
            {
                pbAudioLevel.Value = value;
                UpdateVolumeOutputLabel(value.ToString());
            }
        }

        private void SetInputDeviceRecordingVolume()
        {
            if (tbInputDeviceVolume.InvokeRequired)
            {
                tbInputDeviceVolume.Invoke((Action)(delegate
               {
                   var t = (float)tbInputDeviceVolume.Value / 100;
                   _selectedInputDevice.AudioEndpointVolume.MasterVolumeLevelScalar = t;
                   GVars.SystemVolume = t;
                   SaveConfig();
               }));
            }
            else
            {
                var t = (float)tbInputDeviceVolume.Value / 100;
                _selectedInputDevice.AudioEndpointVolume.MasterVolumeLevelScalar = t;
                GVars.SystemVolume = t;
                SaveConfig();
            }
        }

        private void UpdateSystemVolumeMeter()
        {
            try
            {
                if (tbInputDeviceVolume.InvokeRequired)
                {
                    tbInputDeviceVolume.Invoke((Action)(delegate
                   {
                       var currentVolume = _selectedInputDevice.AudioEndpointVolume.MasterVolumeLevelScalar;
                       var finalVolume = Convert.ToInt32(currentVolume * 100);
                       tbInputDeviceVolume.Value = finalVolume;
                   }));
                }
                else
                {
                    var currentVolume = _selectedInputDevice.AudioEndpointVolume.MasterVolumeLevelScalar;
                    var finalVolume = Convert.ToInt32(currentVolume * 100);
                    tbInputDeviceVolume.Value = finalVolume;
                }
            }
            catch (Exception ex)
            {
                Logger.Fatal("Error occurred while setting device {0}", ex.Message);
                MessageBox.Show("A fatal error has been encountered, please see the stout.log file for further information.", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void UpdateVolumeOutputLabel(string value)
        {
            if (lblCurrentVolumeOutput.InvokeRequired)
            {
                lblCurrentVolumeOutput.Invoke((Action)(delegate
               {
                   lblCurrentVolumeOutput.Text = value;
               }));
            }
            else
            {
                lblCurrentVolumeOutput.Text = value;
            }
        }

        private void UpdatePeakVolumeOutputLabel(string value)
        {
            if (lblPeakVolume.InvokeRequired)
            {
                lblPeakVolume.Invoke((Action)(delegate
                {
                    lblPeakVolume.Text = value;
                }));
            }
            else
            {
                lblPeakVolume.Text = value;
            }
        }

        private void UpdateCurrentPitchLabel(string value)
        {
            if (lblCurrentPitchOutput.InvokeRequired)
            {
                lblCurrentPitchOutput.Invoke((Action)(delegate
                {
                    lblCurrentPitchOutput.Text = value;
                }));
            }
            else
            {
                lblCurrentPitchOutput.Text = value;
            }
        }

        private void UpdateSystemVolumeLevel(string value)
        {
            if (lblSystemVolumeLevel.InvokeRequired)
            {
                lblSystemVolumeLevel.Invoke((Action)(delegate
                {
                    lblSystemVolumeLevel.Text = value;
                }));
            }
            else
            {
                lblSystemVolumeLevel.Text = value;
            }
        }

        private void UpdateClosestNoteLabel(string value)
        {
            if (lblClosestNote.InvokeRequired)
            {
                lblClosestNote.Invoke((Action)(delegate
                {
                    lblClosestNote.Text = value;
                }));
            }
            else
            {
                lblClosestNote.Text = value;
            }
        }

        private void UpdateLastNotePlayedLabel(string value)
        {
            if (lblLastNoteDetected.InvokeRequired)
            {
                lblLastNoteDetected.Invoke((Action)(delegate
                {
                    lblLastNoteDetected.Text = value;
                }));
            }
            else
            {
                lblLastNoteDetected.Text = value;
            }
        }

        private void UpdateBigLabel(string value)
        {
            if (lblBigHz.InvokeRequired)
            {
                lblBigHz.Invoke((Action)(delegate
                {
                    lblBigHz.Text = value;
                }));
            }
            else
            {
                lblBigHz.Text = value;
            }
        }

        private void UpdateTuneUpOrDownLabel(string value)
        {
            if (lblTuneDirection.InvokeRequired)
            {
                lblTuneDirection.Invoke((Action)(delegate
                {
                    lblTuneDirection.Text = value;
                }));
            }
            else
            {
                lblTuneDirection.Text = value;
            }
        }

        public void UpdateExternalLog(string item)
        {
            if (lbExternalLog.InvokeRequired)
            {
                lbExternalLog.Invoke((Action)(delegate
                {
                    lbExternalLog.Items.Add(new DarkUI.Controls.DarkListItem(DateTime.Now.ToShortTimeString() + " " + item));
                }));
            }
            else
            {
                lbExternalLog.Items.Add(new DarkUI.Controls.DarkListItem(DateTime.Now.ToShortTimeString() + " " + item));
            }
        }


        private void tmrUpdateVolume_Tick(object sender, EventArgs e)
        {
            if (_isListening && _selectedInputDevice != null)
            {
                UpdateSystemVolumeMeter();

                var currentVolume = _selectedInputDevice.AudioEndpointVolume.MasterVolumeLevelScalar;
                var finalVolume = Convert.ToInt32(currentVolume * 100);

                UpdateSystemVolumeLevel(finalVolume.ToString());
            }
        }

        private void tbInputDeviceVolume_ValueChanged(object sender, EventArgs e)
        {
            if (_isListening && _selectedInputDevice != null)
            {
                SetInputDeviceRecordingVolume();

                var currentVolume = _selectedInputDevice.AudioEndpointVolume.MasterVolumeLevelScalar;
                var finalVolume = Convert.ToInt32(currentVolume * 100);
            }
        }

        private void tbThreshold_ValueChanged(object sender, EventArgs e)
        {
            GVars.Threshold = (int)tbThreshold.Value;
            SaveConfig();
            lblThreshold.Text = tbThreshold.Value.ToString();
        }

        private void btnResetPeakValue_Click(object sender, EventArgs e)
        {
            _inputDevicePeakVolume = 0;
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            if (_isListening && _selectedInputDevice != null && !_isRecording)
            {
                var process = Process.GetProcessesByName("ffxiv_dx11").FirstOrDefault().MainWindowHandle;

                if (process == null)
                    return;

                GVars.MainWindowHandle = process;

                btnListen.Text = @"Stop";
                btnListen.ForeColor = Color.Red;

                _isRecording = true;
                bgwMonitor.RunWorkerAsync();




            }
            else if (_isRecording)
            {
                btnListen.Text = @"Listen";
                btnListen.ForeColor = Color.Black;

                _isRecording = false;
            }
        }
        /// <summary>
        /// The background worker that records the audio.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bgwMonitor_DoWork(object sender, DoWorkEventArgs e)
        {
            UpdateExternalLog("Initiating note recognition system.");
            var stream = new Wave16ToFloatProvider(_bufferedWaveProvider);
            var pitch = new Pitch(stream);

            byte[] buffer = new byte[4096];
            int bytesRead;

            UpdateExternalLog("Bard Music Studio initiated, awaiting input.");
            do
            {
                bytesRead = stream.Read(buffer, 0, buffer.Length);
                var freq = pitch.Get(buffer);
                var note = GetNote(freq);

                if (freq != 0)
                {
                    if (!string.IsNullOrEmpty(note))
                    {
                        UpdateLastNotePlayedLabel(note);

                        if (note == iGVars.LastNotePlayed)
                        {
                            UpdateExternalLog(GVars.LastVolumePlayed.ToString() + " " + iGVars.LastVolumePlayed.ToString());
                            if (GVars.LastVolumePlayed < iGVars.LastVolumePlayed)
                            {
                                continue;
                            }
                            else
                            {
                                iGVars.LastVolumePlayed = GVars.LastVolumePlayed;
                                iGVars.LastNotePlayed = note;
                                Keycodes.SendKeyboardInput(note);
                            }
                        }
                        else
                        {
                            iGVars.LastVolumePlayed = GVars.LastVolumePlayed;
                            iGVars.LastNotePlayed = note;

                            Keycodes.SendKeyboardInput(note);
                        }
                    }
                }
            } while (_isRecording);
        }

        string[] NoteNames = { "A", "A#", "B/H", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#" };
        double ToneStep = Math.Pow(2, 1.0 / 12);

        private void FindClosestNote(double frequency, out double closestFrequency, out string noteName)
        {
            const double AFrequency = 440.0;
            const int ToneIndexOffsetToPositives = 120;

            int toneIndex = (int)Math.Round(Math.Log(frequency / AFrequency, ToneStep));
            noteName = NoteNames[(ToneIndexOffsetToPositives + toneIndex) % NoteNames.Length];
            closestFrequency = Math.Pow(ToneStep, toneIndex) * AFrequency;
        }

        private string GetNote(float freq)
        {
            float baseFreq;
            foreach (var note in AudiableNotes.NoteFrequency)
            {
                baseFreq = note.Value;
                for (int i = 0; i < 4; i++)
                {
                    if ((freq >= baseFreq - 2.5) && (freq < baseFreq + 2.5) || (freq == baseFreq))
                    {
                        return note.Key + i;
                    }
                    baseFreq *= 2;
                }
            }
            return null;
        }

        public static double GetMyData(Dictionary<DateTime, double> MyData, DateTime Date)
        {
            var sorted = new SortedDictionary<DateTime, double>(MyData);

            var keys = new List<DateTime>(sorted.Keys);
            var index = keys.BinarySearch(Date);

            if (index >= 0) return sorted[keys[index]];

            else
                return sorted[keys[~index - 1]];
        }

        private void tbThreshold_VisibleChanged(object sender, EventArgs e)
        {
            GVars.Threshold = (int)tbThreshold.Value;
        }

        private void btnDisplayMetronome_Click(object sender, EventArgs e)
        {
            try
            {
                _currentTempo = Convert.ToSingle(colorSlider1.Value);
                if (aThread != null)
                {
                    if (aThread.IsAlive)
                    {
                        stopClick.Set();
                        _soundPlayer.Stop();
                        aThread.Join();
                        return;
                    }
                }
                StartMetronome();
            }
            catch (Exception ex)
            {

            }
        }

        private void StartMetronome()
        {
            if (aThread == null)
            {
                aThread = new Thread(new ThreadStart(ClickMetronome));
                aThread.Start();
            }
            if (!aThread.IsAlive)
            {
                aThread = new Thread(new ThreadStart(ClickMetronome));
                aThread.Start();
            }
        }

        private void ClickMetronome()
        {
            Interval = Convert.ToInt32(60000.0 / _currentTempo);
            stopClick.Reset();
            while (!stopClick.WaitOne(1, false))
            {
                _soundPlayer.Play();
                Thread.Sleep(Interval);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bgwMonitor.IsBusy)
            {
                _isRecording = false;
            }
        }

        private void EntryPoint_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bgwMonitor.IsBusy)
            {
                _isRecording = false;
            }
        }

        private void tmrUpdateValues_Tick(object sender, EventArgs e)
        {
            try
            {
                lChart.Series["Series1"].Points.DataBindY(myQ);
                //chart1.ResetAutoValues();
            }
            catch
            {
                Console.WriteLine("No bytes recorded");
            }
        }

        private void pot1_ValueChanged(object sender, EventArgs e)
        {
            SaveConfig();
            GVars.DelayBetweenNotes = (int)pot1.Value;
            lblLatency.Text = GVars.DelayBetweenNotes.ToString();
        }

        private void pot2_ValueChanged(object sender, EventArgs e)
        {
            SaveConfig();
            GVars.NoiseGate = (int)pot2.Value;
            lblNoiseGate.Text = GVars.NoiseGate.ToString();
        }

        private void colorSlider1_ValueChanged(object sender, EventArgs e)
        {
            lblMetronomeSpeed.Text = colorSlider1.Value.ToString() + @" bpm";
            _currentTempo = Convert.ToSingle(colorSlider1.Value);
            Interval = Convert.ToInt32(60000.0 / _currentTempo);
        }

        private void becomeAPatreonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.patreon.com/bardmusicstudio");
        }

        private void makeAOnetimeDonationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.paypal.com/paypalme/sumosoft");
        }

        private void visitOurDiscordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/CJNvg3FtRG");
        }

        private void pbSupport_Click(object sender, EventArgs e)
        {
            contributeToolStripMenuItem.ShowDropDown();
        }

        private void btnSelectMusicFolder_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                if (Directory.Exists(fbd.SelectedPath))
                {
                    GVars.MusicFolderPath = fbd.SelectedPath;
                    SaveConfig();
                    RefreshMusicFiles();
                }
            }
        }

        private void RefreshMusicFiles()
        {
            dlLibrary.Items.Clear();

            if (Directory.Exists(GVars.MusicFolderPath))
            {
                foreach (var f in Directory.GetFiles(GVars.MusicFolderPath))
                {
                    var item = new DarkListItem(Path.GetFileName(f));
                    item.Icon = Icons.guitar_16px;
                    dlLibrary.Items.Add(item);

                }
            }
        }

        private void btnOpenSelectedMusicFile_Click(object sender, EventArgs e)
        {

            var item = dlLibrary.SelectedIndices[0];
            var fitem = dlLibrary.Items[item];

            iGVars.CurrentFIle = GVars.MusicFolderPath + "\\" + fitem.Text;

            var mv = new MusicViewer();
            mv.Show();


        }

        private void openLoadoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var ld = JsonConvert.DeserializeObject<Loadout>(File.ReadAllText(ofd.FileName));
                pot2.Value = ld.NoiseGate;
                pot1.Value = ld.DelayBetwwenNotes;
                tbInputDeviceVolume.Value = ld.SystemVolume;
                tbThreshold.Value = ld.Threshold;
            }
        }

        private void saveLoadoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var ld = new Loadout
                {
                    DelayBetwwenNotes = GVars.DelayBetweenNotes,
                    NoiseGate = GVars.NoiseGate,
                    Threshold = GVars.Threshold,
                    SystemVolume = GVars.SystemVolume
                };
                File.WriteAllText(sfd.FileName, JsonConvert.SerializeObject(ld));
            }
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tmrVolumeTicker_Tick(object sender, EventArgs e)
        {
            if (_isListening)
            {
                float f = _selectedInputDevice.AudioMeterInformation.MasterPeakValue;
            }
        }

        private void timerTuner_Tick(object sender, EventArgs e)
        {
            if (_isListening)
            {
                var stream = new Wave16ToFloatProvider(_bufferedWaveProvider);
                var pitch = new Pitch(stream);

                byte[] buffer = new byte[4096];

                string noteName;

                var freq = pitch.Get(buffer);

                if (freq != 0 && GVars.CurrentVolume > GVars.Threshold)
                {
                    FindClosestNote(freq, out double closestFrequency, out noteName);
                    UpdateClosestNoteLabel(noteName);

                    UpdateBigLabel(String.Format("{0:0.00}", closestFrequency));

                    if (AudiableNotes.NoteFrequency.ContainsKey(noteName))
                    {
                        float v = AudiableNotes.NoteFrequency[noteName];
                        
                        if (freq < closestFrequency - 2)
                        {
                            UpdateTuneUpOrDownLabel("Tune Up");
                        }
                        else if (freq > closestFrequency + 2)
                        {
                            UpdateTuneUpOrDownLabel("Tune Down");
                        }
                        else
                        {
                            UpdateTuneUpOrDownLabel("Sounds Great!");
                        }
                    }
                }
            }
        }
    }
}
