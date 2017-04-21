using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;

namespace reconhecimentoDeVoz
{
   
    
    public class Voz
    {
        private System.Windows.Forms.TextBox texto;
        SpeechRecognitionEngine rec = new SpeechRecognitionEngine();
        public Voz(System.Windows.Forms.TextBox texto)
        {
            this.texto = texto;
            rec.SetInputToDefaultAudioDevice();

            rec.SpeechRecognized += Rec_SpeechRecognized;
        }

        private void Rec_SpeechRecognized(Object bj, SpeechRecognizedEventArgs e)
        {
            this.texto.Text = e.Result.Text;            
        }

        public void ouvir()
        {
            rec.RecognizeAsync();
        }
        public void parar()
        {
            rec.RecognizeAsyncStop();
        }
    }

}
