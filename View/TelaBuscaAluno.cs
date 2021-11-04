using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCronogramaAula.Model;
using AppCronogramaAula.Controller;

namespace AppCronogramaAula.View
{
    public partial class TelaBuscaAluno : Form
    {
        public TelaBuscaAluno()
        {
            InitializeComponent();
        }

        private void buttonPesqCodAlu_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Digite um código para busca", "Atenção");
                textBox1.Focus();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                return;
            }
            else
            {
                AlunoController aluno = new AlunoController();
                aluno.visuCodigoAluno();
                buttonAltAlu.Enabled = true;
                buttonExcAlu.Enabled = true;

            }
     
        }

        private void TelaBuscaAluno_Load(object sender, EventArgs e)
        {
            buttonAltAlu.Enabled = false;
            buttonExcAlu.Enabled = false;
        }

        private void buttonExcAlu_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Focus();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                return;
            }
        }
    }
}
