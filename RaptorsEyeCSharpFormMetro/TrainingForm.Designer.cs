namespace RaptorsEyeCSharpFormMetro
{
    partial class TrainingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainingForm));
            this.pictureBoxRaptorsEyeCrest = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelMainTrain = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelDataTrain = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanelTrainExec = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelTrainLeft = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelVideoControlMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelTrainVideoControl = new System.Windows.Forms.TableLayoutPanel();
            this.buttonVideoStop = new System.Windows.Forms.Button();
            this.buttonVideoPlay = new System.Windows.Forms.Button();
            this.buttonVideoFoward = new System.Windows.Forms.Button();
            this.buttonVideoPrev = new System.Windows.Forms.Button();
            this.metroTrackBarVideoSeeker = new MetroFramework.Controls.MetroTrackBar();
            this.menuStripDetect = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openVideoToolStripMenuItemVideo = new System.Windows.Forms.ToolStripMenuItem();
            this.openPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLiveCamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goAnalyzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usingGPUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutRaptorsEyeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TrainImageBox = new Emgu.CV.UI.ImageBox();
            this.panelTrainData = new System.Windows.Forms.Panel();
            this.tableLayoutPanelTrainRight = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelDataButton = new System.Windows.Forms.TableLayoutPanel();
            this.metroButtonSaveData = new MetroFramework.Controls.MetroButton();
            this.metroButtonDeleteData = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanelDataData = new System.Windows.Forms.TableLayoutPanel();
            this.labelTrainDataID = new System.Windows.Forms.Label();
            this.labelFaceRecogID = new System.Windows.Forms.Label();
            this.labelFaceRecogSex = new System.Windows.Forms.Label();
            this.labelFaceRecogAge = new System.Windows.Forms.Label();
            this.metroComboBoxTrainSex = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBoxTrainAge = new MetroFramework.Controls.MetroComboBox();
            this.imageBoxTrainDataPreview = new Emgu.CV.UI.ImageBox();
            this.metroProgressBarMainTraining = new MetroFramework.Controls.MetroProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRaptorsEyeCrest)).BeginInit();
            this.tableLayoutPanelMainTrain.SuspendLayout();
            this.tableLayoutPanelTrainExec.SuspendLayout();
            this.tableLayoutPanelTrainLeft.SuspendLayout();
            this.tableLayoutPanelVideoControlMain.SuspendLayout();
            this.tableLayoutPanelTrainVideoControl.SuspendLayout();
            this.menuStripDetect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrainImageBox)).BeginInit();
            this.panelTrainData.SuspendLayout();
            this.tableLayoutPanelTrainRight.SuspendLayout();
            this.tableLayoutPanelDataButton.SuspendLayout();
            this.tableLayoutPanelDataData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxTrainDataPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxRaptorsEyeCrest
            // 
            this.pictureBoxRaptorsEyeCrest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxRaptorsEyeCrest.BackgroundImage")));
            this.pictureBoxRaptorsEyeCrest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxRaptorsEyeCrest.Location = new System.Drawing.Point(7, 8);
            this.pictureBoxRaptorsEyeCrest.Name = "pictureBoxRaptorsEyeCrest";
            this.pictureBoxRaptorsEyeCrest.Size = new System.Drawing.Size(156, 37);
            this.pictureBoxRaptorsEyeCrest.TabIndex = 2;
            this.pictureBoxRaptorsEyeCrest.TabStop = false;
            // 
            // tableLayoutPanelMainTrain
            // 
            this.tableLayoutPanelMainTrain.ColumnCount = 1;
            this.tableLayoutPanelMainTrain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMainTrain.Controls.Add(this.flowLayoutPanelDataTrain, 0, 1);
            this.tableLayoutPanelMainTrain.Controls.Add(this.tableLayoutPanelTrainExec, 0, 0);
            this.tableLayoutPanelMainTrain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMainTrain.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanelMainTrain.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelMainTrain.Name = "tableLayoutPanelMainTrain";
            this.tableLayoutPanelMainTrain.RowCount = 2;
            this.tableLayoutPanelMainTrain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMainTrain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanelMainTrain.Size = new System.Drawing.Size(705, 465);
            this.tableLayoutPanelMainTrain.TabIndex = 3;
            // 
            // flowLayoutPanelDataTrain
            // 
            this.flowLayoutPanelDataTrain.AutoScroll = true;
            this.flowLayoutPanelDataTrain.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanelDataTrain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelDataTrain.Location = new System.Drawing.Point(0, 339);
            this.flowLayoutPanelDataTrain.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelDataTrain.Name = "flowLayoutPanelDataTrain";
            this.flowLayoutPanelDataTrain.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.flowLayoutPanelDataTrain.Size = new System.Drawing.Size(705, 126);
            this.flowLayoutPanelDataTrain.TabIndex = 7;
            this.flowLayoutPanelDataTrain.WrapContents = false;
            // 
            // tableLayoutPanelTrainExec
            // 
            this.tableLayoutPanelTrainExec.ColumnCount = 2;
            this.tableLayoutPanelTrainExec.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTrainExec.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelTrainExec.Controls.Add(this.tableLayoutPanelTrainLeft, 0, 0);
            this.tableLayoutPanelTrainExec.Controls.Add(this.panelTrainData, 1, 0);
            this.tableLayoutPanelTrainExec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTrainExec.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTrainExec.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelTrainExec.Name = "tableLayoutPanelTrainExec";
            this.tableLayoutPanelTrainExec.RowCount = 1;
            this.tableLayoutPanelTrainExec.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTrainExec.Size = new System.Drawing.Size(705, 339);
            this.tableLayoutPanelTrainExec.TabIndex = 8;
            // 
            // tableLayoutPanelTrainLeft
            // 
            this.tableLayoutPanelTrainLeft.BackgroundImage = global::RaptorsEyeCSharpFormMetro.Properties.Resources.color;
            this.tableLayoutPanelTrainLeft.ColumnCount = 1;
            this.tableLayoutPanelTrainLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTrainLeft.Controls.Add(this.tableLayoutPanelVideoControlMain, 0, 2);
            this.tableLayoutPanelTrainLeft.Controls.Add(this.menuStripDetect, 0, 0);
            this.tableLayoutPanelTrainLeft.Controls.Add(this.TrainImageBox, 0, 1);
            this.tableLayoutPanelTrainLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTrainLeft.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTrainLeft.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelTrainLeft.Name = "tableLayoutPanelTrainLeft";
            this.tableLayoutPanelTrainLeft.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.tableLayoutPanelTrainLeft.RowCount = 3;
            this.tableLayoutPanelTrainLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanelTrainLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTrainLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelTrainLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelTrainLeft.Size = new System.Drawing.Size(505, 339);
            this.tableLayoutPanelTrainLeft.TabIndex = 1;
            // 
            // tableLayoutPanelVideoControlMain
            // 
            this.tableLayoutPanelVideoControlMain.BackgroundImage = global::RaptorsEyeCSharpFormMetro.Properties.Resources.color;
            this.tableLayoutPanelVideoControlMain.ColumnCount = 1;
            this.tableLayoutPanelVideoControlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelVideoControlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVideoControlMain.Controls.Add(this.tableLayoutPanelTrainVideoControl, 0, 1);
            this.tableLayoutPanelVideoControlMain.Controls.Add(this.metroTrackBarVideoSeeker, 0, 0);
            this.tableLayoutPanelVideoControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelVideoControlMain.Location = new System.Drawing.Point(3, 237);
            this.tableLayoutPanelVideoControlMain.Name = "tableLayoutPanelVideoControlMain";
            this.tableLayoutPanelVideoControlMain.RowCount = 2;
            this.tableLayoutPanelVideoControlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanelVideoControlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelVideoControlMain.Size = new System.Drawing.Size(499, 94);
            this.tableLayoutPanelVideoControlMain.TabIndex = 6;
            // 
            // tableLayoutPanelTrainVideoControl
            // 
            this.tableLayoutPanelTrainVideoControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelTrainVideoControl.BackgroundImage = global::RaptorsEyeCSharpFormMetro.Properties.Resources.color;
            this.tableLayoutPanelTrainVideoControl.ColumnCount = 9;
            this.tableLayoutPanelTrainVideoControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTrainVideoControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelTrainVideoControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelTrainVideoControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelTrainVideoControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanelTrainVideoControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelTrainVideoControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelTrainVideoControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelTrainVideoControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTrainVideoControl.Controls.Add(this.buttonVideoStop, 2, 0);
            this.tableLayoutPanelTrainVideoControl.Controls.Add(this.buttonVideoPlay, 4, 0);
            this.tableLayoutPanelTrainVideoControl.Controls.Add(this.buttonVideoFoward, 5, 0);
            this.tableLayoutPanelTrainVideoControl.Controls.Add(this.buttonVideoPrev, 3, 0);
            this.tableLayoutPanelTrainVideoControl.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanelTrainVideoControl.Name = "tableLayoutPanelTrainVideoControl";
            this.tableLayoutPanelTrainVideoControl.RowCount = 1;
            this.tableLayoutPanelTrainVideoControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTrainVideoControl.Size = new System.Drawing.Size(493, 76);
            this.tableLayoutPanelTrainVideoControl.TabIndex = 2;
            // 
            // buttonVideoStop
            // 
            this.buttonVideoStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonVideoStop.BackgroundImage = global::RaptorsEyeCSharpFormMetro.Properties.Resources.color;
            this.buttonVideoStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVideoStop.FlatAppearance.BorderSize = 0;
            this.buttonVideoStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVideoStop.Image = global::RaptorsEyeCSharpFormMetro.Properties.Resources.stop;
            this.buttonVideoStop.Location = new System.Drawing.Point(154, 26);
            this.buttonVideoStop.Margin = new System.Windows.Forms.Padding(0);
            this.buttonVideoStop.Name = "buttonVideoStop";
            this.buttonVideoStop.Size = new System.Drawing.Size(30, 23);
            this.buttonVideoStop.TabIndex = 7;
            this.buttonVideoStop.UseVisualStyleBackColor = true;
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
            this.buttonVideoPlay.Location = new System.Drawing.Point(217, 12);
            this.buttonVideoPlay.Name = "buttonVideoPlay";
            this.buttonVideoPlay.Size = new System.Drawing.Size(59, 52);
            this.buttonVideoPlay.TabIndex = 5;
            this.buttonVideoPlay.UseVisualStyleBackColor = false;
            // 
            // buttonVideoFoward
            // 
            this.buttonVideoFoward.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonVideoFoward.BackgroundImage = global::RaptorsEyeCSharpFormMetro.Properties.Resources.color;
            this.buttonVideoFoward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVideoFoward.FlatAppearance.BorderSize = 0;
            this.buttonVideoFoward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVideoFoward.Image = global::RaptorsEyeCSharpFormMetro.Properties.Resources.foward;
            this.buttonVideoFoward.Location = new System.Drawing.Point(279, 26);
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
            this.buttonVideoPrev.Location = new System.Drawing.Point(184, 26);
            this.buttonVideoPrev.Margin = new System.Windows.Forms.Padding(0);
            this.buttonVideoPrev.Name = "buttonVideoPrev";
            this.buttonVideoPrev.Size = new System.Drawing.Size(30, 23);
            this.buttonVideoPrev.TabIndex = 8;
            this.buttonVideoPrev.UseVisualStyleBackColor = true;
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
            this.metroTrackBarVideoSeeker.Size = new System.Drawing.Size(493, 9);
            this.metroTrackBarVideoSeeker.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTrackBarVideoSeeker.TabIndex = 3;
            this.metroTrackBarVideoSeeker.UseCustomBackColor = true;
            this.metroTrackBarVideoSeeker.Value = 0;
            // 
            // menuStripDetect
            // 
            this.menuStripDetect.BackgroundImage = global::RaptorsEyeCSharpFormMetro.Properties.Resources.color;
            this.menuStripDetect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStripDetect.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolsToolStripMenuItem,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8});
            this.menuStripDetect.Location = new System.Drawing.Point(0, 5);
            this.menuStripDetect.Name = "menuStripDetect";
            this.menuStripDetect.Size = new System.Drawing.Size(505, 23);
            this.menuStripDetect.TabIndex = 2;
            this.menuStripDetect.Text = "menuStrip2";
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
            // 
            // openPictureToolStripMenuItem
            // 
            this.openPictureToolStripMenuItem.Name = "openPictureToolStripMenuItem";
            this.openPictureToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.openPictureToolStripMenuItem.Text = "Open Picture...";
            // 
            // openLiveCamToolStripMenuItem
            // 
            this.openLiveCamToolStripMenuItem.Name = "openLiveCamToolStripMenuItem";
            this.openLiveCamToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.openLiveCamToolStripMenuItem.Text = "Open LiveCam...";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goAnalyzeToolStripMenuItem,
            this.usingGPUToolStripMenuItem});
            this.toolsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 19);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // goAnalyzeToolStripMenuItem
            // 
            this.goAnalyzeToolStripMenuItem.Name = "goAnalyzeToolStripMenuItem";
            this.goAnalyzeToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.goAnalyzeToolStripMenuItem.Text = "Go Analyze...";
            this.goAnalyzeToolStripMenuItem.Click += new System.EventHandler(this.goAnalyzeToolStripMenuItem_Click);
            // 
            // usingGPUToolStripMenuItem
            // 
            this.usingGPUToolStripMenuItem.CheckOnClick = true;
            this.usingGPUToolStripMenuItem.Name = "usingGPUToolStripMenuItem";
            this.usingGPUToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.usingGPUToolStripMenuItem.Text = "Using GPU";
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
            // 
            // TrainImageBox
            // 
            this.TrainImageBox.BackColor = System.Drawing.Color.Black;
            this.TrainImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrainImageBox.Location = new System.Drawing.Point(3, 33);
            this.TrainImageBox.Margin = new System.Windows.Forms.Padding(3, 5, 0, 3);
            this.TrainImageBox.Name = "TrainImageBox";
            this.TrainImageBox.Size = new System.Drawing.Size(502, 198);
            this.TrainImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TrainImageBox.TabIndex = 2;
            this.TrainImageBox.TabStop = false;
            // 
            // panelTrainData
            // 
            this.panelTrainData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelTrainData.BackgroundImage = global::RaptorsEyeCSharpFormMetro.Properties.Resources.color;
            this.panelTrainData.Controls.Add(this.tableLayoutPanelTrainRight);
            this.panelTrainData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTrainData.Location = new System.Drawing.Point(505, 0);
            this.panelTrainData.Margin = new System.Windows.Forms.Padding(0);
            this.panelTrainData.Name = "panelTrainData";
            this.panelTrainData.Size = new System.Drawing.Size(200, 339);
            this.panelTrainData.TabIndex = 2;
            // 
            // tableLayoutPanelTrainRight
            // 
            this.tableLayoutPanelTrainRight.ColumnCount = 1;
            this.tableLayoutPanelTrainRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTrainRight.Controls.Add(this.tableLayoutPanelDataButton, 0, 3);
            this.tableLayoutPanelTrainRight.Controls.Add(this.tableLayoutPanelDataData, 0, 2);
            this.tableLayoutPanelTrainRight.Controls.Add(this.imageBoxTrainDataPreview, 0, 1);
            this.tableLayoutPanelTrainRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTrainRight.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTrainRight.Name = "tableLayoutPanelTrainRight";
            this.tableLayoutPanelTrainRight.RowCount = 4;
            this.tableLayoutPanelTrainRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanelTrainRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanelTrainRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTrainRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanelTrainRight.Size = new System.Drawing.Size(200, 339);
            this.tableLayoutPanelTrainRight.TabIndex = 0;
            // 
            // tableLayoutPanelDataButton
            // 
            this.tableLayoutPanelDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelDataButton.ColumnCount = 2;
            this.tableLayoutPanelDataButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDataButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDataButton.Controls.Add(this.metroButtonSaveData, 0, 0);
            this.tableLayoutPanelDataButton.Controls.Add(this.metroButtonDeleteData, 1, 0);
            this.tableLayoutPanelDataButton.Location = new System.Drawing.Point(3, 308);
            this.tableLayoutPanelDataButton.Name = "tableLayoutPanelDataButton";
            this.tableLayoutPanelDataButton.RowCount = 1;
            this.tableLayoutPanelDataButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelDataButton.Size = new System.Drawing.Size(194, 28);
            this.tableLayoutPanelDataButton.TabIndex = 4;
            // 
            // metroButtonSaveData
            // 
            this.metroButtonSaveData.BackColor = System.Drawing.Color.Transparent;
            this.metroButtonSaveData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroButtonSaveData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroButtonSaveData.Location = new System.Drawing.Point(3, 3);
            this.metroButtonSaveData.Name = "metroButtonSaveData";
            this.metroButtonSaveData.Size = new System.Drawing.Size(91, 24);
            this.metroButtonSaveData.TabIndex = 9;
            this.metroButtonSaveData.Text = "Save";
            this.metroButtonSaveData.UseCustomBackColor = true;
            this.metroButtonSaveData.UseCustomForeColor = true;
            this.metroButtonSaveData.UseSelectable = true;
            this.metroButtonSaveData.Visible = false;
            // 
            // metroButtonDeleteData
            // 
            this.metroButtonDeleteData.BackColor = System.Drawing.Color.Transparent;
            this.metroButtonDeleteData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroButtonDeleteData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroButtonDeleteData.Location = new System.Drawing.Point(100, 3);
            this.metroButtonDeleteData.Name = "metroButtonDeleteData";
            this.metroButtonDeleteData.Size = new System.Drawing.Size(91, 24);
            this.metroButtonDeleteData.TabIndex = 8;
            this.metroButtonDeleteData.Text = "Delete";
            this.metroButtonDeleteData.UseCustomBackColor = true;
            this.metroButtonDeleteData.UseCustomForeColor = true;
            this.metroButtonDeleteData.UseSelectable = true;
            this.metroButtonDeleteData.Visible = false;
            // 
            // tableLayoutPanelDataData
            // 
            this.tableLayoutPanelDataData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelDataData.ColumnCount = 2;
            this.tableLayoutPanelDataData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanelDataData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanelDataData.Controls.Add(this.labelTrainDataID, 1, 0);
            this.tableLayoutPanelDataData.Controls.Add(this.labelFaceRecogID, 0, 0);
            this.tableLayoutPanelDataData.Controls.Add(this.labelFaceRecogSex, 0, 1);
            this.tableLayoutPanelDataData.Controls.Add(this.labelFaceRecogAge, 0, 2);
            this.tableLayoutPanelDataData.Controls.Add(this.metroComboBoxTrainSex, 1, 1);
            this.tableLayoutPanelDataData.Controls.Add(this.metroComboBoxTrainAge, 1, 2);
            this.tableLayoutPanelDataData.Location = new System.Drawing.Point(3, 181);
            this.tableLayoutPanelDataData.Name = "tableLayoutPanelDataData";
            this.tableLayoutPanelDataData.RowCount = 3;
            this.tableLayoutPanelDataData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelDataData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelDataData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelDataData.Size = new System.Drawing.Size(194, 94);
            this.tableLayoutPanelDataData.TabIndex = 3;
            // 
            // labelTrainDataID
            // 
            this.labelTrainDataID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTrainDataID.AutoSize = true;
            this.labelTrainDataID.ForeColor = System.Drawing.Color.White;
            this.labelTrainDataID.Location = new System.Drawing.Point(57, 8);
            this.labelTrainDataID.Name = "labelTrainDataID";
            this.labelTrainDataID.Size = new System.Drawing.Size(23, 13);
            this.labelTrainDataID.TabIndex = 6;
            this.labelTrainDataID.Text = "null";
            this.labelTrainDataID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFaceRecogID
            // 
            this.labelFaceRecogID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelFaceRecogID.AutoSize = true;
            this.labelFaceRecogID.ForeColor = System.Drawing.Color.White;
            this.labelFaceRecogID.Location = new System.Drawing.Point(27, 8);
            this.labelFaceRecogID.Name = "labelFaceRecogID";
            this.labelFaceRecogID.Size = new System.Drawing.Size(24, 13);
            this.labelFaceRecogID.TabIndex = 0;
            this.labelFaceRecogID.Text = "ID :";
            this.labelFaceRecogID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFaceRecogSex
            // 
            this.labelFaceRecogSex.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelFaceRecogSex.AutoSize = true;
            this.labelFaceRecogSex.ForeColor = System.Drawing.Color.White;
            this.labelFaceRecogSex.Location = new System.Drawing.Point(17, 38);
            this.labelFaceRecogSex.Name = "labelFaceRecogSex";
            this.labelFaceRecogSex.Size = new System.Drawing.Size(34, 13);
            this.labelFaceRecogSex.TabIndex = 1;
            this.labelFaceRecogSex.Text = "SEX :";
            this.labelFaceRecogSex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFaceRecogAge
            // 
            this.labelFaceRecogAge.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelFaceRecogAge.AutoSize = true;
            this.labelFaceRecogAge.ForeColor = System.Drawing.Color.White;
            this.labelFaceRecogAge.Location = new System.Drawing.Point(16, 70);
            this.labelFaceRecogAge.Name = "labelFaceRecogAge";
            this.labelFaceRecogAge.Size = new System.Drawing.Size(35, 13);
            this.labelFaceRecogAge.TabIndex = 2;
            this.labelFaceRecogAge.Text = "AGE :";
            this.labelFaceRecogAge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroComboBoxTrainSex
            // 
            this.metroComboBoxTrainSex.FormattingEnabled = true;
            this.metroComboBoxTrainSex.ItemHeight = 23;
            this.metroComboBoxTrainSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.metroComboBoxTrainSex.Location = new System.Drawing.Point(57, 33);
            this.metroComboBoxTrainSex.Name = "metroComboBoxTrainSex";
            this.metroComboBoxTrainSex.Size = new System.Drawing.Size(121, 29);
            this.metroComboBoxTrainSex.TabIndex = 4;
            this.metroComboBoxTrainSex.UseSelectable = true;
            // 
            // metroComboBoxTrainAge
            // 
            this.metroComboBoxTrainAge.FormattingEnabled = true;
            this.metroComboBoxTrainAge.ItemHeight = 23;
            this.metroComboBoxTrainAge.Items.AddRange(new object[] {
            "Child",
            "Preadolescence",
            "Adolescence",
            "Adult",
            "Middle age",
            "Old age"});
            this.metroComboBoxTrainAge.Location = new System.Drawing.Point(57, 63);
            this.metroComboBoxTrainAge.Name = "metroComboBoxTrainAge";
            this.metroComboBoxTrainAge.Size = new System.Drawing.Size(121, 29);
            this.metroComboBoxTrainAge.TabIndex = 5;
            this.metroComboBoxTrainAge.UseSelectable = true;
            // 
            // imageBoxTrainDataPreview
            // 
            this.imageBoxTrainDataPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.imageBoxTrainDataPreview.BackColor = System.Drawing.Color.Black;
            this.imageBoxTrainDataPreview.Location = new System.Drawing.Point(36, 23);
            this.imageBoxTrainDataPreview.Margin = new System.Windows.Forms.Padding(0);
            this.imageBoxTrainDataPreview.Name = "imageBoxTrainDataPreview";
            this.imageBoxTrainDataPreview.Size = new System.Drawing.Size(128, 128);
            this.imageBoxTrainDataPreview.TabIndex = 2;
            this.imageBoxTrainDataPreview.TabStop = false;
            // 
            // metroProgressBarMainTraining
            // 
            this.metroProgressBarMainTraining.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroProgressBarMainTraining.Location = new System.Drawing.Point(0, 0);
            this.metroProgressBarMainTraining.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.metroProgressBarMainTraining.Name = "metroProgressBarMainTraining";
            this.metroProgressBarMainTraining.Size = new System.Drawing.Size(745, 5);
            this.metroProgressBarMainTraining.Style = MetroFramework.MetroColorStyle.Red;
            this.metroProgressBarMainTraining.TabIndex = 5;
            this.metroProgressBarMainTraining.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroProgressBarMainTraining.UseCustomBackColor = true;
            // 
            // TrainingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 545);
            this.Controls.Add(this.metroProgressBarMainTraining);
            this.Controls.Add(this.tableLayoutPanelMainTrain);
            this.Controls.Add(this.pictureBoxRaptorsEyeCrest);
            this.MinimumSize = new System.Drawing.Size(745, 545);
            this.Name = "TrainingForm";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrainingForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRaptorsEyeCrest)).EndInit();
            this.tableLayoutPanelMainTrain.ResumeLayout(false);
            this.tableLayoutPanelTrainExec.ResumeLayout(false);
            this.tableLayoutPanelTrainLeft.ResumeLayout(false);
            this.tableLayoutPanelTrainLeft.PerformLayout();
            this.tableLayoutPanelVideoControlMain.ResumeLayout(false);
            this.tableLayoutPanelTrainVideoControl.ResumeLayout(false);
            this.menuStripDetect.ResumeLayout(false);
            this.menuStripDetect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrainImageBox)).EndInit();
            this.panelTrainData.ResumeLayout(false);
            this.tableLayoutPanelTrainRight.ResumeLayout(false);
            this.tableLayoutPanelDataButton.ResumeLayout(false);
            this.tableLayoutPanelDataData.ResumeLayout(false);
            this.tableLayoutPanelDataData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxTrainDataPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxRaptorsEyeCrest;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMainTrain;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDataTrain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTrainExec;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTrainLeft;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelVideoControlMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTrainVideoControl;
        private System.Windows.Forms.Button buttonVideoStop;
        private System.Windows.Forms.Button buttonVideoPlay;
        private System.Windows.Forms.Button buttonVideoFoward;
        private System.Windows.Forms.Button buttonVideoPrev;
        private MetroFramework.Controls.MetroTrackBar metroTrackBarVideoSeeker;
        private System.Windows.Forms.MenuStrip menuStripDetect;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openVideoToolStripMenuItemVideo;
        private System.Windows.Forms.ToolStripMenuItem openPictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openLiveCamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usingGPUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem aboutRaptorsEyeToolStripMenuItem;
        private Emgu.CV.UI.ImageBox TrainImageBox;
        private System.Windows.Forms.Panel panelTrainData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTrainRight;
        private Emgu.CV.UI.ImageBox imageBoxTrainDataPreview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDataButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDataData;
        private System.Windows.Forms.Label labelFaceRecogSex;
        private System.Windows.Forms.Label labelFaceRecogAge;
        public MetroFramework.Controls.MetroButton metroButtonSaveData;
        public MetroFramework.Controls.MetroButton metroButtonDeleteData;
        private MetroFramework.Controls.MetroComboBox metroComboBoxTrainSex;
        private MetroFramework.Controls.MetroComboBox metroComboBoxTrainAge;
        public System.Windows.Forms.Label labelTrainDataID;
        private System.Windows.Forms.Label labelFaceRecogID;
        private System.Windows.Forms.ToolStripMenuItem goAnalyzeToolStripMenuItem;
        private MetroFramework.Controls.MetroProgressBar metroProgressBarMainTraining;
    }
}