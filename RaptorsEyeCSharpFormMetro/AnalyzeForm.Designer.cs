namespace RaptorsEyeCSharpFormMetro
{
    partial class AnalyzeForm
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
            ReleaseData();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalyzeForm));
            this.pictureBoxRaptorsEyeCrest = new System.Windows.Forms.PictureBox();
            this.backgroundWorkerMain = new System.ComponentModel.BackgroundWorker();
            this.metroProgressSpinnerMainLoad = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroProgressBarMain = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabelBackgroudProgress = new MetroFramework.Controls.MetroLabel();
            this.splitContainerVideo = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanelVideoLeft = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelVideoControlMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelVideoControl = new System.Windows.Forms.TableLayoutPanel();
            this.buttonVideoStop = new System.Windows.Forms.Button();
            this.buttonVideoFoward = new System.Windows.Forms.Button();
            this.buttonVideoPrev = new System.Windows.Forms.Button();
            this.buttonVideoPlay = new System.Windows.Forms.Button();
            this.metroTrackBarVideoSeeker = new MetroFramework.Controls.MetroTrackBar();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openVideoToolStripMenuItemVideo = new System.Windows.Forms.ToolStripMenuItem();
            this.openPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLiveCamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToTrainingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutRaptorsEyeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainImageBox = new Emgu.CV.UI.ImageBox();
            this.tableLayoutPanelVideoRight = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelVideoSort = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.labelSort = new System.Windows.Forms.Label();
            this.metroComboBoxSort = new MetroFramework.Controls.MetroComboBox();
            this.flowLayoutPanelData = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRaptorsEyeCrest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerVideo)).BeginInit();
            this.splitContainerVideo.Panel1.SuspendLayout();
            this.splitContainerVideo.Panel2.SuspendLayout();
            this.splitContainerVideo.SuspendLayout();
            this.tableLayoutPanelVideoLeft.SuspendLayout();
            this.tableLayoutPanelVideoControlMain.SuspendLayout();
            this.tableLayoutPanelVideoControl.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainImageBox)).BeginInit();
            this.tableLayoutPanelVideoRight.SuspendLayout();
            this.tableLayoutPanelVideoSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxRaptorsEyeCrest
            // 
            this.pictureBoxRaptorsEyeCrest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxRaptorsEyeCrest.BackgroundImage")));
            this.pictureBoxRaptorsEyeCrest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxRaptorsEyeCrest.Location = new System.Drawing.Point(7, 8);
            this.pictureBoxRaptorsEyeCrest.Name = "pictureBoxRaptorsEyeCrest";
            this.pictureBoxRaptorsEyeCrest.Size = new System.Drawing.Size(156, 37);
            this.pictureBoxRaptorsEyeCrest.TabIndex = 1;
            this.pictureBoxRaptorsEyeCrest.TabStop = false;
            // 
            // backgroundWorkerMain
            // 
            this.backgroundWorkerMain.WorkerReportsProgress = true;
            this.backgroundWorkerMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerMain_DoWork);
            this.backgroundWorkerMain.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerMain_ProgressChanged);
            this.backgroundWorkerMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerMain_RunWorkerCompleted);
            // 
            // metroProgressSpinnerMainLoad
            // 
            this.metroProgressSpinnerMainLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroProgressSpinnerMainLoad.Location = new System.Drawing.Point(166, 13);
            this.metroProgressSpinnerMainLoad.Maximum = 100;
            this.metroProgressSpinnerMainLoad.Name = "metroProgressSpinnerMainLoad";
            this.metroProgressSpinnerMainLoad.Size = new System.Drawing.Size(30, 30);
            this.metroProgressSpinnerMainLoad.Speed = 5F;
            this.metroProgressSpinnerMainLoad.Style = MetroFramework.MetroColorStyle.Red;
            this.metroProgressSpinnerMainLoad.TabIndex = 3;
            this.metroProgressSpinnerMainLoad.UseCustomBackColor = true;
            this.metroProgressSpinnerMainLoad.UseSelectable = true;
            this.metroProgressSpinnerMainLoad.UseStyleColors = true;
            this.metroProgressSpinnerMainLoad.Visible = false;
            // 
            // metroProgressBarMain
            // 
            this.metroProgressBarMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroProgressBarMain.Location = new System.Drawing.Point(0, 0);
            this.metroProgressBarMain.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.metroProgressBarMain.Name = "metroProgressBarMain";
            this.metroProgressBarMain.Size = new System.Drawing.Size(745, 5);
            this.metroProgressBarMain.Style = MetroFramework.MetroColorStyle.Red;
            this.metroProgressBarMain.TabIndex = 4;
            this.metroProgressBarMain.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroProgressBarMain.UseCustomBackColor = true;
            // 
            // metroLabelBackgroudProgress
            // 
            this.metroLabelBackgroudProgress.AutoSize = true;
            this.metroLabelBackgroudProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroLabelBackgroudProgress.ForeColor = System.Drawing.Color.White;
            this.metroLabelBackgroudProgress.Location = new System.Drawing.Point(202, 19);
            this.metroLabelBackgroudProgress.Name = "metroLabelBackgroudProgress";
            this.metroLabelBackgroudProgress.Size = new System.Drawing.Size(65, 19);
            this.metroLabelBackgroudProgress.TabIndex = 5;
            this.metroLabelBackgroudProgress.Text = "Loading...";
            this.metroLabelBackgroudProgress.UseCustomBackColor = true;
            this.metroLabelBackgroudProgress.UseCustomForeColor = true;
            this.metroLabelBackgroudProgress.Visible = false;
            // 
            // splitContainerVideo
            // 
            this.splitContainerVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitContainerVideo.BackgroundImage = global::RaptorsEyeCSharpFormMetro.Properties.Resources.color;
            this.splitContainerVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerVideo.Location = new System.Drawing.Point(20, 60);
            this.splitContainerVideo.Name = "splitContainerVideo";
            // 
            // splitContainerVideo.Panel1
            // 
            this.splitContainerVideo.Panel1.Controls.Add(this.tableLayoutPanelVideoLeft);
            this.splitContainerVideo.Panel1MinSize = 450;
            // 
            // splitContainerVideo.Panel2
            // 
            this.splitContainerVideo.Panel2.Controls.Add(this.tableLayoutPanelVideoRight);
            this.splitContainerVideo.Panel2MinSize = 210;
            this.splitContainerVideo.Size = new System.Drawing.Size(705, 465);
            this.splitContainerVideo.SplitterDistance = 458;
            this.splitContainerVideo.SplitterWidth = 1;
            this.splitContainerVideo.TabIndex = 6;
            // 
            // tableLayoutPanelVideoLeft
            // 
            this.tableLayoutPanelVideoLeft.BackgroundImage = global::RaptorsEyeCSharpFormMetro.Properties.Resources.color;
            this.tableLayoutPanelVideoLeft.ColumnCount = 1;
            this.tableLayoutPanelVideoLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelVideoLeft.Controls.Add(this.tableLayoutPanelVideoControlMain, 0, 2);
            this.tableLayoutPanelVideoLeft.Controls.Add(this.menuStrip, 0, 0);
            this.tableLayoutPanelVideoLeft.Controls.Add(this.mainImageBox, 0, 1);
            this.tableLayoutPanelVideoLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelVideoLeft.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelVideoLeft.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelVideoLeft.Name = "tableLayoutPanelVideoLeft";
            this.tableLayoutPanelVideoLeft.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.tableLayoutPanelVideoLeft.RowCount = 3;
            this.tableLayoutPanelVideoLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanelVideoLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelVideoLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelVideoLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoLeft.Size = new System.Drawing.Size(458, 465);
            this.tableLayoutPanelVideoLeft.TabIndex = 0;
            // 
            // tableLayoutPanelVideoControlMain
            // 
            this.tableLayoutPanelVideoControlMain.BackgroundImage = global::RaptorsEyeCSharpFormMetro.Properties.Resources.color;
            this.tableLayoutPanelVideoControlMain.ColumnCount = 1;
            this.tableLayoutPanelVideoControlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelVideoControlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoControlMain.Controls.Add(this.tableLayoutPanelVideoControl, 0, 1);
            this.tableLayoutPanelVideoControlMain.Controls.Add(this.metroTrackBarVideoSeeker, 0, 0);
            this.tableLayoutPanelVideoControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelVideoControlMain.Location = new System.Drawing.Point(3, 363);
            this.tableLayoutPanelVideoControlMain.Name = "tableLayoutPanelVideoControlMain";
            this.tableLayoutPanelVideoControlMain.RowCount = 2;
            this.tableLayoutPanelVideoControlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanelVideoControlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelVideoControlMain.Size = new System.Drawing.Size(452, 94);
            this.tableLayoutPanelVideoControlMain.TabIndex = 6;
            // 
            // tableLayoutPanelVideoControl
            // 
            this.tableLayoutPanelVideoControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelVideoControl.BackgroundImage = global::RaptorsEyeCSharpFormMetro.Properties.Resources.color;
            this.tableLayoutPanelVideoControl.ColumnCount = 9;
            this.tableLayoutPanelVideoControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelVideoControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelVideoControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelVideoControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelVideoControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanelVideoControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelVideoControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelVideoControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelVideoControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelVideoControl.Controls.Add(this.buttonVideoStop, 2, 0);
            this.tableLayoutPanelVideoControl.Controls.Add(this.buttonVideoFoward, 5, 0);
            this.tableLayoutPanelVideoControl.Controls.Add(this.buttonVideoPrev, 3, 0);
            this.tableLayoutPanelVideoControl.Controls.Add(this.buttonVideoPlay, 4, 0);
            this.tableLayoutPanelVideoControl.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanelVideoControl.Name = "tableLayoutPanelVideoControl";
            this.tableLayoutPanelVideoControl.RowCount = 1;
            this.tableLayoutPanelVideoControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelVideoControl.Size = new System.Drawing.Size(446, 76);
            this.tableLayoutPanelVideoControl.TabIndex = 2;
            // 
            // buttonVideoStop
            // 
            this.buttonVideoStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonVideoStop.BackgroundImage = global::RaptorsEyeCSharpFormMetro.Properties.Resources.color;
            this.buttonVideoStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVideoStop.FlatAppearance.BorderSize = 0;
            this.buttonVideoStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVideoStop.Image = global::RaptorsEyeCSharpFormMetro.Properties.Resources.stop;
            this.buttonVideoStop.Location = new System.Drawing.Point(130, 26);
            this.buttonVideoStop.Margin = new System.Windows.Forms.Padding(0);
            this.buttonVideoStop.Name = "buttonVideoStop";
            this.buttonVideoStop.Size = new System.Drawing.Size(30, 23);
            this.buttonVideoStop.TabIndex = 7;
            this.buttonVideoStop.UseVisualStyleBackColor = true;
            // 
            // buttonVideoFoward
            // 
            this.buttonVideoFoward.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonVideoFoward.BackgroundImage = global::RaptorsEyeCSharpFormMetro.Properties.Resources.color;
            this.buttonVideoFoward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVideoFoward.FlatAppearance.BorderSize = 0;
            this.buttonVideoFoward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVideoFoward.Image = global::RaptorsEyeCSharpFormMetro.Properties.Resources.foward;
            this.buttonVideoFoward.Location = new System.Drawing.Point(255, 26);
            this.buttonVideoFoward.Margin = new System.Windows.Forms.Padding(0);
            this.buttonVideoFoward.Name = "buttonVideoFoward";
            this.buttonVideoFoward.Size = new System.Drawing.Size(30, 23);
            this.buttonVideoFoward.TabIndex = 9;
            this.buttonVideoFoward.UseVisualStyleBackColor = true;
            // 
            // buttonVideoPrev
            // 
            this.buttonVideoPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonVideoPrev.BackgroundImage = global::RaptorsEyeCSharpFormMetro.Properties.Resources.color;
            this.buttonVideoPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVideoPrev.FlatAppearance.BorderSize = 0;
            this.buttonVideoPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVideoPrev.Image = global::RaptorsEyeCSharpFormMetro.Properties.Resources.previous;
            this.buttonVideoPrev.Location = new System.Drawing.Point(160, 26);
            this.buttonVideoPrev.Margin = new System.Windows.Forms.Padding(0);
            this.buttonVideoPrev.Name = "buttonVideoPrev";
            this.buttonVideoPrev.Size = new System.Drawing.Size(30, 23);
            this.buttonVideoPrev.TabIndex = 8;
            this.buttonVideoPrev.UseVisualStyleBackColor = true;
            // 
            // buttonVideoPlay
            // 
            this.buttonVideoPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonVideoPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.buttonVideoPlay.BackgroundImage = global::RaptorsEyeCSharpFormMetro.Properties.Resources.color;
            this.buttonVideoPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonVideoPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVideoPlay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonVideoPlay.FlatAppearance.BorderSize = 0;
            this.buttonVideoPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVideoPlay.Image = global::RaptorsEyeCSharpFormMetro.Properties.Resources.play;
            this.buttonVideoPlay.Location = new System.Drawing.Point(193, 12);
            this.buttonVideoPlay.Name = "buttonVideoPlay";
            this.buttonVideoPlay.Size = new System.Drawing.Size(59, 52);
            this.buttonVideoPlay.TabIndex = 5;
            this.buttonVideoPlay.UseVisualStyleBackColor = false;
            this.buttonVideoPlay.Click += new System.EventHandler(this.buttonVideoPlay_Click);
            // 
            // metroTrackBarVideoSeeker
            // 
            this.metroTrackBarVideoSeeker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTrackBarVideoSeeker.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBarVideoSeeker.BackgroundImage = global::RaptorsEyeCSharpFormMetro.Properties.Resources.color;
            this.metroTrackBarVideoSeeker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTrackBarVideoSeeker.Location = new System.Drawing.Point(3, 3);
            this.metroTrackBarVideoSeeker.MouseWheelBarPartitions = 200;
            this.metroTrackBarVideoSeeker.Name = "metroTrackBarVideoSeeker";
            this.metroTrackBarVideoSeeker.Size = new System.Drawing.Size(446, 9);
            this.metroTrackBarVideoSeeker.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTrackBarVideoSeeker.TabIndex = 3;
            this.metroTrackBarVideoSeeker.UseCustomBackColor = true;
            this.metroTrackBarVideoSeeker.Value = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.BackgroundImage = global::RaptorsEyeCSharpFormMetro.Properties.Resources.color;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolsToolStripMenuItem,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8});
            this.menuStrip.Location = new System.Drawing.Point(0, 5);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(458, 23);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackgroundImage = global::RaptorsEyeCSharpFormMetro.Properties.Resources.color;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openVideoToolStripMenuItemVideo,
            this.openPictureToolStripMenuItem,
            this.openLiveCamToolStripMenuItem});
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(52, 19);
            this.toolStripMenuItem1.Text = "Media";
            // 
            // openVideoToolStripMenuItemVideo
            // 
            this.openVideoToolStripMenuItemVideo.Name = "openVideoToolStripMenuItemVideo";
            this.openVideoToolStripMenuItemVideo.Size = new System.Drawing.Size(161, 22);
            this.openVideoToolStripMenuItemVideo.Text = "Open Video...";
            this.openVideoToolStripMenuItemVideo.Click += new System.EventHandler(this.openVideoToolStripMenuItem_Click);
            // 
            // openPictureToolStripMenuItem
            // 
            this.openPictureToolStripMenuItem.Name = "openPictureToolStripMenuItem";
            this.openPictureToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.openPictureToolStripMenuItem.Text = "Open Picture...";
            this.openPictureToolStripMenuItem.Click += new System.EventHandler(this.openPictureToolStripMenuItem_Click);
            // 
            // openLiveCamToolStripMenuItem
            // 
            this.openLiveCamToolStripMenuItem.Name = "openLiveCamToolStripMenuItem";
            this.openLiveCamToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.openLiveCamToolStripMenuItem.Text = "Open LiveCam...";
            this.openLiveCamToolStripMenuItem.Click += new System.EventHandler(this.openLiveCamToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToTrainingToolStripMenuItem});
            this.toolsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 19);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // goToTrainingToolStripMenuItem
            // 
            this.goToTrainingToolStripMenuItem.Name = "goToTrainingToolStripMenuItem";
            this.goToTrainingToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.goToTrainingToolStripMenuItem.Text = "Go Training...";
            this.goToTrainingToolStripMenuItem.Click += new System.EventHandler(this.goToTrainingToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(44, 19);
            this.toolStripMenuItem7.Text = "View";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutRaptorsEyeToolStripMenuItem});
            this.toolStripMenuItem8.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(44, 19);
            this.toolStripMenuItem8.Text = "Help";
            // 
            // aboutRaptorsEyeToolStripMenuItem
            // 
            this.aboutRaptorsEyeToolStripMenuItem.Name = "aboutRaptorsEyeToolStripMenuItem";
            this.aboutRaptorsEyeToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.aboutRaptorsEyeToolStripMenuItem.Text = "About RaptorsEye...";
            this.aboutRaptorsEyeToolStripMenuItem.Click += new System.EventHandler(this.aboutRaptorsEyeToolStripMenuItem_Click);
            // 
            // mainImageBox
            // 
            this.mainImageBox.BackColor = System.Drawing.Color.Black;
            this.mainImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainImageBox.Location = new System.Drawing.Point(3, 33);
            this.mainImageBox.Margin = new System.Windows.Forms.Padding(3, 5, 0, 3);
            this.mainImageBox.Name = "mainImageBox";
            this.mainImageBox.Size = new System.Drawing.Size(455, 324);
            this.mainImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainImageBox.TabIndex = 2;
            this.mainImageBox.TabStop = false;
            // 
            // tableLayoutPanelVideoRight
            // 
            this.tableLayoutPanelVideoRight.BackgroundImage = global::RaptorsEyeCSharpFormMetro.Properties.Resources.color;
            this.tableLayoutPanelVideoRight.ColumnCount = 1;
            this.tableLayoutPanelVideoRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelVideoRight.Controls.Add(this.tableLayoutPanelVideoSort, 0, 0);
            this.tableLayoutPanelVideoRight.Controls.Add(this.flowLayoutPanelData, 0, 1);
            this.tableLayoutPanelVideoRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelVideoRight.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelVideoRight.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelVideoRight.Name = "tableLayoutPanelVideoRight";
            this.tableLayoutPanelVideoRight.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.tableLayoutPanelVideoRight.RowCount = 2;
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoRight.Size = new System.Drawing.Size(246, 465);
            this.tableLayoutPanelVideoRight.TabIndex = 1;
            // 
            // tableLayoutPanelVideoSort
            // 
            this.tableLayoutPanelVideoSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelVideoSort.BackgroundImage = global::RaptorsEyeCSharpFormMetro.Properties.Resources.color;
            this.tableLayoutPanelVideoSort.ColumnCount = 4;
            this.tableLayoutPanelVideoSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanelVideoSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanelVideoSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanelVideoSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanelVideoSort.Controls.Add(this.buttonRefresh, 2, 0);
            this.tableLayoutPanelVideoSort.Controls.Add(this.labelSort, 0, 0);
            this.tableLayoutPanelVideoSort.Controls.Add(this.metroComboBoxSort, 1, 0);
            this.tableLayoutPanelVideoSort.Location = new System.Drawing.Point(3, 5);
            this.tableLayoutPanelVideoSort.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelVideoSort.Name = "tableLayoutPanelVideoSort";
            this.tableLayoutPanelVideoSort.RowCount = 1;
            this.tableLayoutPanelVideoSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelVideoSort.Size = new System.Drawing.Size(238, 23);
            this.tableLayoutPanelVideoSort.TabIndex = 5;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.buttonRefresh.BackgroundImage = global::RaptorsEyeCSharpFormMetro.Properties.Resources.color;
            this.buttonRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefresh.Enabled = false;
            this.buttonRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Image = global::RaptorsEyeCSharpFormMetro.Properties.Resources.refresh;
            this.buttonRefresh.Location = new System.Drawing.Point(173, 3);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(17, 17);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // labelSort
            // 
            this.labelSort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSort.AutoSize = true;
            this.labelSort.ForeColor = System.Drawing.Color.White;
            this.labelSort.Image = global::RaptorsEyeCSharpFormMetro.Properties.Resources.color;
            this.labelSort.Location = new System.Drawing.Point(3, 5);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(43, 13);
            this.labelSort.TabIndex = 0;
            this.labelSort.Text = "Sort by:";
            // 
            // metroComboBoxSort
            // 
            this.metroComboBoxSort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroComboBoxSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroComboBoxSort.DropDownWidth = 60;
            this.metroComboBoxSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBoxSort.IntegralHeight = false;
            this.metroComboBoxSort.ItemHeight = 23;
            this.metroComboBoxSort.Items.AddRange(new object[] {
            "AGE",
            "ID",
            "SEX"});
            this.metroComboBoxSort.Location = new System.Drawing.Point(54, 0);
            this.metroComboBoxSort.Margin = new System.Windows.Forms.Padding(0);
            this.metroComboBoxSort.Name = "metroComboBoxSort";
            this.metroComboBoxSort.Size = new System.Drawing.Size(116, 29);
            this.metroComboBoxSort.Style = MetroFramework.MetroColorStyle.Black;
            this.metroComboBoxSort.TabIndex = 1;
            this.metroComboBoxSort.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroComboBoxSort.UseSelectable = true;
            // 
            // flowLayoutPanelData
            // 
            this.flowLayoutPanelData.AutoScroll = true;
            this.flowLayoutPanelData.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelData.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelData.Location = new System.Drawing.Point(1, 33);
            this.flowLayoutPanelData.Margin = new System.Windows.Forms.Padding(1, 5, 3, 3);
            this.flowLayoutPanelData.Name = "flowLayoutPanelData";
            this.flowLayoutPanelData.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.flowLayoutPanelData.Size = new System.Drawing.Size(237, 424);
            this.flowLayoutPanelData.TabIndex = 6;
            this.flowLayoutPanelData.WrapContents = false;
            this.flowLayoutPanelData.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.flowLayoutPanelData_ControlRemoved);
            // 
            // AnalyzeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RaptorsEyeCSharpFormMetro.Properties.Resources.color;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackImage = global::RaptorsEyeCSharpFormMetro.Properties.Resources.color;
            this.ClientSize = new System.Drawing.Size(745, 545);
            this.Controls.Add(this.splitContainerVideo);
            this.Controls.Add(this.metroLabelBackgroudProgress);
            this.Controls.Add(this.metroProgressBarMain);
            this.Controls.Add(this.metroProgressSpinnerMainLoad);
            this.Controls.Add(this.pictureBoxRaptorsEyeCrest);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(745, 545);
            this.Name = "AnalyzeForm";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnalyzeForm_FormClosing);
            this.Load += new System.EventHandler(this.AnalyzeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRaptorsEyeCrest)).EndInit();
            this.splitContainerVideo.Panel1.ResumeLayout(false);
            this.splitContainerVideo.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerVideo)).EndInit();
            this.splitContainerVideo.ResumeLayout(false);
            this.tableLayoutPanelVideoLeft.ResumeLayout(false);
            this.tableLayoutPanelVideoLeft.PerformLayout();
            this.tableLayoutPanelVideoControlMain.ResumeLayout(false);
            this.tableLayoutPanelVideoControl.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainImageBox)).EndInit();
            this.tableLayoutPanelVideoRight.ResumeLayout(false);
            this.tableLayoutPanelVideoSort.ResumeLayout(false);
            this.tableLayoutPanelVideoSort.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxRaptorsEyeCrest;
        private System.ComponentModel.BackgroundWorker backgroundWorkerMain;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinnerMainLoad;
        private MetroFramework.Controls.MetroProgressBar metroProgressBarMain;
        private MetroFramework.Controls.MetroLabel metroLabelBackgroudProgress;
        private System.Windows.Forms.SplitContainer splitContainerVideo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelVideoLeft;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelVideoControlMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelVideoControl;
        private System.Windows.Forms.Button buttonVideoStop;
        private System.Windows.Forms.Button buttonVideoPlay;
        private System.Windows.Forms.Button buttonVideoFoward;
        private System.Windows.Forms.Button buttonVideoPrev;
        private MetroFramework.Controls.MetroTrackBar metroTrackBarVideoSeeker;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openVideoToolStripMenuItemVideo;
        private System.Windows.Forms.ToolStripMenuItem openPictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openLiveCamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem aboutRaptorsEyeToolStripMenuItem;
        private Emgu.CV.UI.ImageBox mainImageBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelVideoRight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelVideoSort;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label labelSort;
        private MetroFramework.Controls.MetroComboBox metroComboBoxSort;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanelData;
        private System.Windows.Forms.ToolStripMenuItem goToTrainingToolStripMenuItem;
    }
}

