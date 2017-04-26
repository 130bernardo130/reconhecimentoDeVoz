using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;
using System.Windows.Forms;

namespace reconhecimentoDeVoz {


    public class Voz {
        private System.Windows.Forms.TextBox texto;
        SpeechRecognitionEngine rec;
        public string ultimoComando { get; set; }


        public void configura() {
            try {
                this.rec = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("pt-BR"));
            } catch (Exception) {
                try {
                    this.rec = new SpeechRecognitionEngine();
                } catch (Exception) {
                    MessageBox.Show("falhou ao fazer definição da engine de reconhecimento de voz");
                }

                MessageBox.Show("falha na definição de cultura");
            }

            Choices comandos = new Choices();
            String[] strComandos = new String[] { "Voltar", "pesquisar", "buscar", "avançar", "facebook", "google", "twitter", "instagram", "whatsapp", "favoritos", "apagar histórico", "youtube" };
            comandos.Add(strComandos);
            GrammarBuilder gCria = new GrammarBuilder();
            gCria.Append(comandos);
            Grammar gramatica = new Grammar(gCria);
            rec.LoadGrammarAsync(gramatica);

            rec.SetInputToDefaultAudioDevice();
            rec.SpeechRecognized += Rec_SpeechRecognized;
        }

        public Voz() {
            configura();
        }

        public Voz(System.Windows.Forms.TextBox texto) {
            this.texto = texto;
            configura();
        }


        private void Rec_SpeechRecognized(Object bj, SpeechRecognizedEventArgs e) {
            this.texto.Text = e.Result.Text;
            ultimoComando = e.Result.Text;

            switch (e.Result.Text) {
                case "pesquisar":
                case "buscar":
                    Console.WriteLine("Navegador busca");
                    break;
                case "voltar":
                    Console.WriteLine("Navegador está voltando para a página anterior");
                    break;
                case "avançar":
                    Console.WriteLine("Navegador está indo para a próxima página");
                    break;
                case "facebook":
                    Console.WriteLine("Navegador abre o facebook em uma nova aba");
                    break;
                case "google":
                    Console.WriteLine("Navegador abre o google em uma nova aba");
                    break;
                case "twitter":
                    Console.WriteLine("Navegador abre o twitter em uma nova aba");
                    break;
                case "instagram":
                    Console.WriteLine("Navegador abre o instagram em uma nova aba");
                    break;
                case "whatsapp":
                    Console.WriteLine("Navegador abre o facebook em uma nova aba");
                    break;
                case "favoritos":
                    Console.WriteLine("Navegador abre os favoritos novas aba");
                    break;
                case "apagar histórico":
                    Console.WriteLine("Navegador apaga o histórico");
                    break;
                case "youtube":
                    Console.WriteLine("Navegador abre o youtube em uma nova aba");
                    break;
            }


        }

        public void ouvir() {
            rec.RecognizeAsync(RecognizeMode.Multiple);
        }
        public void parar() {
            rec.RecognizeAsyncStop();
        }
    }

}
