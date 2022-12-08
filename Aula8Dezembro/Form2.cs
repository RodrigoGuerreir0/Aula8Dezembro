using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula8Dezembro
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            Tela.AppendText("\r\n" + "Precionei a tecla: " + e.KeyCode);
            Tela.AppendText("\r\n" + "\t" + "Codigo da tecla: " + ((int)e.KeyCode));
            

        }

        private void botaoLimpar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
