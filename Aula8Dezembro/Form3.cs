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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void BotaoEnviar_Click(object sender, EventArgs e)
        {
            labelMenssagem.Text = "As informações digitadas foram: \n\r" +
                "Nome: " + InputNome.Text + "\n\r" +
                "Idade: " + InputIdade.Text + "\n\r" +
                "Email: " + InputEmail.Text;



        }
    }
}
