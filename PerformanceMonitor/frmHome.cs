using System;
using System.Windows.Forms;
using System.Speech.Recognition;



namespace PerformanceMonitor
{
    public partial class frmHome : Form
    {
        private SpeechRecognitionEngine engine;
        public frmHome()
        {
            InitializeComponent();
            engine = new SpeechRecognitionEngine();

            Choices c = new Choices();

            c.Add("Timer Roshan");
            c.Add("Stop Roshan");
            c.Add("Timer Aegis");
            c.Add("Stop Aegis");
            c.Add("Timer Juggernaut");
            c.Add("Stop Juggernaut");
            c.Add("Timer Lina");
            c.Add("Stop Lina");





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
                    Console.WriteLine("Ue");
                    break;

                default:
                    break;
            }
        }
    }
}
