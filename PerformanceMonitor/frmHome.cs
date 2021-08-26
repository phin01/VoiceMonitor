using System;
using System.Windows.Forms;
using System.Speech.Recognition;
using Hardcodet.Wpf.TaskbarNotification;
using PerformanceMonitor.Properties;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Net;

namespace PerformanceMonitor
{
    public partial class frmHome : Form
    {
        private SpeechRecognitionEngine engine;
        public frmHome()
        {

            // TaskbarIcon tbi = new TaskbarIcon();
            // tbi.Icon = Resources.;
            // tbi.ToolTipText = "hello world";

            InitializeComponent();

            PingServer("http://www.uol.com.br");
            PingServer("http://www.uol.com.dgfdgfbr");




            engine = new SpeechRecognitionEngine();

            Choices c = new Choices();

            c.Add("virtual machine");
            c.Add("power B I");
            c.Add("power apps");


            GrammarBuilder gb = new GrammarBuilder(c);
            gb.Culture = engine.RecognizerInfo.Culture;
            Grammar g = new Grammar(gb);
            
            engine.LoadGrammar(g);


            engine.SpeechRecognized += rec;

            engine.SetInputToDefaultAudioDevice();
            engine.RecognizeAsync(RecognizeMode.Multiple);

        }

        private void rec(object sender, SpeechRecognizedEventArgs e)
        {
            if(e.Result.Confidence > 0.85)
                lblSpeech.Text = string.Format("{0} - Conf: {1}", e.Result.Text, e.Result.Confidence);






            switch (e.Result.Text)
            {
                case "Timer Roshan":
                    Console.WriteLine("Timer Roshan Ativado");
                    break;

                default:
                    break;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
            this.ShowInTaskbar = true;
        }

        private void frmHome_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                this.Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void PingServer(string url)
        {
            //Ping ping = new Ping();
            //ping. 
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.AllowAutoRedirect = false;
            request.Method = System.Net.WebRequestMethods.Http.Head;

            try
            {
                WebResponse response = request.GetResponse();
                Console.WriteLine("{0} is online", url);
            }
            catch (Exception)
            {
                Console.WriteLine("{0} is offline", url);
            }
            
        }
    }


}
