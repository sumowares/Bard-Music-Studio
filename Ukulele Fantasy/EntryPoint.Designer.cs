
namespace Ukulele_Fantasy
{
    partial class EntryPoint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryPoint));
            this.imageListMain = new System.Windows.Forms.ImageList(this.components);
            this.bgwMonitor = new System.ComponentModel.BackgroundWorker();
            this.tmrUpdateVolume = new System.Windows.Forms.Timer(this.components);
            this.cbInputDevices = new DarkUI.Controls.DarkComboBox();
            this.darkButton3 = new DarkUI.Controls.DarkButton();
            this.darkStatusStrip1 = new DarkUI.Controls.DarkStatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnListen = new DarkUI.Controls.DarkButton();
            this.darkSeparator1 = new DarkUI.Controls.DarkSeparator();
            this.darkButton2 = new DarkUI.Controls.DarkButton();
            this.tmrUpdateValues = new System.Windows.Forms.Timer(this.components);
            this.lbExternalLog = new DarkUI.Controls.DarkListView();
            this.darkGroupBox2 = new DarkUI.Controls.DarkGroupBox();
            this.darkSectionPanel2 = new DarkUI.Controls.DarkSectionPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBigHz = new DarkUI.Controls.DarkLabel();
            this.lblTuneDirection = new DarkUI.Controls.DarkLabel();
            this.darkSectionPanel3 = new DarkUI.Controls.DarkSectionPanel();
            this.lblMetronomeSpeed = new DarkUI.Controls.DarkLabel();
            this.colorSlider1 = new ColorSlider.ColorSlider();
            this.darkSectionPanel4 = new DarkUI.Controls.DarkSectionPanel();
            this.dlLibrary = new DarkUI.Controls.DarkListView();
            this.btnSelectMusicFolder = new DarkUI.Controls.DarkButton();
            this.btnOpenSelectedMusicFile = new DarkUI.Controls.DarkButton();
            this.tmrVolumeTicker = new System.Windows.Forms.Timer(this.components);
            this.timerTuner = new System.Windows.Forms.Timer(this.components);
            this.tmrResetPeak = new System.Windows.Forms.Timer(this.components);
            this.tbThreshold = new NAudio.Gui.Pot();
            this.lblThreshold = new LCDLabel.LcdLabel();
            this.lblLastNoteDetected = new LCDLabel.LcdLabel();
            this.tbInputDeviceVolume = new NAudio.Gui.Pot();
            this.lblLatency = new LCDLabel.LcdLabel();
            this.lblCurrentPitchOutput = new LCDLabel.LcdLabel();
            this.lblNoiseGate = new LCDLabel.LcdLabel();
            this.pot1 = new NAudio.Gui.Pot();
            this.lblSystemVolumeLevel = new LCDLabel.LcdLabel();
            this.lcdLabel1 = new LCDLabel.LcdLabel();
            this.lblCurrentVolumeOutput = new LCDLabel.LcdLabel();
            this.pot2 = new NAudio.Gui.Pot();
            this.lcdLabel2 = new LCDLabel.LcdLabel();
            this.lblPeakVolume = new LCDLabel.LcdLabel();
            this.lcdLabel3 = new LCDLabel.LcdLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblClosestNote = new LCDLabel.LcdLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.darkStatusStrip1.SuspendLayout();
            this.darkGroupBox2.SuspendLayout();
            this.darkSectionPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.darkSectionPanel3.SuspendLayout();
            this.darkSectionPanel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageListMain
            // 
            this.imageListMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMain.ImageStream")));
            this.imageListMain.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMain.Images.SetKeyName(0, "about_24px.png");
            this.imageListMain.Images.SetKeyName(1, "console_24px.png");
            this.imageListMain.Images.SetKeyName(2, "statistics_24px.png");
            // 
            // bgwMonitor
            // 
            this.bgwMonitor.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwMonitor_DoWork);
            // 
            // tmrUpdateVolume
            // 
            this.tmrUpdateVolume.Enabled = true;
            this.tmrUpdateVolume.Interval = 1;
            this.tmrUpdateVolume.Tick += new System.EventHandler(this.tmrUpdateVolume_Tick);
            // 
            // cbInputDevices
            // 
            this.cbInputDevices.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbInputDevices.FormattingEnabled = true;
            this.cbInputDevices.Location = new System.Drawing.Point(678, 153);
            this.cbInputDevices.Name = "cbInputDevices";
            this.cbInputDevices.Size = new System.Drawing.Size(386, 21);
            this.cbInputDevices.TabIndex = 22;
            // 
            // darkButton3
            // 
            this.darkButton3.Image = ((System.Drawing.Image)(resources.GetObject("darkButton3.Image")));
            this.darkButton3.Location = new System.Drawing.Point(1070, 148);
            this.darkButton3.Name = "darkButton3";
            this.darkButton3.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton3.Size = new System.Drawing.Size(28, 28);
            this.darkButton3.TabIndex = 29;
            this.darkButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.darkButton3.Click += new System.EventHandler(this.btnSetInputDevice_Click);
            // 
            // darkStatusStrip1
            // 
            this.darkStatusStrip1.AutoSize = false;
            this.darkStatusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkStatusStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkStatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.darkStatusStrip1.Location = new System.Drawing.Point(0, 900);
            this.darkStatusStrip1.Name = "darkStatusStrip1";
            this.darkStatusStrip1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.darkStatusStrip1.Size = new System.Drawing.Size(1523, 28);
            this.darkStatusStrip1.SizingGrip = false;
            this.darkStatusStrip1.TabIndex = 26;
            this.darkStatusStrip1.Text = "darkStatusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 15);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(1157, 704);
            this.btnListen.Name = "btnListen";
            this.btnListen.Padding = new System.Windows.Forms.Padding(5);
            this.btnListen.Size = new System.Drawing.Size(75, 23);
            this.btnListen.TabIndex = 28;
            this.btnListen.Text = "Listen";
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // darkSeparator1
            // 
            this.darkSeparator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.darkSeparator1.Location = new System.Drawing.Point(0, 0);
            this.darkSeparator1.Name = "darkSeparator1";
            this.darkSeparator1.Size = new System.Drawing.Size(1523, 2);
            this.darkSeparator1.TabIndex = 30;
            this.darkSeparator1.Text = "darkSeparator1";
            // 
            // darkButton2
            // 
            this.darkButton2.Location = new System.Drawing.Point(4, 172);
            this.darkButton2.Name = "darkButton2";
            this.darkButton2.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton2.Size = new System.Drawing.Size(286, 23);
            this.darkButton2.TabIndex = 32;
            this.darkButton2.Text = "Start/Stop Metronome";
            this.darkButton2.Click += new System.EventHandler(this.btnDisplayMetronome_Click);
            // 
            // tmrUpdateValues
            // 
            this.tmrUpdateValues.Enabled = true;
            this.tmrUpdateValues.Interval = 1;
            this.tmrUpdateValues.Tick += new System.EventHandler(this.tmrUpdateValues_Tick);
            // 
            // lbExternalLog
            // 
            this.lbExternalLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbExternalLog.Location = new System.Drawing.Point(3, 16);
            this.lbExternalLog.Name = "lbExternalLog";
            this.lbExternalLog.Size = new System.Drawing.Size(405, 192);
            this.lbExternalLog.TabIndex = 33;
            this.lbExternalLog.Text = "darkListView1";
            // 
            // darkGroupBox2
            // 
            this.darkGroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.darkGroupBox2.Controls.Add(this.lbExternalLog);
            this.darkGroupBox2.Location = new System.Drawing.Point(636, 448);
            this.darkGroupBox2.Name = "darkGroupBox2";
            this.darkGroupBox2.Size = new System.Drawing.Size(411, 211);
            this.darkGroupBox2.TabIndex = 34;
            this.darkGroupBox2.TabStop = false;
            this.darkGroupBox2.Text = "System Log";
            // 
            // darkSectionPanel2
            // 
            this.darkSectionPanel2.Controls.Add(this.panel1);
            this.darkSectionPanel2.Controls.Add(this.lblTuneDirection);
            this.darkSectionPanel2.Location = new System.Drawing.Point(1142, 71);
            this.darkSectionPanel2.Name = "darkSectionPanel2";
            this.darkSectionPanel2.SectionHeader = "Instrument Tuner";
            this.darkSectionPanel2.Size = new System.Drawing.Size(294, 202);
            this.darkSectionPanel2.TabIndex = 53;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lblBigHz);
            this.panel1.Location = new System.Drawing.Point(4, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 100);
            this.panel1.TabIndex = 3;
            // 
            // lblBigHz
            // 
            this.lblBigHz.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBigHz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblBigHz.Location = new System.Drawing.Point(4, 53);
            this.lblBigHz.Name = "lblBigHz";
            this.lblBigHz.Size = new System.Drawing.Size(279, 37);
            this.lblBigHz.TabIndex = 2;
            this.lblBigHz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTuneDirection
            // 
            this.lblTuneDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuneDirection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblTuneDirection.Location = new System.Drawing.Point(4, 132);
            this.lblTuneDirection.Name = "lblTuneDirection";
            this.lblTuneDirection.Size = new System.Drawing.Size(286, 37);
            this.lblTuneDirection.TabIndex = 1;
            this.lblTuneDirection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // darkSectionPanel3
            // 
            this.darkSectionPanel3.Controls.Add(this.lblMetronomeSpeed);
            this.darkSectionPanel3.Controls.Add(this.colorSlider1);
            this.darkSectionPanel3.Controls.Add(this.darkButton2);
            this.darkSectionPanel3.Location = new System.Drawing.Point(1142, 279);
            this.darkSectionPanel3.Name = "darkSectionPanel3";
            this.darkSectionPanel3.SectionHeader = "Metronome";
            this.darkSectionPanel3.Size = new System.Drawing.Size(294, 202);
            this.darkSectionPanel3.TabIndex = 54;
            // 
            // lblMetronomeSpeed
            // 
            this.lblMetronomeSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetronomeSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(43)))), ((int)(((byte)(221)))));
            this.lblMetronomeSpeed.Location = new System.Drawing.Point(4, 37);
            this.lblMetronomeSpeed.Name = "lblMetronomeSpeed";
            this.lblMetronomeSpeed.Size = new System.Drawing.Size(286, 37);
            this.lblMetronomeSpeed.TabIndex = 3;
            this.lblMetronomeSpeed.Text = "80 bpm";
            this.lblMetronomeSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colorSlider1
            // 
            this.colorSlider1.BackColor = System.Drawing.Color.Transparent;
            this.colorSlider1.BarPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(94)))), ((int)(((byte)(110)))));
            this.colorSlider1.BarPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(74)))));
            this.colorSlider1.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.colorSlider1.ElapsedInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(43)))), ((int)(((byte)(221)))));
            this.colorSlider1.ElapsedPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(43)))), ((int)(((byte)(221)))));
            this.colorSlider1.ElapsedPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(43)))), ((int)(((byte)(221)))));
            this.colorSlider1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.colorSlider1.ForeColor = System.Drawing.Color.White;
            this.colorSlider1.LargeChange = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.colorSlider1.Location = new System.Drawing.Point(4, 90);
            this.colorSlider1.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.colorSlider1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.colorSlider1.MouseEffects = false;
            this.colorSlider1.Name = "colorSlider1";
            this.colorSlider1.ScaleDivisions = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.colorSlider1.ScaleSubDivisions = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.colorSlider1.ShowDivisionsText = false;
            this.colorSlider1.ShowSmallScale = false;
            this.colorSlider1.Size = new System.Drawing.Size(286, 48);
            this.colorSlider1.SmallChange = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.colorSlider1.TabIndex = 0;
            this.colorSlider1.Text = "colorSlider1";
            this.colorSlider1.ThumbInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(43)))), ((int)(((byte)(221)))));
            this.colorSlider1.ThumbOuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(43)))), ((int)(((byte)(221)))));
            this.colorSlider1.ThumbPenColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(43)))), ((int)(((byte)(221)))));
            this.colorSlider1.ThumbRoundRectSize = new System.Drawing.Size(16, 16);
            this.colorSlider1.ThumbSize = new System.Drawing.Size(16, 16);
            this.colorSlider1.TickAdd = 0F;
            this.colorSlider1.TickColor = System.Drawing.Color.White;
            this.colorSlider1.TickDivide = 0F;
            this.colorSlider1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.colorSlider1.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.colorSlider1.ValueChanged += new System.EventHandler(this.colorSlider1_ValueChanged);
            // 
            // darkSectionPanel4
            // 
            this.darkSectionPanel4.Controls.Add(this.dlLibrary);
            this.darkSectionPanel4.Location = new System.Drawing.Point(1142, 487);
            this.darkSectionPanel4.Name = "darkSectionPanel4";
            this.darkSectionPanel4.SectionHeader = "Music Library";
            this.darkSectionPanel4.Size = new System.Drawing.Size(294, 159);
            this.darkSectionPanel4.TabIndex = 55;
            // 
            // dlLibrary
            // 
            this.dlLibrary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dlLibrary.Location = new System.Drawing.Point(1, 25);
            this.dlLibrary.Name = "dlLibrary";
            this.dlLibrary.ShowIcons = true;
            this.dlLibrary.Size = new System.Drawing.Size(292, 133);
            this.dlLibrary.TabIndex = 0;
            this.dlLibrary.Text = "darkListView1";
            // 
            // btnSelectMusicFolder
            // 
            this.btnSelectMusicFolder.Location = new System.Drawing.Point(1340, 651);
            this.btnSelectMusicFolder.Name = "btnSelectMusicFolder";
            this.btnSelectMusicFolder.Padding = new System.Windows.Forms.Padding(5);
            this.btnSelectMusicFolder.Size = new System.Drawing.Size(96, 23);
            this.btnSelectMusicFolder.TabIndex = 56;
            this.btnSelectMusicFolder.Text = "Select Folder";
            this.btnSelectMusicFolder.Click += new System.EventHandler(this.btnSelectMusicFolder_Click);
            // 
            // btnOpenSelectedMusicFile
            // 
            this.btnOpenSelectedMusicFile.Location = new System.Drawing.Point(1238, 652);
            this.btnOpenSelectedMusicFile.Name = "btnOpenSelectedMusicFile";
            this.btnOpenSelectedMusicFile.Padding = new System.Windows.Forms.Padding(5);
            this.btnOpenSelectedMusicFile.Size = new System.Drawing.Size(96, 23);
            this.btnOpenSelectedMusicFile.TabIndex = 57;
            this.btnOpenSelectedMusicFile.Text = "Open Selected";
            this.btnOpenSelectedMusicFile.Click += new System.EventHandler(this.btnOpenSelectedMusicFile_Click);
            // 
            // tmrVolumeTicker
            // 
            this.tmrVolumeTicker.Enabled = true;
            this.tmrVolumeTicker.Interval = 1;
            this.tmrVolumeTicker.Tick += new System.EventHandler(this.tmrVolumeTicker_Tick);
            // 
            // timerTuner
            // 
            this.timerTuner.Enabled = true;
            this.timerTuner.Interval = 1;
            this.timerTuner.Tick += new System.EventHandler(this.timerTuner_Tick);
            // 
            // tmrResetPeak
            // 
            this.tmrResetPeak.Enabled = true;
            this.tmrResetPeak.Interval = 5000;
            this.tmrResetPeak.Tick += new System.EventHandler(this.tmrResetPeak_Tick);
            // 
            // tbThreshold
            // 
            this.tbThreshold.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tbThreshold.Location = new System.Drawing.Point(442, 44);
            this.tbThreshold.Maximum = 100D;
            this.tbThreshold.Minimum = 0D;
            this.tbThreshold.Name = "tbThreshold";
            this.tbThreshold.Size = new System.Drawing.Size(67, 68);
            this.tbThreshold.TabIndex = 34;
            this.tbThreshold.Value = 24D;
            this.tbThreshold.ValueChanged += new System.EventHandler(this.tbThreshold_ValueChanged);
            // 
            // lblThreshold
            // 
            this.lblThreshold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblThreshold.BackGround = System.Drawing.Color.Black;
            this.lblThreshold.BorderColor = System.Drawing.Color.Black;
            this.lblThreshold.BorderSpace = 0;
            this.lblThreshold.CharSpacing = 2;
            this.lblThreshold.DotMatrix = LCDLabel.DotMatrix.mat5x8;
            this.lblThreshold.LineSpacing = 2;
            this.lblThreshold.Location = new System.Drawing.Point(308, 152);
            this.lblThreshold.Name = "lblThreshold";
            this.lblThreshold.NumberOfCharacters = 19;
            this.lblThreshold.PixelHeight = 2;
            this.lblThreshold.PixelOff = System.Drawing.Color.Indigo;
            this.lblThreshold.PixelOn = System.Drawing.Color.DeepSkyBlue;
            this.lblThreshold.PixelShape = LCDLabel.PixelShape.Shaped;
            this.lblThreshold.PixelSize = LCDLabel.PixelSize.pix2x2;
            this.lblThreshold.PixelSpacing = 1;
            this.lblThreshold.PixelWidth = 2;
            this.lblThreshold.Size = new System.Drawing.Size(304, 25);
            this.lblThreshold.TabIndex = 62;
            this.lblThreshold.Text = "Threshold:      000";
            this.lblThreshold.TextLines = 1;
            // 
            // lblLastNoteDetected
            // 
            this.lblLastNoteDetected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLastNoteDetected.BackGround = System.Drawing.Color.Black;
            this.lblLastNoteDetected.BorderColor = System.Drawing.Color.Black;
            this.lblLastNoteDetected.BorderSpace = 0;
            this.lblLastNoteDetected.CharSpacing = 2;
            this.lblLastNoteDetected.DotMatrix = LCDLabel.DotMatrix.mat5x8;
            this.lblLastNoteDetected.LineSpacing = 2;
            this.lblLastNoteDetected.Location = new System.Drawing.Point(4, 252);
            this.lblLastNoteDetected.Name = "lblLastNoteDetected";
            this.lblLastNoteDetected.NumberOfCharacters = 19;
            this.lblLastNoteDetected.PixelHeight = 2;
            this.lblLastNoteDetected.PixelOff = System.Drawing.Color.Indigo;
            this.lblLastNoteDetected.PixelOn = System.Drawing.Color.DeepSkyBlue;
            this.lblLastNoteDetected.PixelShape = LCDLabel.PixelShape.Shaped;
            this.lblLastNoteDetected.PixelSize = LCDLabel.PixelSize.pix2x2;
            this.lblLastNoteDetected.PixelSpacing = 1;
            this.lblLastNoteDetected.PixelWidth = 2;
            this.lblLastNoteDetected.Size = new System.Drawing.Size(304, 25);
            this.lblLastNoteDetected.TabIndex = 61;
            this.lblLastNoteDetected.Text = "Detected Note:  ---";
            this.lblLastNoteDetected.TextLines = 1;
            // 
            // tbInputDeviceVolume
            // 
            this.tbInputDeviceVolume.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tbInputDeviceVolume.Location = new System.Drawing.Point(339, 44);
            this.tbInputDeviceVolume.Maximum = 100D;
            this.tbInputDeviceVolume.Minimum = 0D;
            this.tbInputDeviceVolume.Name = "tbInputDeviceVolume";
            this.tbInputDeviceVolume.Size = new System.Drawing.Size(67, 68);
            this.tbInputDeviceVolume.TabIndex = 35;
            this.tbInputDeviceVolume.Value = 0.5D;
            this.tbInputDeviceVolume.ValueChanged += new System.EventHandler(this.tbInputDeviceVolume_ValueChanged);
            // 
            // lblLatency
            // 
            this.lblLatency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLatency.BackGround = System.Drawing.Color.Black;
            this.lblLatency.BorderColor = System.Drawing.Color.Black;
            this.lblLatency.BorderSpace = 0;
            this.lblLatency.CharSpacing = 2;
            this.lblLatency.DotMatrix = LCDLabel.DotMatrix.mat5x8;
            this.lblLatency.LineSpacing = 2;
            this.lblLatency.Location = new System.Drawing.Point(308, 177);
            this.lblLatency.Name = "lblLatency";
            this.lblLatency.NumberOfCharacters = 19;
            this.lblLatency.PixelHeight = 2;
            this.lblLatency.PixelOff = System.Drawing.Color.Indigo;
            this.lblLatency.PixelOn = System.Drawing.Color.DeepSkyBlue;
            this.lblLatency.PixelShape = LCDLabel.PixelShape.Shaped;
            this.lblLatency.PixelSize = LCDLabel.PixelSize.pix2x2;
            this.lblLatency.PixelSpacing = 1;
            this.lblLatency.PixelWidth = 2;
            this.lblLatency.Size = new System.Drawing.Size(304, 25);
            this.lblLatency.TabIndex = 63;
            this.lblLatency.Text = "Latency:        ---";
            this.lblLatency.TextLines = 1;
            // 
            // lblCurrentPitchOutput
            // 
            this.lblCurrentPitchOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCurrentPitchOutput.BackGround = System.Drawing.Color.Black;
            this.lblCurrentPitchOutput.BorderColor = System.Drawing.Color.Black;
            this.lblCurrentPitchOutput.BorderSpace = 0;
            this.lblCurrentPitchOutput.CharSpacing = 2;
            this.lblCurrentPitchOutput.DotMatrix = LCDLabel.DotMatrix.mat5x8;
            this.lblCurrentPitchOutput.LineSpacing = 2;
            this.lblCurrentPitchOutput.Location = new System.Drawing.Point(4, 227);
            this.lblCurrentPitchOutput.Name = "lblCurrentPitchOutput";
            this.lblCurrentPitchOutput.NumberOfCharacters = 19;
            this.lblCurrentPitchOutput.PixelHeight = 2;
            this.lblCurrentPitchOutput.PixelOff = System.Drawing.Color.Indigo;
            this.lblCurrentPitchOutput.PixelOn = System.Drawing.Color.DeepSkyBlue;
            this.lblCurrentPitchOutput.PixelShape = LCDLabel.PixelShape.Shaped;
            this.lblCurrentPitchOutput.PixelSize = LCDLabel.PixelSize.pix2x2;
            this.lblCurrentPitchOutput.PixelSpacing = 1;
            this.lblCurrentPitchOutput.PixelWidth = 2;
            this.lblCurrentPitchOutput.Size = new System.Drawing.Size(304, 25);
            this.lblCurrentPitchOutput.TabIndex = 60;
            this.lblCurrentPitchOutput.Text = "Pitch:        000hz";
            this.lblCurrentPitchOutput.TextLines = 1;
            // 
            // lblNoiseGate
            // 
            this.lblNoiseGate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNoiseGate.BackGround = System.Drawing.Color.Black;
            this.lblNoiseGate.BorderColor = System.Drawing.Color.Black;
            this.lblNoiseGate.BorderSpace = 0;
            this.lblNoiseGate.CharSpacing = 2;
            this.lblNoiseGate.DotMatrix = LCDLabel.DotMatrix.mat5x8;
            this.lblNoiseGate.LineSpacing = 2;
            this.lblNoiseGate.Location = new System.Drawing.Point(308, 202);
            this.lblNoiseGate.Name = "lblNoiseGate";
            this.lblNoiseGate.NumberOfCharacters = 19;
            this.lblNoiseGate.PixelHeight = 2;
            this.lblNoiseGate.PixelOff = System.Drawing.Color.Indigo;
            this.lblNoiseGate.PixelOn = System.Drawing.Color.DeepSkyBlue;
            this.lblNoiseGate.PixelShape = LCDLabel.PixelShape.Shaped;
            this.lblNoiseGate.PixelSize = LCDLabel.PixelSize.pix2x2;
            this.lblNoiseGate.PixelSpacing = 1;
            this.lblNoiseGate.PixelWidth = 2;
            this.lblNoiseGate.Size = new System.Drawing.Size(304, 25);
            this.lblNoiseGate.TabIndex = 64;
            this.lblNoiseGate.Text = "Noise Gate:    ----";
            this.lblNoiseGate.TextLines = 1;
            // 
            // pot1
            // 
            this.pot1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.pot1.Location = new System.Drawing.Point(236, 44);
            this.pot1.Maximum = 999D;
            this.pot1.Minimum = 0D;
            this.pot1.Name = "pot1";
            this.pot1.Size = new System.Drawing.Size(67, 68);
            this.pot1.TabIndex = 38;
            this.pot1.Value = 250D;
            this.pot1.ValueChanged += new System.EventHandler(this.pot1_ValueChanged);
            // 
            // lblSystemVolumeLevel
            // 
            this.lblSystemVolumeLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSystemVolumeLevel.BackGround = System.Drawing.Color.Black;
            this.lblSystemVolumeLevel.BorderColor = System.Drawing.Color.Black;
            this.lblSystemVolumeLevel.BorderSpace = 0;
            this.lblSystemVolumeLevel.CharSpacing = 2;
            this.lblSystemVolumeLevel.DotMatrix = LCDLabel.DotMatrix.mat5x8;
            this.lblSystemVolumeLevel.LineSpacing = 2;
            this.lblSystemVolumeLevel.Location = new System.Drawing.Point(4, 202);
            this.lblSystemVolumeLevel.Name = "lblSystemVolumeLevel";
            this.lblSystemVolumeLevel.NumberOfCharacters = 19;
            this.lblSystemVolumeLevel.PixelHeight = 2;
            this.lblSystemVolumeLevel.PixelOff = System.Drawing.Color.Indigo;
            this.lblSystemVolumeLevel.PixelOn = System.Drawing.Color.DeepSkyBlue;
            this.lblSystemVolumeLevel.PixelShape = LCDLabel.PixelShape.Shaped;
            this.lblSystemVolumeLevel.PixelSize = LCDLabel.PixelSize.pix2x2;
            this.lblSystemVolumeLevel.PixelSpacing = 1;
            this.lblSystemVolumeLevel.PixelWidth = 2;
            this.lblSystemVolumeLevel.Size = new System.Drawing.Size(304, 25);
            this.lblSystemVolumeLevel.TabIndex = 59;
            this.lblSystemVolumeLevel.Text = "System Volume: 0%";
            this.lblSystemVolumeLevel.TextLines = 1;
            // 
            // lcdLabel1
            // 
            this.lcdLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lcdLabel1.BackGround = System.Drawing.Color.Black;
            this.lcdLabel1.BorderColor = System.Drawing.Color.Black;
            this.lcdLabel1.BorderSpace = 0;
            this.lcdLabel1.CharSpacing = 2;
            this.lcdLabel1.DotMatrix = LCDLabel.DotMatrix.mat5x8;
            this.lcdLabel1.LineSpacing = 2;
            this.lcdLabel1.Location = new System.Drawing.Point(308, 227);
            this.lcdLabel1.Name = "lcdLabel1";
            this.lcdLabel1.NumberOfCharacters = 19;
            this.lcdLabel1.PixelHeight = 2;
            this.lcdLabel1.PixelOff = System.Drawing.Color.Indigo;
            this.lcdLabel1.PixelOn = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(43)))), ((int)(((byte)(221)))));
            this.lcdLabel1.PixelShape = LCDLabel.PixelShape.Shaped;
            this.lcdLabel1.PixelSize = LCDLabel.PixelSize.pix2x2;
            this.lcdLabel1.PixelSpacing = 1;
            this.lcdLabel1.PixelWidth = 2;
            this.lcdLabel1.Size = new System.Drawing.Size(304, 25);
            this.lcdLabel1.TabIndex = 65;
            this.lcdLabel1.TextLines = 1;
            // 
            // lblCurrentVolumeOutput
            // 
            this.lblCurrentVolumeOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCurrentVolumeOutput.BackGround = System.Drawing.Color.Black;
            this.lblCurrentVolumeOutput.BorderColor = System.Drawing.Color.Black;
            this.lblCurrentVolumeOutput.BorderSpace = 0;
            this.lblCurrentVolumeOutput.CharSpacing = 2;
            this.lblCurrentVolumeOutput.DotMatrix = LCDLabel.DotMatrix.mat5x8;
            this.lblCurrentVolumeOutput.LineSpacing = 2;
            this.lblCurrentVolumeOutput.Location = new System.Drawing.Point(4, 177);
            this.lblCurrentVolumeOutput.Name = "lblCurrentVolumeOutput";
            this.lblCurrentVolumeOutput.NumberOfCharacters = 19;
            this.lblCurrentVolumeOutput.PixelHeight = 2;
            this.lblCurrentVolumeOutput.PixelOff = System.Drawing.Color.Indigo;
            this.lblCurrentVolumeOutput.PixelOn = System.Drawing.Color.DeepSkyBlue;
            this.lblCurrentVolumeOutput.PixelShape = LCDLabel.PixelShape.Shaped;
            this.lblCurrentVolumeOutput.PixelSize = LCDLabel.PixelSize.pix2x2;
            this.lblCurrentVolumeOutput.PixelSpacing = 1;
            this.lblCurrentVolumeOutput.PixelWidth = 2;
            this.lblCurrentVolumeOutput.Size = new System.Drawing.Size(304, 25);
            this.lblCurrentVolumeOutput.TabIndex = 42;
            this.lblCurrentVolumeOutput.Text = "Input Volume:  0%";
            this.lblCurrentVolumeOutput.TextLines = 1;
            // 
            // pot2
            // 
            this.pot2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.pot2.Location = new System.Drawing.Point(133, 44);
            this.pot2.Maximum = 8000D;
            this.pot2.Minimum = 0D;
            this.pot2.Name = "pot2";
            this.pot2.Size = new System.Drawing.Size(67, 68);
            this.pot2.TabIndex = 40;
            this.pot2.Value = 250D;
            this.pot2.ValueChanged += new System.EventHandler(this.pot2_ValueChanged);
            // 
            // lcdLabel2
            // 
            this.lcdLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lcdLabel2.BackGround = System.Drawing.Color.Black;
            this.lcdLabel2.BorderColor = System.Drawing.Color.Black;
            this.lcdLabel2.BorderSpace = 0;
            this.lcdLabel2.CharSpacing = 2;
            this.lcdLabel2.DotMatrix = LCDLabel.DotMatrix.mat5x8;
            this.lcdLabel2.LineSpacing = 2;
            this.lcdLabel2.Location = new System.Drawing.Point(308, 252);
            this.lcdLabel2.Name = "lcdLabel2";
            this.lcdLabel2.NumberOfCharacters = 19;
            this.lcdLabel2.PixelHeight = 2;
            this.lcdLabel2.PixelOff = System.Drawing.Color.Indigo;
            this.lcdLabel2.PixelOn = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(43)))), ((int)(((byte)(221)))));
            this.lcdLabel2.PixelShape = LCDLabel.PixelShape.Shaped;
            this.lcdLabel2.PixelSize = LCDLabel.PixelSize.pix2x2;
            this.lcdLabel2.PixelSpacing = 1;
            this.lcdLabel2.PixelWidth = 2;
            this.lcdLabel2.Size = new System.Drawing.Size(304, 25);
            this.lcdLabel2.TabIndex = 66;
            this.lcdLabel2.TextLines = 1;
            // 
            // lblPeakVolume
            // 
            this.lblPeakVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPeakVolume.BackGround = System.Drawing.Color.Black;
            this.lblPeakVolume.BorderColor = System.Drawing.Color.Black;
            this.lblPeakVolume.BorderSpace = 0;
            this.lblPeakVolume.CharSpacing = 2;
            this.lblPeakVolume.DotMatrix = LCDLabel.DotMatrix.mat5x8;
            this.lblPeakVolume.LineSpacing = 2;
            this.lblPeakVolume.Location = new System.Drawing.Point(4, 152);
            this.lblPeakVolume.Name = "lblPeakVolume";
            this.lblPeakVolume.NumberOfCharacters = 19;
            this.lblPeakVolume.PixelHeight = 2;
            this.lblPeakVolume.PixelOff = System.Drawing.Color.Indigo;
            this.lblPeakVolume.PixelOn = System.Drawing.Color.DeepSkyBlue;
            this.lblPeakVolume.PixelShape = LCDLabel.PixelShape.Shaped;
            this.lblPeakVolume.PixelSize = LCDLabel.PixelSize.pix2x2;
            this.lblPeakVolume.PixelSpacing = 1;
            this.lblPeakVolume.PixelWidth = 2;
            this.lblPeakVolume.Size = new System.Drawing.Size(304, 25);
            this.lblPeakVolume.TabIndex = 58;
            this.lblPeakVolume.Text = "Peak Volume:   0%";
            this.lblPeakVolume.TextLines = 1;
            // 
            // lcdLabel3
            // 
            this.lcdLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lcdLabel3.BackGround = System.Drawing.Color.Black;
            this.lcdLabel3.BorderColor = System.Drawing.Color.Black;
            this.lcdLabel3.BorderSpace = 0;
            this.lcdLabel3.CharSpacing = 2;
            this.lcdLabel3.DotMatrix = LCDLabel.DotMatrix.mat5x8;
            this.lcdLabel3.LineSpacing = 2;
            this.lcdLabel3.Location = new System.Drawing.Point(3, 126);
            this.lcdLabel3.Name = "lcdLabel3";
            this.lcdLabel3.NumberOfCharacters = 38;
            this.lcdLabel3.PixelHeight = 2;
            this.lcdLabel3.PixelOff = System.Drawing.Color.MidnightBlue;
            this.lcdLabel3.PixelOn = System.Drawing.Color.DeepSkyBlue;
            this.lcdLabel3.PixelShape = LCDLabel.PixelShape.Shaped;
            this.lcdLabel3.PixelSize = LCDLabel.PixelSize.pix2x2;
            this.lcdLabel3.PixelSpacing = 1;
            this.lcdLabel3.PixelWidth = 2;
            this.lcdLabel3.Size = new System.Drawing.Size(608, 25);
            this.lcdLabel3.TabIndex = 68;
            this.lcdLabel3.Text = "         Gate  Lat.  Input Thresh";
            this.lcdLabel3.TextLines = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.lcdLabel3);
            this.panel2.Controls.Add(this.lblPeakVolume);
            this.panel2.Controls.Add(this.lcdLabel2);
            this.panel2.Controls.Add(this.pot2);
            this.panel2.Controls.Add(this.lblCurrentVolumeOutput);
            this.panel2.Controls.Add(this.lcdLabel1);
            this.panel2.Controls.Add(this.lblSystemVolumeLevel);
            this.panel2.Controls.Add(this.pot1);
            this.panel2.Controls.Add(this.lblNoiseGate);
            this.panel2.Controls.Add(this.lblCurrentPitchOutput);
            this.panel2.Controls.Add(this.lblLatency);
            this.panel2.Controls.Add(this.tbInputDeviceVolume);
            this.panel2.Controls.Add(this.lblLastNoteDetected);
            this.panel2.Controls.Add(this.lblThreshold);
            this.panel2.Controls.Add(this.tbThreshold);
            this.panel2.Location = new System.Drawing.Point(12, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(616, 281);
            this.panel2.TabIndex = 67;
            // 
            // lblClosestNote
            // 
            this.lblClosestNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblClosestNote.BackGround = System.Drawing.Color.Black;
            this.lblClosestNote.BorderColor = System.Drawing.Color.Black;
            this.lblClosestNote.BorderSpace = 0;
            this.lblClosestNote.CharSpacing = 2;
            this.lblClosestNote.DotMatrix = LCDLabel.DotMatrix.mat5x8;
            this.lblClosestNote.LineSpacing = 2;
            this.lblClosestNote.Location = new System.Drawing.Point(579, 348);
            this.lblClosestNote.Name = "lblClosestNote";
            this.lblClosestNote.NumberOfCharacters = 9;
            this.lblClosestNote.PixelHeight = 2;
            this.lblClosestNote.PixelOff = System.Drawing.Color.Indigo;
            this.lblClosestNote.PixelOn = System.Drawing.Color.DeepSkyBlue;
            this.lblClosestNote.PixelShape = LCDLabel.PixelShape.Shaped;
            this.lblClosestNote.PixelSize = LCDLabel.PixelSize.pix2x2;
            this.lblClosestNote.PixelSpacing = 1;
            this.lblClosestNote.PixelWidth = 2;
            this.lblClosestNote.Size = new System.Drawing.Size(144, 25);
            this.lblClosestNote.TabIndex = 68;
            this.lblClosestNote.Text = "----";
            this.lblClosestNote.TextLines = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Indigo;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(196, 531);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 69;
            // 
            // EntryPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1523, 928);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblClosestNote);
            this.Controls.Add(this.darkButton3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbInputDevices);
            this.Controls.Add(this.btnOpenSelectedMusicFile);
            this.Controls.Add(this.btnSelectMusicFolder);
            this.Controls.Add(this.darkSectionPanel4);
            this.Controls.Add(this.darkSectionPanel3);
            this.Controls.Add(this.darkSectionPanel2);
            this.Controls.Add(this.darkGroupBox2);
            this.Controls.Add(this.darkSeparator1);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.darkStatusStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EntryPoint";
            this.Text = "Bard Music Studio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EntryPoint_FormClosing);
            this.Load += new System.EventHandler(this.EntryPoint_Load);
            this.darkStatusStrip1.ResumeLayout(false);
            this.darkStatusStrip1.PerformLayout();
            this.darkGroupBox2.ResumeLayout(false);
            this.darkSectionPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.darkSectionPanel3.ResumeLayout(false);
            this.darkSectionPanel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageListMain;
        private System.ComponentModel.BackgroundWorker bgwMonitor;
        private System.Windows.Forms.Timer tmrUpdateVolume;
        private DarkUI.Controls.DarkComboBox cbInputDevices;
        private DarkUI.Controls.DarkStatusStrip darkStatusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private DarkUI.Controls.DarkButton btnListen;
        private DarkUI.Controls.DarkButton darkButton3;
        private DarkUI.Controls.DarkSeparator darkSeparator1;
        private DarkUI.Controls.DarkButton darkButton2;
        private System.Windows.Forms.Timer tmrUpdateValues;
        private DarkUI.Controls.DarkListView lbExternalLog;
        private DarkUI.Controls.DarkGroupBox darkGroupBox2;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel2;
        private DarkUI.Controls.DarkLabel lblTuneDirection;
        private DarkUI.Controls.DarkLabel lblBigHz;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel3;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel4;
        private ColorSlider.ColorSlider colorSlider1;
        private DarkUI.Controls.DarkLabel lblMetronomeSpeed;
        private DarkUI.Controls.DarkButton btnSelectMusicFolder;
        private DarkUI.Controls.DarkButton btnOpenSelectedMusicFile;
        private DarkUI.Controls.DarkListView dlLibrary;
        private System.Windows.Forms.Timer tmrVolumeTicker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timerTuner;
        private System.Windows.Forms.Timer tmrResetPeak;
        private NAudio.Gui.Pot tbThreshold;
        private LCDLabel.LcdLabel lblThreshold;
        private LCDLabel.LcdLabel lblLastNoteDetected;
        private NAudio.Gui.Pot tbInputDeviceVolume;
        private LCDLabel.LcdLabel lblLatency;
        private LCDLabel.LcdLabel lblCurrentPitchOutput;
        private LCDLabel.LcdLabel lblNoiseGate;
        private NAudio.Gui.Pot pot1;
        private LCDLabel.LcdLabel lblSystemVolumeLevel;
        private LCDLabel.LcdLabel lcdLabel1;
        private LCDLabel.LcdLabel lblCurrentVolumeOutput;
        private NAudio.Gui.Pot pot2;
        private LCDLabel.LcdLabel lcdLabel2;
        private LCDLabel.LcdLabel lblPeakVolume;
        private LCDLabel.LcdLabel lcdLabel3;
        private System.Windows.Forms.Panel panel2;
        private LCDLabel.LcdLabel lblClosestNote;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}