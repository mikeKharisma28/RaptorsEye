using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaptorsEyeCSharpFormMetro
{
    public partial class Data : Form
    {
        public static Data _DataForm;

        public int INDEX;
        public Data()
        {
            InitializeComponent();
            _DataForm = this;
        }

        FlowLayoutPanel Querry = AnalyzeForm._AppMainForm.flowLayoutPanelData;
        bool isShown = false;
        private void pictureBoxFaceRecog_Click(object sender, EventArgs e)
        {
            if (!isShown)
            {
                metroButtonDeleteData.Visible = true;
                dataPanel.BackColor = Color.FromArgb(20,20,20);
                isShown = true;
            }
            else
            {
                metroButtonDeleteData.Visible = false;
                dataPanel.BackColor = Color.FromArgb(0,0,0);
                isShown = false;
            }
            
        }

        private void metroButtonDeleteData_Click(object sender, EventArgs e)
        {
            Querry.Controls.RemoveAt(INDEX);
        }
    }


}
