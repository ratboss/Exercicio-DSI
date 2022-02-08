using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int anoNascimento = Convert.ToInt32(txt_ano_nascimento.Text);
            int anoAtual = Convert.ToInt32(txt_ano_atual.Text);

            int idade;

            idade = anoAtual - anoNascimento;

            txt_idade.Text = idade.ToString();



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
