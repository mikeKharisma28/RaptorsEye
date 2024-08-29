namespace RaptorsEyeCSharpFormMetro
{
    partial class Data
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
            this.dataPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanelFaceRecog = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelFaceRecogData = new System.Windows.Forms.TableLayoutPanel();
            this.labelFaceRecogAgeData = new System.Windows.Forms.Label();
            this.labelFaceRecogSexData = new System.Windows.Forms.Label();
            this.labelFaceRecogIDData = new System.Windows.Forms.Label();
            this.labelFaceRecogID = new System.Windows.Forms.Label();
            this.labelFaceRecogSex = new System.Windows.Forms.Label();
            this.labelFaceRecogAge = new System.Windows.Forms.Label();
            this.metroButtonDeleteData = new MetroFramework.Controls.MetroButton();
            this.pictureBoxFaceRecog = new System.Windows.Forms.PictureBox();
            this.dataPanel.SuspendLayout();
            this.tableLayoutPanelFaceRecog.SuspendLayout();
            this.tableLayoutPanelFaceRecogData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFaceRecog)).BeginInit();
            this.SuspendLayout();
            // 
            // dataPanel
            // 
            this.dataPanel.BackColor = System.Drawing.Color.Black;
            this.dataPanel.Controls.Add(this.tableLayoutPanelFaceRecog);
            this.dataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPanel.Location = new System.Drawing.Point(0, 0);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(252, 100);
            this.dataPanel.TabIndex = 0;
            // 
            // tableLayoutPanelFaceRecog
            // 
            this.tableLayoutPanelFaceRecog.ColumnCount = 2;
            this.tableLayoutPanelFaceRecog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanelFaceRecog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tableLayoutPanelFaceRecog.Controls.Add(this.tableLayoutPanelFaceRecogData, 1, 0);
            this.tableLayoutPanelFaceRecog.Controls.Add(this.pictureBoxFaceRecog, 0, 0);
            this.tableLayoutPanelFaceRecog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFaceRecog.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelFaceRecog.Name = "tableLayoutPanelFaceRecog";
            this.tableLayoutPanelFaceRecog.RowCount = 1;
            this.tableLayoutPanelFaceRecog.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelFaceRecog.Size = new System.Drawing.Size(252, 100);
            this.tableLayoutPanelFaceRecog.TabIndex = 4;
            // 
            // tableLayoutPanelFaceRecogData
            // 
            this.tableLayoutPanelFaceRecogData.ColumnCount = 2;
            this.tableLayoutPanelFaceRecogData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanelFaceRecogData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanelFaceRecogData.Controls.Add(this.labelFaceRecogAgeData, 1, 2);
            this.tableLayoutPanelFaceRecogData.Controls.Add(this.labelFaceRecogSexData, 1, 1);
            this.tableLayoutPanelFaceRecogData.Controls.Add(this.labelFaceRecogIDData, 1, 0);
            this.tableLayoutPanelFaceRecogData.Controls.Add(this.labelFaceRecogID, 0, 0);
            this.tableLayoutPanelFaceRecogData.Controls.Add(this.labelFaceRecogSex, 0, 1);
            this.tableLayoutPanelFaceRecogData.Controls.Add(this.labelFaceRecogAge, 0, 2);
            this.tableLayoutPanelFaceRecogData.Controls.Add(this.metroButtonDeleteData, 1, 3);
            this.tableLayoutPanelFaceRecogData.Location = new System.Drawing.Point(98, 3);
            this.tableLayoutPanelFaceRecogData.Name = "tableLayoutPanelFaceRecogData";
            this.tableLayoutPanelFaceRecogData.RowCount = 4;
            this.tableLayoutPanelFaceRecogData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanelFaceRecogData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanelFaceRecogData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanelFaceRecogData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanelFaceRecogData.Size = new System.Drawing.Size(151, 94);
            this.tableLayoutPanelFaceRecogData.TabIndex = 0;
            // 
            // labelFaceRecogAgeData
            // 
            this.labelFaceRecogAgeData.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFaceRecogAgeData.AutoSize = true;
            this.labelFaceRecogAgeData.ForeColor = System.Drawing.Color.White;
            this.labelFaceRecogAgeData.Location = new System.Drawing.Point(57, 38);
            this.labelFaceRecogAgeData.Name = "labelFaceRecogAgeData";
            this.labelFaceRecogAgeData.Size = new System.Drawing.Size(23, 13);
            this.labelFaceRecogAgeData.TabIndex = 5;
            this.labelFaceRecogAgeData.Text = "null";
            this.labelFaceRecogAgeData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFaceRecogSexData
            // 
            this.labelFaceRecogSexData.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFaceRecogSexData.AutoSize = true;
            this.labelFaceRecogSexData.ForeColor = System.Drawing.Color.White;
            this.labelFaceRecogSexData.Location = new System.Drawing.Point(57, 20);
            this.labelFaceRecogSexData.Name = "labelFaceRecogSexData";
            this.labelFaceRecogSexData.Size = new System.Drawing.Size(23, 13);
            this.labelFaceRecogSexData.TabIndex = 4;
            this.labelFaceRecogSexData.Text = "null";
            this.labelFaceRecogSexData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFaceRecogIDData
            // 
            this.labelFaceRecogIDData.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFaceRecogIDData.AutoSize = true;
            this.labelFaceRecogIDData.ForeColor = System.Drawing.Color.White;
            this.labelFaceRecogIDData.Location = new System.Drawing.Point(57, 2);
            this.labelFaceRecogIDData.Name = "labelFaceRecogIDData";
            this.labelFaceRecogIDData.Size = new System.Drawing.Size(23, 13);
            this.labelFaceRecogIDData.TabIndex = 3;
            this.labelFaceRecogIDData.Text = "null";
            this.labelFaceRecogIDData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFaceRecogID
            // 
            this.labelFaceRecogID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelFaceRecogID.AutoSize = true;
            this.labelFaceRecogID.ForeColor = System.Drawing.Color.White;
            this.labelFaceRecogID.Location = new System.Drawing.Point(27, 2);
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
            this.labelFaceRecogSex.Location = new System.Drawing.Point(17, 20);
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
            this.labelFaceRecogAge.Location = new System.Drawing.Point(16, 38);
            this.labelFaceRecogAge.Name = "labelFaceRecogAge";
            this.labelFaceRecogAge.Size = new System.Drawing.Size(35, 13);
            this.labelFaceRecogAge.TabIndex = 2;
            this.labelFaceRecogAge.Text = "AGE :";
            this.labelFaceRecogAge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroButtonDeleteData
            // 
            this.metroButtonDeleteData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButtonDeleteData.BackColor = System.Drawing.Color.Maroon;
            this.metroButtonDeleteData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroButtonDeleteData.Location = new System.Drawing.Point(73, 68);
            this.metroButtonDeleteData.Name = "metroButtonDeleteData";
            this.metroButtonDeleteData.Size = new System.Drawing.Size(75, 23);
            this.metroButtonDeleteData.TabIndex = 6;
            this.metroButtonDeleteData.Text = "Delete";
            this.metroButtonDeleteData.UseCustomBackColor = true;
            this.metroButtonDeleteData.UseCustomForeColor = true;
            this.metroButtonDeleteData.UseSelectable = true;
            this.metroButtonDeleteData.Visible = false;
            this.metroButtonDeleteData.Click += new System.EventHandler(this.metroButtonDeleteData_Click);
            // 
            // pictureBoxFaceRecog
            // 
            this.pictureBoxFaceRecog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxFaceRecog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxFaceRecog.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxFaceRecog.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxFaceRecog.Name = "pictureBoxFaceRecog";
            this.pictureBoxFaceRecog.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.pictureBoxFaceRecog.Size = new System.Drawing.Size(95, 100);
            this.pictureBoxFaceRecog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFaceRecog.TabIndex = 1;
            this.pictureBoxFaceRecog.TabStop = false;
            this.pictureBoxFaceRecog.Click += new System.EventHandler(this.pictureBoxFaceRecog_Click);
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(252, 100);
            this.Controls.Add(this.dataPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Data";
            this.Text = "Data";
            this.dataPanel.ResumeLayout(false);
            this.tableLayoutPanelFaceRecog.ResumeLayout(false);
            this.tableLayoutPanelFaceRecogData.ResumeLayout(false);
            this.tableLayoutPanelFaceRecogData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFaceRecog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFaceRecog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFaceRecogData;
        public System.Windows.Forms.Label labelFaceRecogAgeData;
        public System.Windows.Forms.Label labelFaceRecogSexData;
        public System.Windows.Forms.Label labelFaceRecogIDData;
        private System.Windows.Forms.Label labelFaceRecogID;
        private System.Windows.Forms.Label labelFaceRecogSex;
        private System.Windows.Forms.Label labelFaceRecogAge;
        public System.Windows.Forms.PictureBox pictureBoxFaceRecog;
        public System.Windows.Forms.Panel dataPanel;
        public MetroFramework.Controls.MetroButton metroButtonDeleteData;
    }
}