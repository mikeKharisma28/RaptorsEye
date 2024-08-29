using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MetroFramework.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Cuda;
using Emgu.CV.Util;
using Emgu.CV.Cvb;

namespace RaptorsEyeCSharpFormMetro
{
    enum TypeOfMedia
    {
        Picture,
        Video,
        LiveCam
    };

    public partial class AnalyzeForm : MetroForm
    {
        public static AnalyzeForm _AppMainForm;
        public static bool openTrainForm;
        
        private Capture _videoCap;
        private CascadeClassifier _classifier;
        private bool _captureInProgress;

        private Mat _shownImage; //used in the imagebox
        private Mat _tempImage; //used for storage, just in case the user refresh the frame
        private Mat _rawFrame; //used for processing the frame in live cam mode

        private Bitmap crop_result;
        private long faceCounter = 1;
        private int inCounter = 0;
        private TypeOfMedia typeOfMedia;

        private readonly string _databasePath = Application.StartupPath + "/face_store.sqlite";
        private readonly string _trainerDataPath = Application.StartupPath + "/traineddata";
        private readonly string _cascadeDataPath = Application.StartupPath + "/haarcascade_frontalface_alt_tree.xml";

        private SQLiteConnection _dbConnection;

        private bool _userClosing { get; set; }

        #region Constructors
        /// <summary>
        /// Constructor for Analyze Form
        /// </summary>
        public AnalyzeForm()
        {
            InitializeComponent();
            CvInvoke.UseOpenCL = false;
            CvInvoke.UseOptimized = true;

            crop_result = null;
            _AppMainForm = this;
            typeOfMedia = TypeOfMedia.Video;
            _classifier = new CascadeClassifier(_cascadeDataPath);

            openTrainForm = false;
            _userClosing = false;
        }
        #endregion

        #region Custom Procedures and Functions
        private void ProcessFrame(object sender, EventArgs arg)
        {
            if (typeOfMedia == TypeOfMedia.LiveCam)
            {
                Mat currentFrame = new Mat();
                _videoCap.Retrieve(currentFrame, 0);
                _rawFrame = currentFrame.Clone();

                Mat grayFrame = new Mat();

                _videoCap.Retrieve(currentFrame, 0);
                CvInvoke.CvtColor(currentFrame, grayFrame, ColorConversion.Bgr2Gray);

                Image<Bgr, Byte> output;
                //if a face(s) is/are found, then stop face detection
                Rectangle[] faces = _classifier.DetectMultiScale(grayFrame, 1.6, 3);
                if (faces != null)
                {
                    foreach (var face in faces)
                    {
                        CvInvoke.Rectangle(currentFrame, face, new MCvScalar(0, 255, 0));
                    }
                }
                mainImageBox.Image = currentFrame;
            }

            if (typeOfMedia == TypeOfMedia.Video)
            {
                Mat currentFrame = new Mat();
                Mat grayFrame = new Mat();

                _videoCap.Retrieve(currentFrame, 0);
                CvInvoke.CvtColor(currentFrame, grayFrame, ColorConversion.Bgr2Gray);

                Image<Bgr, Byte> output;
                //if a face(s) is/are found, then stop face detection
                Rectangle[] faces = _classifier.DetectMultiScale(grayFrame, 1.5, 3);
                if (faces != null)
                {
                    foreach (var face in faces)
                    {
                        CvInvoke.Rectangle(currentFrame, face, new MCvScalar(0, 255, 0));
                    }
                }
                mainImageBox.Image = currentFrame;
            }
        }

        private void ReleaseData()
        {
            if (_videoCap != null)
            {
                _videoCap.Dispose();
                _videoCap = null;
            }
        }

        private void AddDataControls(Data data, int indexCounter, long faceCounter)
        {
            data.TopLevel = false;
            data.Location = new Point(5, 5);
            data.FormBorderStyle = FormBorderStyle.None;
            data.Visible = true;
            data.pictureBoxFaceRecog.Image = crop_result;
            data.labelFaceRecogIDData.Text = faceCounter.ToString("00000");
            data.labelFaceRecogSexData.Text = "-";
            data.labelFaceRecogAgeData.Text = "-";
            data.INDEX = indexCounter;
            flowLayoutPanelData.Controls.Add(data);
        }

        private void LoadDatabase()
        {
            if (File.Exists(_databasePath))
            {
                _dbConnection = new SQLiteConnection(String.Format("Data Source = {0}; Version = 3;", _databasePath));
            }
            else
            {
                SQLiteConnection.CreateFile(_databasePath);
                _dbConnection = new SQLiteConnection(String.Format("Data Source = {0}; Version = 3;", _databasePath));
            }
        }

