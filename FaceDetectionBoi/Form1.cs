using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace FaceDetectionBoi
{
    public partial class Form1 : Form
    {
        Image<Bgr, byte> imgInput;

        VideoCapture capture;

        public Stopwatch Watch { get; set; }
        
        //think u fking retard
        Point turretPosition = new Point(0, 0);

        bool startBlind = false;

        public Form1()
        {
            InitializeComponent();
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {
            //When form loads, starts grabbing frames from default camcorder (0)

            if (capture == null)
            {
                capture = new VideoCapture(0);
            }

            capture.ImageGrabbed += Capture_ImageGrabbed;

            capture.Start();
                        
        }

        public void WriteToPort(Point coordinates)
        {
            try
            {
                if (Watch.ElapsedMilliseconds > 100)
                {
                    port.Write(String.Format("X{0}Y{1}",
                    (180 - (coordinates.X / ((imageBox1.Size.Width) / 180))),
                    (180 - (coordinates.Y / ((imageBox1.Size.Height) / 180)))));

                    turretPosition = coordinates;

                    //turretXY.Text = "X: " + turretPosition.X + " Y: " + turretPosition.Y;
                    turretXY.Text = (String.Format("X: {0} Y: {1}",
                    (coordinates.X / ((imageBox1.Size.Width) / 180)),
                    (180 - (coordinates.Y / ((imageBox1.Size.Height) / 180)))));


                    Watch = Stopwatch.StartNew();

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void Capture_ImageGrabbed(object sender, EventArgs e)
        {
            Mat m = new Mat(); //some kind of retarded type for storing frames I guess

            capture.Retrieve(m);

            imgInput = m.ToImage<Bgr, byte>(); //convert to image
            

            DetectHaarFace(); //down there u idiot

            imageBox1.Image = imgInput; //set image as current edited frame

        }

        private void DetectHaarFace()
        {

            try
            {
                //gets paths to haash files
                string facePath = Path.GetFullPath(@"../../../datalol/haarcascade_frontalface_default.xml");
                //string eyePath = Path.GetFullPath(@"../../../datalol/haarcascade_eye.xml");
                //sets classifiers for face and eye detection
                CascadeClassifier classifierFace = new CascadeClassifier(facePath);
                //CascadeClassifier classifierEye = new CascadeClassifier(eyePath);


                var imgGray = imgInput.Convert<Gray, byte>().Clone();
                Rectangle[] faces = classifierFace.DetectMultiScale(imgGray, 1.1, 6);

                Rectangle shit = new Rectangle();

                shit.X = (imageBox1.Width / 2);
                shit.Y = (imageBox1.Height / 2);

                shit.Width = 1;
                shit.Height = 1;

                imgInput.Draw(shit, new Bgr(255, 0, 0), 2);

                foreach (var face in faces)
                {
                    
                    imgInput.Draw(face, new Bgr(0, 0, 255), 2);

                    faceXY.Text = "X: " + (face.X + face.Width/2) + " Y: " + (face.Y + face.Height / 2);

                    var e = face;

                    e.X = (face.X + face.Width / 2);
                    e.Y = (face.Y + face.Height / 2);

                    e.Height = 1;
                    e.Width = 1;
                                        

                    imgInput.Draw(e, new Bgr(0, 0, 255), 2);

                    if (startBlind)
                    {
                        WriteToPort(new Point(e.X, e.Y)); 
                    }

                    /* imgGray.ROI = face;
                     Rectangle[] eyes = classifierEye.DetectMultiScale(imgGray, 1.1, 6);
                     foreach (var eye in eyes)
                     {
                         var e = eye;

                         e.X = (face.X + face.Width / 2);


                         e.Y = (face.Y + face.Height / 2);

                         e.Height = 1;
                         e.Width = 1;

                         faceXY.Text = "X: " + e.X + " Y: " + e.Y;

                        // WriteToPort(new Point(e.X, e.Y));
                          imgInput.Draw(e, new Bgr(0, 255, 0), 2);
                     }*/
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                port.Open();
                Watch = Stopwatch.StartNew();
                startBlind = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                Watch.Stop();
                startBlind = false;
                port.Write(String.Format("X90Y90"));
                port.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
//something something
//current coordinate - last coordinate = diff < 25 nejudinti
//kaip paimti lastPoint??????

//vidurinis veido taskas plotis/2 ilgis/2