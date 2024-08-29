namespace RaptorsEyeCSharpFormMetro
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.metroPanelAbout = new MetroFramework.Controls.MetroPanel();
            this.metroLabelAbout = new MetroFramework.Controls.MetroLabel();
            this.metroPanelAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanelAbout
            // 
            this.metroPanelAbout.AutoScroll = true;
            this.metroPanelAbout.Controls.Add(this.metroLabelAbout);
            this.metroPanelAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanelAbout.HorizontalScrollbar = true;
            this.metroPanelAbout.HorizontalScrollbarBarColor = true;
            this.metroPanelAbout.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelAbout.HorizontalScrollbarSize = 10;
            this.metroPanelAbout.Location = new System.Drawing.Point(20, 60);
            this.metroPanelAbout.Name = "metroPanelAbout";
            this.metroPanelAbout.Size = new System.Drawing.Size(268, 239);
            this.metroPanelAbout.Style = MetroFramework.MetroColorStyle.Black;
            this.metroPanelAbout.TabIndex = 0;
            this.metroPanelAbout.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanelAbout.VerticalScrollbar = true;
            this.metroPanelAbout.VerticalScrollbarBarColor = true;
            this.metroPanelAbout.VerticalScrollbarHighlightOnWheel = true;
            this.metroPanelAbout.VerticalScrollbarSize = 10;
            // 
            // metroLabelAbout
            // 
            this.metroLabelAbout.AutoSize = true;
            this.metroLabelAbout.Location = new System.Drawing.Point(0, 0);
            this.metroLabelAbout.Name = "metroLabelAbout";
            this.metroLabelAbout.Size = new System.Drawing.Size(235, 304);
            this.metroLabelAbout.TabIndex = 2;
            this.metroLabelAbout.Text = resources.GetString("metroLabelAbout.Text");
            this.metroLabelAbout.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 319);
            this.Controls.Add(this.metroPanelAbout);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "About RaptorsEye";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanelAbout.ResumeLayout(false);
            this.metroPanelAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanelAbout;
        private MetroFramework.Controls.MetroLabel metroLabelAbout;
    }
}