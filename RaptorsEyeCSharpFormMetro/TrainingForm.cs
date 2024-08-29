using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using System.Windows.Forms;

namespace RaptorsEyeCSharpFormMetro
{
    public partial class TrainingForm : MetroForm
    {
        public static bool openAnalyzeForm;

        private bool _userClosing { get; set; }

        #region Constructors
        /// <summary>
        /// Constructor for Training Form
        /// </summary>
        public TrainingForm()
        {
            InitializeComponent();
            openAnalyzeForm = false;
            _userClosing = false;
        }
        #endregion

        #region Events

        private void goAnalyzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openAnalyzeForm = true;
            _userClosing = true;
            this.Close();
        }

        private void TrainingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    if (!_userClosing)
                        Program.applicationExit = true;

                    break;
                default:
                    break;
            }

            _userClosing = false;
        }
        #endregion

        #region Custom Procedures and Functions

        #endregion
    }
}
