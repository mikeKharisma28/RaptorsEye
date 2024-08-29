using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaptorsEyeCSharpFormMetro
{
    static class Program
    {
        public static bool applicationExit = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AnalyzeForm());

            while (!applicationExit)
            {
                if (AnalyzeForm.openTrainForm)
                    Application.Run(new TrainingForm());

                if (TrainingForm.openAnalyzeForm)
                    Application.Run(new AnalyzeForm());
            }
        }
    }
}
