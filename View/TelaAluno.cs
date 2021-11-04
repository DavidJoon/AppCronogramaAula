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
    public partial class TelaAluno : Form
    {
        public TelaAluno()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            Aluno.NomeAluno = textBox1.Text;
            Aluno.EmailAluno = textBox2.Text;
            Aluno.FoneAluno = textBox3.Text;

            AlunoController alunoController = new AlunoController();
            alunoController.cadastroAluno();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            if(Aluno.Retorno == "True")
            {
                this.Close();
            }
        }
    }
}
