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
                Aluno.Codigo = Convert.ToInt32(textBox1.Text);
                AlunoController aluno = new AlunoController();
                aluno.visuCodigoAluno();
                textBox3.Text = Aluno.NomeAluno;
                textBox4.Text = Aluno.EmailAluno;
                textBox5.Text = Aluno.FoneAluno;
                textBox2.Text = Aluno.Codigo.ToString();
                buttonAlterar.Enabled = true;
                buttonExcAlu.Enabled = true;

            }
            if (Aluno.Retorno == "False")
            {

                limpaTudo();
            }

        }

        private void TelaBuscaAluno_Load(object sender, EventArgs e)
        {
            buttonAlterar.Enabled = false;
            buttonExcAlu.Enabled = false;
        }

        private void buttonExcAlu_Click(object sender, EventArgs e)
        {
            Aluno.Codigo = Convert.ToInt32(textBox2.Text);
            AlunoController alunoController = new AlunoController();
            alunoController.deletarAluno();

            limpaTudo();
            return;
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {


            Aluno.Codigo = Convert.ToInt32(textBox2.Text);

            AlunoController alunoController = new AlunoController();
            alunoController.deletarAluno();

            limpaTudo();

        }
        private void limpaTudo()
        {

            Aluno.Codigo = 0;
            Aluno.NomeAluno = "";
            Aluno.EmailAluno = "";
            Aluno.FoneAluno = "";
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox2.Clear();

            buttonAlterar.Enabled = false;
            buttonExcAlu.Enabled = false;

        }

        private void buttonPesqNomAlu_Click(object sender, EventArgs e)
        {
            if (textBoxPesqNome.Text == "")
            {
                MessageBox.Show("Digite um nome para a busca", "Atenção");
                textBoxPesqNome.Focus();

                return;
            }

            Aluno.NomeAluno = textBoxPesqNome.Text;
            AlunoController aluno = new();
            dataGridView1.DataSource = AlunoController.visuNomeAluno();

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].HeaderCell.Value = "Código";
            //dataGridViewNomeAluno.Columns[5].HeaderCell.Value = "Aluno";
            //dataGridViewNomeAluno.Columns[6].HeaderCell.Value = "Email";
            //dataGridViewNomeAluno.Columns[3].HeaderCell.Value = "Telefone";


            if (dataGridView1.Rows.Count == 1)
            {
                MessageBox.Show("Não existe este Nome", "Atenção");
            }


        }
    }
    }
