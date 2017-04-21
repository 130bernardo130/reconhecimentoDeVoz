using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reconhecimentoDeVoz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool botao = false;

        private void mudaTexto(System.Windows.Forms.Button button,String texto)
        {
            Controls.Remove(button);
            button.Text = texto;
            Controls.Add(button);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            botao = !botao;
           

            if (botao)
            {
                mudaTexto(Ouvir, "Parar");
            }
            else
            {
                mudaTexto(Ouvir, "Ouvir");
            }
        }
    }
}
