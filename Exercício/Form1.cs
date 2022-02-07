using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercício
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            int anoAtual = Convert.ToInt32(txt_anoAtual.Text);
            int anoNascimento = Convert.ToInt32(txt_anoNascimento.Text);
            int idade;

            idade = anoAtual - anoNascimento;

            txt_idade.Text = idade.ToString();
        }
    }
}
