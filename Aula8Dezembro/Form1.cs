using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula8Dezembro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botao1_Click(object sender, EventArgs e)
        {
            menssagemFinal.Text = "O nome digitado foi: " + armazenamentoDeTexto.Text;

        }
         
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menssagem1_Click(object sender, EventArgs e)
        {

        }

        private void menssagem2_Click(object sender, EventArgs e)
        {

        }
    }
}