        private Mat DoFaceDetection(Mat inputImage)
        {
            Mat resultImage = new Mat();
            Mat grayImage = new Mat();
            Image<Bgr, Byte> output;

            resultImage = inputImage.Clone();
            CvInvoke.CvtColor(resultImage, grayImage, ColorConversion.Bgr2Gray);
            Rectangle[] faces = _classifier.DetectMultiScale(grayImage, 1.475, 4);

            foreach (var face in faces)
            {
                output = resultImage.ToImage<Bgr, Byte>();
                crop_result = output.ToBitmap().Clone(face, output.ToBitmap().PixelFormat);
                //crop_result.Save("face" + faceCounter.ToString() + ".png");
                CvInvoke.Rectangle(resultImage, face, new MCvScalar(0, 255, 0), 2);
                Data newData = new Data();
                AddDataControls(newData, inCounter, faceCounter);
                inCounter++;
                faceCounter++;
            }

            return resultImage;
        }
        #endregion

        #region Events
        private void AnalyzeForm_Load(object sender, EventArgs e)
        {
            //LoadDatabase();
        }

        private void AnalyzeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch(e.CloseReason)
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

        private void openVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            faceCounter = 1; //reset id index
            inCounter = 0; //reset array index

            if (_videoCap != null)
            {
                if (MessageBox.Show("You're about to stop the video capture. Continue?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    ReleaseData();
                }
                else
                    return;
            }
            OpenFileDialog vidFileDialog = new OpenFileDialog();
            vidFileDialog.Title = "Select video file...";
            vidFileDialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
            vidFileDialog.DefaultExt = ".mp4";
            vidFileDialog.Filter = "Media Files|*.mpg; *.avi; *.wma; *.mov; *.mp4; *.mkv|All Files|*.*";
            
            if (vidFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _videoCap = new Capture(vidFileDialog.FileName);
                    _videoCap.ImageGrabbed += ProcessFrame;
                    Bitmap pause = new Bitmap(Properties.Resources.pause);
                    buttonVideoPlay.Image = pause;
                    _videoCap.Start();
                    tableLayoutPanelVideoControlMain.Visible = true;
                    metroTrackBarVideoSeeker.Visible = true;
                    buttonVideoStop.Visible = true;
                    buttonVideoPrev.Visible = true;
                    buttonVideoFoward.Visible = true;
                    _captureInProgress = !_captureInProgress;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                Bitmap play = new Bitmap(Properties.Resources.play);
                buttonVideoPlay.Image = play;
            }
            
            typeOfMedia = TypeOfMedia.Video;
            buttonRefresh.Enabled = true;
            if (flowLayoutPanelData.Controls != null)
            {
                flowLayoutPanelData.Controls.Clear();
            }
        }

        private void openPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            faceCounter = 1; //reset id index
            inCounter = 0; //reset array index
            if (_videoCap != null)
            {
                if (MessageBox.Show("You're about to stop the video capture. Continue?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    ReleaseData();
                }
                else
                    return;
            }

            OpenFileDialog picFileDialog = new OpenFileDialog();
            picFileDialog.Title = "Select image file...";
            picFileDialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            picFileDialog.DefaultExt = ".jpeg";
            picFileDialog.Filter = "JPEG files| *.jpg; *.jpeg; *.jpe|Windows bitmaps| *.bmp; *.dib|" +
                                   "Portable Network Graphics| *.png|Portable image format| *.pbm; *.pgm; *.ppm|" +
                                   "Sun rasters| *.sr; *.ras|TIFF files| *.tiff; *.tif|" +
                                   "OpenEXR HDR images| *.exr|JPEG 2000 images| *.jp2|" +
                                   "All files|*.*";

            if (picFileDialog.ShowDialog() == DialogResult.OK)
            {
                tableLayoutPanelVideoControlMain.Visible = false;
                
            }
            else
                return;
            buttonRefresh.Enabled = true;

            //clear data when new input added
            if (flowLayoutPanelData.Controls != null)
            {
                flowLayoutPanelData.Controls.Clear();
            }

            _shownImage = CvInvoke.Imread(picFileDialog.FileName, LoadImageType.AnyColor);
            _tempImage = _shownImage.Clone();

            if (!backgroundWorkerMain.IsBusy)
            {
                // This method will start the execution asynchronously in the background
                metroLabelBackgroudProgress.Text = "Loading...";
                backgroundWorkerMain.RunWorkerAsync(e);
            }
            
            mainImageBox.Image = DoFaceDetection(_shownImage);
            typeOfMedia = TypeOfMedia.Picture;
        }

        private void openLiveCamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            faceCounter = 1; //reset id index
            inCounter = 0; //reset array index

