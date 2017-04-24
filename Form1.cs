using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reconhecimentoDeVoz {
    public partial class Form1 : Form {
        Voz voz;
        public Form1() {
            InitializeComponent();
            voz = new Voz(this.texto);
        }
        bool botao = false;

        private void mudaTexto(System.Windows.Forms.Button button, String texto) {

            button.Text = texto;
          
            this.Refresh();
        }
        private void button1_Click(object sender, EventArgs e) {
            botao = !botao;

            
            if (botao) {
                mudaTexto(Ouvir, "Parar");
                voz.ouvir();
         
            } else {
                mudaTexto(Ouvir, "Ouvir");
                voz.parar();
            }
        }

        private void texto_TextChanged(object sender, EventArgs e) {

        }
    }
}
