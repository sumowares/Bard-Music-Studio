
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.imageListMain = new System.Windows.Forms.ImageList(this.components);
            this.bgwMonitor = new System.ComponentModel.BackgroundWorker();
            this.tmrUpdateVolume = new System.Windows.Forms.Timer(this.components);
            this.pbAudioLevel = new CircularProgressBar.CircularProgressBar();
            this.darkMenuStrip1 = new DarkUI.Controls.DarkMenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLoadoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLoadoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contributeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitOurDiscordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.becomeAPatreonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeAOnetimeDonationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbInputDevices = new DarkUI.Controls.DarkComboBox();
            this.darkGroupBox1 = new DarkUI.Controls.DarkGroupBox();
            this.darkLabel10 = new DarkUI.Controls.DarkLabel();
            this.pot2 = new NAudio.Gui.Pot();
            this.lChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.darkLabel3 = new DarkUI.Controls.DarkLabel();
            this.darkTitle1 = new DarkUI.Controls.DarkTitle();
            this.pot1 = new NAudio.Gui.Pot();
            this.tbInputDeviceVolume = new NAudio.Gui.Pot();
            this.darkLabel2 = new DarkUI.Controls.DarkLabel();
            this.tbThreshold = new NAudio.Gui.Pot();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.darkSectionPanel1 = new DarkUI.Controls.DarkSectionPanel();
            this.darkStatusStrip1 = new DarkUI.Controls.DarkStatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.darkButton1 = new DarkUI.Controls.DarkButton();
            this.btnListen = new DarkUI.Controls.DarkButton();
            this.darkSeparator1 = new DarkUI.Controls.DarkSeparator();
            this.darkButton2 = new DarkUI.Controls.DarkButton();
            this.tmrUpdateValues = new System.Windows.Forms.Timer(this.components);
            this.lbExternalLog = new DarkUI.Controls.DarkListView();
            this.darkGroupBox2 = new DarkUI.Controls.DarkGroupBox();
            this.darkLabel4 = new DarkUI.Controls.DarkLabel();
            this.darkLabel5 = new DarkUI.Controls.DarkLabel();
            this.darkLabel6 = new DarkUI.Controls.DarkLabel();
            this.darkLabel7 = new DarkUI.Controls.DarkLabel();
            this.darkLabel8 = new DarkUI.Controls.DarkLabel();
            this.darkLabel9 = new DarkUI.Controls.DarkLabel();
            this.lblPeakVolume = new DarkUI.Controls.DarkLabel();
            this.lblCurrentPitchOutput = new DarkUI.Controls.DarkLabel();
            this.lblCurrentVolumeOutput = new DarkUI.Controls.DarkLabel();
            this.lblSystemVolumeLevel = new DarkUI.Controls.DarkLabel();
            this.lblLastNoteDetected = new DarkUI.Controls.DarkLabel();
            this.lblThreshold = new DarkUI.Controls.DarkLabel();
            this.darkButton4 = new DarkUI.Controls.DarkButton();
            this.lblLatency = new DarkUI.Controls.DarkLabel();
            this.darkLabel11 = new DarkUI.Controls.DarkLabel();
            this.lblNoiseGate = new DarkUI.Controls.DarkLabel();
            this.darkLabel13 = new DarkUI.Controls.DarkLabel();
            this.darkSectionPanel2 = new DarkUI.Controls.DarkSectionPanel();
            this.lblBigHz = new DarkUI.Controls.DarkLabel();
            this.lblTuneDirection = new DarkUI.Controls.DarkLabel();
            this.lblClosestNote = new DarkUI.Controls.DarkLabel();
            this.darkSectionPanel3 = new DarkUI.Controls.DarkSectionPanel();
            this.lblMetronomeSpeed = new DarkUI.Controls.DarkLabel();
            this.colorSlider1 = new ColorSlider.ColorSlider();
            this.darkSectionPanel4 = new DarkUI.Controls.DarkSectionPanel();
            this.dlLibrary = new DarkUI.Controls.DarkListView();
            this.btnSelectMusicFolder = new DarkUI.Controls.DarkButton();
            this.btnOpenSelectedMusicFile = new DarkUI.Controls.DarkButton();
            this.tmrVolumeTicker = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.darkButton3 = new DarkUI.Controls.DarkButton();
            this.pbSupport = new System.Windows.Forms.PictureBox();
            this.timerTuner = new System.Windows.Forms.Timer(this.components);
            this.darkMenuStrip1.SuspendLayout();
            this.darkGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lChart)).BeginInit();
            this.darkSectionPanel1.SuspendLayout();
            this.darkStatusStrip1.SuspendLayout();
            this.darkGroupBox2.SuspendLayout();
            this.darkSectionPanel2.SuspendLayout();
            this.darkSectionPanel3.SuspendLayout();
            this.darkSectionPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSupport)).BeginInit();
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
            // pbAudioLevel
            // 
            this.pbAudioLevel.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.pbAudioLevel.AnimationSpeed = 10;
            this.pbAudioLevel.BackColor = System.Drawing.Color.Transparent;
            this.pbAudioLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.pbAudioLevel.ForeColor = System.Drawing.Color.Transparent;
            this.pbAudioLevel.InnerColor = System.Drawing.Color.Transparent;
            this.pbAudioLevel.InnerMargin = 2;
            this.pbAudioLevel.InnerWidth = -1;
            this.pbAudioLevel.Location = new System.Drawing.Point(540, 29);
            this.pbAudioLevel.MarqueeAnimationSpeed = 2000;
            this.pbAudioLevel.Name = "pbAudioLevel";
            this.pbAudioLevel.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pbAudioLevel.OuterMargin = -25;
            this.pbAudioLevel.OuterWidth = 26;
            this.pbAudioLevel.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(43)))), ((int)(((byte)(221)))));
            this.pbAudioLevel.ProgressWidth = 25;
            this.pbAudioLevel.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.pbAudioLevel.Size = new System.Drawing.Size(160, 160);
            this.pbAudioLevel.StartAngle = 270;
            this.pbAudioLevel.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pbAudioLevel.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.pbAudioLevel.SubscriptText = ".23";
            this.pbAudioLevel.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pbAudioLevel.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.pbAudioLevel.SuperscriptText = "°C";
            this.pbAudioLevel.TabIndex = 20;
            this.pbAudioLevel.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.pbAudioLevel.Value = 68;
            // 
            // darkMenuStrip1
            // 
            this.darkMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkMenuStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.contributeToolStripMenuItem});
            this.darkMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.darkMenuStrip1.Name = "darkMenuStrip1";
            this.darkMenuStrip1.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.darkMenuStrip1.Size = new System.Drawing.Size(1039, 24);
            this.darkMenuStrip1.TabIndex = 21;
            this.darkMenuStrip1.Text = "darkMenuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openLoadoutToolStripMenuItem,
            this.saveLoadoutToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openLoadoutToolStripMenuItem
            // 
            this.openLoadoutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.openLoadoutToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.openLoadoutToolStripMenuItem.Name = "openLoadoutToolStripMenuItem";
            this.openLoadoutToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.openLoadoutToolStripMenuItem.Text = "&Open Loadout";
            this.openLoadoutToolStripMenuItem.Click += new System.EventHandler(this.openLoadoutToolStripMenuItem_Click);
            // 
            // saveLoadoutToolStripMenuItem
            // 
            this.saveLoadoutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.saveLoadoutToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.saveLoadoutToolStripMenuItem.Name = "saveLoadoutToolStripMenuItem";
            this.saveLoadoutToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.saveLoadoutToolStripMenuItem.Text = "&Save Loadout";
            this.saveLoadoutToolStripMenuItem.Click += new System.EventHandler(this.saveLoadoutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripMenuItem2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(147, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contributeToolStripMenuItem
            // 
            this.contributeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.contributeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.contributeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visitOurDiscordToolStripMenuItem,
            this.toolStripMenuItem1,
            this.becomeAPatreonToolStripMenuItem,
            this.makeAOnetimeDonationToolStripMenuItem});
            this.contributeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.contributeToolStripMenuItem.Name = "contributeToolStripMenuItem";
            this.contributeToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.contributeToolStripMenuItem.Text = "&Contribute";
            // 
            // visitOurDiscordToolStripMenuItem
            // 
            this.visitOurDiscordToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.visitOurDiscordToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.visitOurDiscordToolStripMenuItem.Name = "visitOurDiscordToolStripMenuItem";
            this.visitOurDiscordToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.visitOurDiscordToolStripMenuItem.Text = "Visit our Discord";
            this.visitOurDiscordToolStripMenuItem.Click += new System.EventHandler(this.visitOurDiscordToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripMenuItem1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(213, 6);
            // 
            // becomeAPatreonToolStripMenuItem
            // 
            this.becomeAPatreonToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.becomeAPatreonToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.becomeAPatreonToolStripMenuItem.Name = "becomeAPatreonToolStripMenuItem";
            this.becomeAPatreonToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.becomeAPatreonToolStripMenuItem.Text = "Become a Patreon";
            this.becomeAPatreonToolStripMenuItem.Click += new System.EventHandler(this.becomeAPatreonToolStripMenuItem_Click);
            // 
            // makeAOnetimeDonationToolStripMenuItem
            // 
            this.makeAOnetimeDonationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.makeAOnetimeDonationToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.makeAOnetimeDonationToolStripMenuItem.Name = "makeAOnetimeDonationToolStripMenuItem";
            this.makeAOnetimeDonationToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.makeAOnetimeDonationToolStripMenuItem.Text = "Make a one-time Donation";
            this.makeAOnetimeDonationToolStripMenuItem.Click += new System.EventHandler(this.makeAOnetimeDonationToolStripMenuItem_Click);
            // 
            // cbInputDevices
            // 
            this.cbInputDevices.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbInputDevices.FormattingEnabled = true;
            this.cbInputDevices.Location = new System.Drawing.Point(86, 32);
            this.cbInputDevices.Name = "cbInputDevices";
            this.cbInputDevices.Size = new System.Drawing.Size(386, 21);
            this.cbInputDevices.TabIndex = 22;
            // 
            // darkGroupBox1
            // 
            this.darkGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.darkGroupBox1.Controls.Add(this.darkLabel10);
            this.darkGroupBox1.Controls.Add(this.pot2);
            this.darkGroupBox1.Controls.Add(this.lChart);
            this.darkGroupBox1.Controls.Add(this.darkLabel3);
            this.darkGroupBox1.Controls.Add(this.darkButton3);
            this.darkGroupBox1.Controls.Add(this.darkTitle1);
            this.darkGroupBox1.Controls.Add(this.pot1);
            this.darkGroupBox1.Controls.Add(this.cbInputDevices);
            this.darkGroupBox1.Controls.Add(this.tbInputDeviceVolume);
            this.darkGroupBox1.Controls.Add(this.darkLabel2);
            this.darkGroupBox1.Controls.Add(this.tbThreshold);
            this.darkGroupBox1.Controls.Add(this.darkLabel1);
            this.darkGroupBox1.Location = new System.Drawing.Point(4, 29);
            this.darkGroupBox1.Name = "darkGroupBox1";
            this.darkGroupBox1.Size = new System.Drawing.Size(530, 317);
            this.darkGroupBox1.TabIndex = 23;
            this.darkGroupBox1.TabStop = false;
            // 
            // darkLabel10
            // 
            this.darkLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel10.Location = new System.Drawing.Point(83, 289);
            this.darkLabel10.Name = "darkLabel10";
            this.darkLabel10.Size = new System.Drawing.Size(70, 23);
            this.darkLabel10.TabIndex = 41;
            this.darkLabel10.Text = "Gate";
            this.darkLabel10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pot2
            // 
            this.pot2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(43)))), ((int)(((byte)(221)))));
            this.pot2.Location = new System.Drawing.Point(86, 218);
            this.pot2.Maximum = 8000D;
            this.pot2.Minimum = 0D;
            this.pot2.Name = "pot2";
            this.pot2.Size = new System.Drawing.Size(67, 68);
            this.pot2.TabIndex = 40;
            this.pot2.Value = 250D;
            this.pot2.ValueChanged += new System.EventHandler(this.pot2_ValueChanged);
            // 
            // lChart
            // 
            this.lChart.BackColor = System.Drawing.Color.Transparent;
            this.lChart.BorderlineColor = System.Drawing.Color.Transparent;
            this.lChart.BorderlineWidth = 0;
            this.lChart.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            chartArea10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            chartArea10.Name = "ChartArea1";
            this.lChart.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.lChart.Legends.Add(legend10);
            this.lChart.Location = new System.Drawing.Point(5, 59);
            this.lChart.Name = "lChart";
            this.lChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.lChart.Series.Add(series10);
            this.lChart.Size = new System.Drawing.Size(519, 153);
            this.lChart.TabIndex = 33;
            this.lChart.Text = "Live Audio Waveform";
            // 
            // darkLabel3
            // 
            this.darkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel3.Location = new System.Drawing.Point(186, 289);
            this.darkLabel3.Name = "darkLabel3";
            this.darkLabel3.Size = new System.Drawing.Size(70, 23);
            this.darkLabel3.TabIndex = 39;
            this.darkLabel3.Text = "Delay";
            this.darkLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // darkTitle1
            // 
            this.darkTitle1.Location = new System.Drawing.Point(6, 16);
            this.darkTitle1.Name = "darkTitle1";
            this.darkTitle1.Size = new System.Drawing.Size(518, 13);
            this.darkTitle1.TabIndex = 30;
            this.darkTitle1.Text = "Audio Input Device";
            // 
            // pot1
            // 
            this.pot1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(43)))), ((int)(((byte)(221)))));
            this.pot1.Location = new System.Drawing.Point(189, 218);
            this.pot1.Maximum = 1000D;
            this.pot1.Minimum = 0D;
            this.pot1.Name = "pot1";
            this.pot1.Size = new System.Drawing.Size(67, 68);
            this.pot1.TabIndex = 38;
            this.pot1.Value = 250D;
            this.pot1.ValueChanged += new System.EventHandler(this.pot1_ValueChanged);
            // 
            // tbInputDeviceVolume
            // 
            this.tbInputDeviceVolume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(43)))), ((int)(((byte)(221)))));
            this.tbInputDeviceVolume.Location = new System.Drawing.Point(292, 218);
            this.tbInputDeviceVolume.Maximum = 100D;
            this.tbInputDeviceVolume.Minimum = 0D;
            this.tbInputDeviceVolume.Name = "tbInputDeviceVolume";
            this.tbInputDeviceVolume.Size = new System.Drawing.Size(67, 68);
            this.tbInputDeviceVolume.TabIndex = 35;
            this.tbInputDeviceVolume.Value = 0.5D;
            this.tbInputDeviceVolume.ValueChanged += new System.EventHandler(this.tbInputDeviceVolume_ValueChanged);
            // 
            // darkLabel2
            // 
            this.darkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel2.Location = new System.Drawing.Point(392, 289);
            this.darkLabel2.Name = "darkLabel2";
            this.darkLabel2.Size = new System.Drawing.Size(70, 23);
            this.darkLabel2.TabIndex = 37;
            this.darkLabel2.Text = "Thresh";
            this.darkLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbThreshold
            // 
            this.tbThreshold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(43)))), ((int)(((byte)(221)))));
            this.tbThreshold.Location = new System.Drawing.Point(395, 218);
            this.tbThreshold.Maximum = 100D;
            this.tbThreshold.Minimum = 0D;
            this.tbThreshold.Name = "tbThreshold";
            this.tbThreshold.Size = new System.Drawing.Size(67, 68);
            this.tbThreshold.TabIndex = 34;
            this.tbThreshold.Value = 24D;
            this.tbThreshold.ValueChanged += new System.EventHandler(this.tbThreshold_ValueChanged);
            // 
            // darkLabel1
            // 
            this.darkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(289, 289);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(70, 23);
            this.darkLabel1.TabIndex = 36;
            this.darkLabel1.Text = "Input";
            this.darkLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // darkSectionPanel1
            // 
            this.darkSectionPanel1.Controls.Add(this.darkGroupBox1);
            this.darkSectionPanel1.Controls.Add(this.pbAudioLevel);
            this.darkSectionPanel1.Controls.Add(this.pbSupport);
            this.darkSectionPanel1.Location = new System.Drawing.Point(12, 32);
            this.darkSectionPanel1.Name = "darkSectionPanel1";
            this.darkSectionPanel1.SectionHeader = "Bard Music Studio Audio Monitor";
            this.darkSectionPanel1.Size = new System.Drawing.Size(715, 358);
            this.darkSectionPanel1.TabIndex = 24;
            // 
            // darkStatusStrip1
            // 
            this.darkStatusStrip1.AutoSize = false;
            this.darkStatusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkStatusStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkStatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.darkStatusStrip1.Location = new System.Drawing.Point(0, 649);
            this.darkStatusStrip1.Name = "darkStatusStrip1";
            this.darkStatusStrip1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.darkStatusStrip1.Size = new System.Drawing.Size(1039, 28);
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
            // darkButton1
            // 
            this.darkButton1.Location = new System.Drawing.Point(571, 613);
            this.darkButton1.Name = "darkButton1";
            this.darkButton1.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton1.Size = new System.Drawing.Size(75, 23);
            this.darkButton1.TabIndex = 27;
            this.darkButton1.Text = "Reset";
            this.darkButton1.Click += new System.EventHandler(this.btnResetPeakValue_Click);
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(652, 613);
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
            this.darkSeparator1.Location = new System.Drawing.Point(0, 24);
            this.darkSeparator1.Name = "darkSeparator1";
            this.darkSeparator1.Size = new System.Drawing.Size(1039, 2);
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
            this.darkGroupBox2.Location = new System.Drawing.Point(316, 396);
            this.darkGroupBox2.Name = "darkGroupBox2";
            this.darkGroupBox2.Size = new System.Drawing.Size(411, 211);
            this.darkGroupBox2.TabIndex = 34;
            this.darkGroupBox2.TabStop = false;
            this.darkGroupBox2.Text = "System Log";
            // 
            // darkLabel4
            // 
            this.darkLabel4.AutoSize = true;
            this.darkLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel4.Location = new System.Drawing.Point(13, 402);
            this.darkLabel4.Name = "darkLabel4";
            this.darkLabel4.Size = new System.Drawing.Size(127, 13);
            this.darkLabel4.TabIndex = 35;
            this.darkLabel4.Text = "Peak Volume Output:";
            // 
            // darkLabel5
            // 
            this.darkLabel5.AutoSize = true;
            this.darkLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel5.Location = new System.Drawing.Point(13, 423);
            this.darkLabel5.Name = "darkLabel5";
            this.darkLabel5.Size = new System.Drawing.Size(127, 13);
            this.darkLabel5.TabIndex = 36;
            this.darkLabel5.Text = "Current Pitch Output:";
            // 
            // darkLabel6
            // 
            this.darkLabel6.AutoSize = true;
            this.darkLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel6.Location = new System.Drawing.Point(13, 444);
            this.darkLabel6.Name = "darkLabel6";
            this.darkLabel6.Size = new System.Drawing.Size(139, 13);
            this.darkLabel6.TabIndex = 37;
            this.darkLabel6.Text = "Current Volume Output:";
            // 
            // darkLabel7
            // 
            this.darkLabel7.AutoSize = true;
            this.darkLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel7.Location = new System.Drawing.Point(13, 465);
            this.darkLabel7.Name = "darkLabel7";
            this.darkLabel7.Size = new System.Drawing.Size(131, 13);
            this.darkLabel7.TabIndex = 38;
            this.darkLabel7.Text = "System Volume Level:";
            // 
            // darkLabel8
            // 
            this.darkLabel8.AutoSize = true;
            this.darkLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel8.Location = new System.Drawing.Point(13, 486);
            this.darkLabel8.Name = "darkLabel8";
            this.darkLabel8.Size = new System.Drawing.Size(122, 13);
            this.darkLabel8.TabIndex = 39;
            this.darkLabel8.Text = "Last Note Detected:";
            // 
            // darkLabel9
            // 
            this.darkLabel9.AutoSize = true;
            this.darkLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel9.Location = new System.Drawing.Point(13, 507);
            this.darkLabel9.Name = "darkLabel9";
            this.darkLabel9.Size = new System.Drawing.Size(103, 13);
            this.darkLabel9.TabIndex = 40;
            this.darkLabel9.Text = "Threshold Value:";
            // 
            // lblPeakVolume
            // 
            this.lblPeakVolume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblPeakVolume.Location = new System.Drawing.Point(201, 402);
            this.lblPeakVolume.Name = "lblPeakVolume";
            this.lblPeakVolume.Size = new System.Drawing.Size(109, 13);
            this.lblPeakVolume.TabIndex = 41;
            this.lblPeakVolume.Text = "n/a";
            // 
            // lblCurrentPitchOutput
            // 
            this.lblCurrentPitchOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblCurrentPitchOutput.Location = new System.Drawing.Point(201, 423);
            this.lblCurrentPitchOutput.Name = "lblCurrentPitchOutput";
            this.lblCurrentPitchOutput.Size = new System.Drawing.Size(109, 13);
            this.lblCurrentPitchOutput.TabIndex = 42;
            this.lblCurrentPitchOutput.Text = "n/a";
            // 
            // lblCurrentVolumeOutput
            // 
            this.lblCurrentVolumeOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblCurrentVolumeOutput.Location = new System.Drawing.Point(201, 444);
            this.lblCurrentVolumeOutput.Name = "lblCurrentVolumeOutput";
            this.lblCurrentVolumeOutput.Size = new System.Drawing.Size(109, 13);
            this.lblCurrentVolumeOutput.TabIndex = 43;
            this.lblCurrentVolumeOutput.Text = "n/a";
            // 
            // lblSystemVolumeLevel
            // 
            this.lblSystemVolumeLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblSystemVolumeLevel.Location = new System.Drawing.Point(201, 465);
            this.lblSystemVolumeLevel.Name = "lblSystemVolumeLevel";
            this.lblSystemVolumeLevel.Size = new System.Drawing.Size(109, 13);
            this.lblSystemVolumeLevel.TabIndex = 44;
            this.lblSystemVolumeLevel.Text = "n/a";
            // 
            // lblLastNoteDetected
            // 
            this.lblLastNoteDetected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblLastNoteDetected.Location = new System.Drawing.Point(201, 486);
            this.lblLastNoteDetected.Name = "lblLastNoteDetected";
            this.lblLastNoteDetected.Size = new System.Drawing.Size(109, 13);
            this.lblLastNoteDetected.TabIndex = 45;
            this.lblLastNoteDetected.Text = "n/a";
            // 
            // lblThreshold
            // 
            this.lblThreshold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblThreshold.Location = new System.Drawing.Point(201, 507);
            this.lblThreshold.Name = "lblThreshold";
            this.lblThreshold.Size = new System.Drawing.Size(109, 13);
            this.lblThreshold.TabIndex = 46;
            this.lblThreshold.Text = "n/a";
            // 
            // darkButton4
            // 
            this.darkButton4.Location = new System.Drawing.Point(12, 613);
            this.darkButton4.Name = "darkButton4";
            this.darkButton4.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton4.Size = new System.Drawing.Size(75, 23);
            this.darkButton4.TabIndex = 47;
            this.darkButton4.Text = "Help";
            // 
            // lblLatency
            // 
            this.lblLatency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblLatency.Location = new System.Drawing.Point(201, 528);
            this.lblLatency.Name = "lblLatency";
            this.lblLatency.Size = new System.Drawing.Size(109, 13);
            this.lblLatency.TabIndex = 50;
            this.lblLatency.Text = "n/a";
            // 
            // darkLabel11
            // 
            this.darkLabel11.AutoSize = true;
            this.darkLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel11.Location = new System.Drawing.Point(13, 528);
            this.darkLabel11.Name = "darkLabel11";
            this.darkLabel11.Size = new System.Drawing.Size(87, 13);
            this.darkLabel11.TabIndex = 49;
            this.darkLabel11.Text = "Note Latency:";
            // 
            // lblNoiseGate
            // 
            this.lblNoiseGate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblNoiseGate.Location = new System.Drawing.Point(201, 549);
            this.lblNoiseGate.Name = "lblNoiseGate";
            this.lblNoiseGate.Size = new System.Drawing.Size(109, 13);
            this.lblNoiseGate.TabIndex = 52;
            this.lblNoiseGate.Text = "n/a";
            // 
            // darkLabel13
            // 
            this.darkLabel13.AutoSize = true;
            this.darkLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel13.Location = new System.Drawing.Point(13, 549);
            this.darkLabel13.Name = "darkLabel13";
            this.darkLabel13.Size = new System.Drawing.Size(74, 13);
            this.darkLabel13.TabIndex = 51;
            this.darkLabel13.Text = "Noise Gate:";
            // 
            // darkSectionPanel2
            // 
            this.darkSectionPanel2.Controls.Add(this.panel1);
            this.darkSectionPanel2.Controls.Add(this.lblTuneDirection);
            this.darkSectionPanel2.Location = new System.Drawing.Point(733, 32);
            this.darkSectionPanel2.Name = "darkSectionPanel2";
            this.darkSectionPanel2.SectionHeader = "Instrument Tuner";
            this.darkSectionPanel2.Size = new System.Drawing.Size(294, 202);
            this.darkSectionPanel2.TabIndex = 53;
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
            // lblClosestNote
            // 
            this.lblClosestNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClosestNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(43)))), ((int)(((byte)(221)))));
            this.lblClosestNote.Location = new System.Drawing.Point(3, 16);
            this.lblClosestNote.Name = "lblClosestNote";
            this.lblClosestNote.Size = new System.Drawing.Size(280, 37);
            this.lblClosestNote.TabIndex = 0;
            this.lblClosestNote.Text = "--";
            this.lblClosestNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // darkSectionPanel3
            // 
            this.darkSectionPanel3.Controls.Add(this.lblMetronomeSpeed);
            this.darkSectionPanel3.Controls.Add(this.colorSlider1);
            this.darkSectionPanel3.Controls.Add(this.darkButton2);
            this.darkSectionPanel3.Location = new System.Drawing.Point(733, 240);
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
            this.darkSectionPanel4.Location = new System.Drawing.Point(733, 448);
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
            this.btnSelectMusicFolder.Location = new System.Drawing.Point(931, 612);
            this.btnSelectMusicFolder.Name = "btnSelectMusicFolder";
            this.btnSelectMusicFolder.Padding = new System.Windows.Forms.Padding(5);
            this.btnSelectMusicFolder.Size = new System.Drawing.Size(96, 23);
            this.btnSelectMusicFolder.TabIndex = 56;
            this.btnSelectMusicFolder.Text = "Select Folder";
            this.btnSelectMusicFolder.Click += new System.EventHandler(this.btnSelectMusicFolder_Click);
            // 
            // btnOpenSelectedMusicFile
            // 
            this.btnOpenSelectedMusicFile.Location = new System.Drawing.Point(829, 613);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lblBigHz);
            this.panel1.Controls.Add(this.lblClosestNote);
            this.panel1.Location = new System.Drawing.Point(4, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 100);
            this.panel1.TabIndex = 3;
            // 
            // darkButton3
            // 
            this.darkButton3.Image = ((System.Drawing.Image)(resources.GetObject("darkButton3.Image")));
            this.darkButton3.Location = new System.Drawing.Point(478, 27);
            this.darkButton3.Name = "darkButton3";
            this.darkButton3.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton3.Size = new System.Drawing.Size(28, 28);
            this.darkButton3.TabIndex = 29;
            this.darkButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.darkButton3.Click += new System.EventHandler(this.btnSetInputDevice_Click);
            // 
            // pbSupport
            // 
            this.pbSupport.BackColor = System.Drawing.Color.Transparent;
            this.pbSupport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbSupport.BackgroundImage")));
            this.pbSupport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbSupport.Location = new System.Drawing.Point(540, 248);
            this.pbSupport.Name = "pbSupport";
            this.pbSupport.Size = new System.Drawing.Size(160, 100);
            this.pbSupport.TabIndex = 48;
            this.pbSupport.TabStop = false;
            this.pbSupport.Click += new System.EventHandler(this.pbSupport_Click);
            // 
            // timerTuner
            // 
            this.timerTuner.Enabled = true;
            this.timerTuner.Interval = 1;
            this.timerTuner.Tick += new System.EventHandler(this.timerTuner_Tick);
            // 
            // EntryPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 677);
            this.Controls.Add(this.btnOpenSelectedMusicFile);
            this.Controls.Add(this.btnSelectMusicFolder);
            this.Controls.Add(this.darkSectionPanel4);
            this.Controls.Add(this.darkSectionPanel3);
            this.Controls.Add(this.darkSectionPanel2);
            this.Controls.Add(this.lblNoiseGate);
            this.Controls.Add(this.darkLabel13);
            this.Controls.Add(this.lblLatency);
            this.Controls.Add(this.darkLabel11);
            this.Controls.Add(this.darkButton4);
            this.Controls.Add(this.lblThreshold);
            this.Controls.Add(this.lblLastNoteDetected);
            this.Controls.Add(this.lblSystemVolumeLevel);
            this.Controls.Add(this.lblCurrentVolumeOutput);
            this.Controls.Add(this.lblCurrentPitchOutput);
            this.Controls.Add(this.lblPeakVolume);
            this.Controls.Add(this.darkLabel9);
            this.Controls.Add(this.darkLabel8);
            this.Controls.Add(this.darkLabel7);
            this.Controls.Add(this.darkLabel6);
            this.Controls.Add(this.darkLabel5);
            this.Controls.Add(this.darkLabel4);
            this.Controls.Add(this.darkGroupBox2);
            this.Controls.Add(this.darkSeparator1);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.darkButton1);
            this.Controls.Add(this.darkStatusStrip1);
            this.Controls.Add(this.darkSectionPanel1);
            this.Controls.Add(this.darkMenuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EntryPoint";
            this.Text = "Bard Music Studio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EntryPoint_FormClosing);
            this.darkMenuStrip1.ResumeLayout(false);
            this.darkMenuStrip1.PerformLayout();
            this.darkGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lChart)).EndInit();
            this.darkSectionPanel1.ResumeLayout(false);
            this.darkStatusStrip1.ResumeLayout(false);
            this.darkStatusStrip1.PerformLayout();
            this.darkGroupBox2.ResumeLayout(false);
            this.darkSectionPanel2.ResumeLayout(false);
            this.darkSectionPanel3.ResumeLayout(false);
            this.darkSectionPanel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSupport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageListMain;
        private System.ComponentModel.BackgroundWorker bgwMonitor;
        private System.Windows.Forms.Timer tmrUpdateVolume;
        private CircularProgressBar.CircularProgressBar pbAudioLevel;
        private DarkUI.Controls.DarkMenuStrip darkMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contributeToolStripMenuItem;
        private DarkUI.Controls.DarkComboBox cbInputDevices;
        private DarkUI.Controls.DarkGroupBox darkGroupBox1;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel1;
        private DarkUI.Controls.DarkStatusStrip darkStatusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private DarkUI.Controls.DarkButton darkButton1;
        private DarkUI.Controls.DarkButton btnListen;
        private DarkUI.Controls.DarkButton darkButton3;
        private DarkUI.Controls.DarkTitle darkTitle1;
        private DarkUI.Controls.DarkSeparator darkSeparator1;
        private NAudio.Gui.Pot tbThreshold;
        private NAudio.Gui.Pot tbInputDeviceVolume;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkLabel darkLabel2;
        private DarkUI.Controls.DarkLabel darkLabel3;
        private NAudio.Gui.Pot pot1;
        private DarkUI.Controls.DarkButton darkButton2;
        private System.Windows.Forms.DataVisualization.Charting.Chart lChart;
        private System.Windows.Forms.Timer tmrUpdateValues;
        private DarkUI.Controls.DarkListView lbExternalLog;
        private DarkUI.Controls.DarkGroupBox darkGroupBox2;
        private DarkUI.Controls.DarkLabel darkLabel4;
        private DarkUI.Controls.DarkLabel darkLabel5;
        private DarkUI.Controls.DarkLabel darkLabel6;
        private DarkUI.Controls.DarkLabel darkLabel7;
        private DarkUI.Controls.DarkLabel darkLabel8;
        private DarkUI.Controls.DarkLabel darkLabel9;
        private DarkUI.Controls.DarkLabel lblPeakVolume;
        private DarkUI.Controls.DarkLabel lblCurrentPitchOutput;
        private DarkUI.Controls.DarkLabel lblCurrentVolumeOutput;
        private DarkUI.Controls.DarkLabel lblSystemVolumeLevel;
        private DarkUI.Controls.DarkLabel lblLastNoteDetected;
        private DarkUI.Controls.DarkLabel lblThreshold;
        private System.Windows.Forms.PictureBox pbSupport;
        private DarkUI.Controls.DarkButton darkButton4;
        private DarkUI.Controls.DarkLabel lblLatency;
        private DarkUI.Controls.DarkLabel darkLabel11;
        private DarkUI.Controls.DarkLabel darkLabel10;
        private NAudio.Gui.Pot pot2;
        private DarkUI.Controls.DarkLabel lblNoiseGate;
        private DarkUI.Controls.DarkLabel darkLabel13;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel2;
        private DarkUI.Controls.DarkLabel lblClosestNote;
        private DarkUI.Controls.DarkLabel lblTuneDirection;
        private DarkUI.Controls.DarkLabel lblBigHz;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel3;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel4;
        private ColorSlider.ColorSlider colorSlider1;
        private DarkUI.Controls.DarkLabel lblMetronomeSpeed;
        private System.Windows.Forms.ToolStripMenuItem visitOurDiscordToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem becomeAPatreonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeAOnetimeDonationToolStripMenuItem;
        private DarkUI.Controls.DarkButton btnSelectMusicFolder;
        private DarkUI.Controls.DarkButton btnOpenSelectedMusicFile;
        private DarkUI.Controls.DarkListView dlLibrary;
        private System.Windows.Forms.ToolStripMenuItem openLoadoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveLoadoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer tmrVolumeTicker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timerTuner;
    }
}