            if (_videoCap != null)
            {
                if (MessageBox.Show("You're about to stop the video capture. Continue?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    ReleaseData();
                }
                else
                    return;
            }

            _videoCap = new Capture();
            _videoCap.ImageGrabbed += ProcessFrame;
            Bitmap capture = new Bitmap(Properties.Resources.Add_Face2);
            buttonVideoPlay.Image = capture;
            _videoCap.Start();
            tableLayoutPanelVideoControlMain.Visible = true;
            metroTrackBarVideoSeeker.Visible = false;
            buttonVideoStop.Visible = false;
            buttonVideoPrev.Visible = false;
            buttonVideoFoward.Visible = false;
            _captureInProgress = !_captureInProgress;
            buttonRefresh.Enabled = true;
            typeOfMedia = TypeOfMedia.LiveCam;
            if (flowLayoutPanelData.Controls != null)
            {
                flowLayoutPanelData.Controls.Clear();
            }
        }

        private void buttonVideoPlay_Click(object sender, EventArgs e)
        {
            if (typeOfMedia == TypeOfMedia.Video)
            {
                if (_videoCap == null)
                {
                    openVideoToolStripMenuItem_Click(sender, e);
                }

                if (_videoCap != null)
                {
                    if (_captureInProgress)
                    {
                        Bitmap play = new Bitmap(Properties.Resources.play);
                        buttonVideoPlay.Image = play;
                        _videoCap.Pause();
                    }
                    else
                    {
                        Bitmap pause = new Bitmap(Properties.Resources.pause);
                        buttonVideoPlay.Image = pause;
                        _videoCap.Start();
                    }

                    _captureInProgress = !_captureInProgress;
                }
            }

            if (typeOfMedia == TypeOfMedia.LiveCam)
            {
                if (_videoCap == null)
                {
                    openLiveCamToolStripMenuItem_Click(sender, e);
                }

                if (_videoCap != null)
                {
                    mainImageBox.Image = DoFaceDetection(_rawFrame);
                }
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            faceCounter = 1; //reset id index
            inCounter = 0; //reset array index

            flowLayoutPanelData.Controls.Clear();

            if (!backgroundWorkerMain.IsBusy)
            {
                // This method will start the execution asynchronously in the background
                metroLabelBackgroudProgress.Text = "Refreshing...";
                backgroundWorkerMain.RunWorkerAsync(e);
            }

            if (typeOfMedia == TypeOfMedia.Picture)
            {
                _shownImage = _tempImage.Clone();

                //==========================Do face tracking=================================
                mainImageBox.Image = DoFaceDetection(_shownImage);
                //===========================================================================
            }
            if (typeOfMedia == TypeOfMedia.Video)
            {
                //do face tracking
            }
            if (typeOfMedia == TypeOfMedia.LiveCam)
            {
                //do face tracking
            }
        }

        private void aboutRaptorsEyeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void flowLayoutPanelData_ControlRemoved(object sender, ControlEventArgs e)
        {
            int i = 0;
            foreach (Data target in flowLayoutPanelData.Controls)
            {
                target.INDEX = i;
                i++;
            }
        }
        
        private void backgroundWorkerMain_DoWork(object sender, DoWorkEventArgs e)
        {
            int sum = 0;

            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(3);
                sum = sum + i;
                // Calling ReportProgress() method raises ProgressChanged event
                // To this method pass the percentage of processing that is complete
                backgroundWorkerMain.ReportProgress(i);

                // Check if the cancellation is requested
                if (backgroundWorkerMain.CancellationPending)
                {
                    // Set Cancel property of DoWorkEventArgs object to true
                    e.Cancel = true;
                    // Reset progress percentage to ZERO and return
                    backgroundWorkerMain.ReportProgress(0);
                    return;
                }
            }

            // Store the result in Result property of DoWorkEventArgs object
            e.Result = sum;

        }

        private void backgroundWorkerMain_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            metroProgressBarMain.Value = e.ProgressPercentage;
            metroProgressSpinnerMainLoad.Value = 0;
            metroProgressSpinnerMainLoad.Visible = true;
            metroProgressSpinnerMainLoad.Spinning = true;
            metroLabelBackgroudProgress.Visible = true;
        }

        private void backgroundWorkerMain_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Thread.Sleep(13);
            metroProgressBarMain.Value = 0;
            metroLabelBackgroudProgress.Visible = false;
            metroProgressSpinnerMainLoad.Spinning = false;
            metroProgressSpinnerMainLoad.Visible = false;

            if (e.Cancelled)
            {

            }
            if (e.Error != null)
            {

            }
        }

        private void goToTrainingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openTrainForm = true;
            _userClosing = true;
            this.Close();
        }

        #endregion
    } //end of AppMainForm class
} //end of namespace RaptorsEyeCSharpFormMetro
