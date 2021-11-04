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
    public partial class TelaBuscaProf : Form
    {
        public TelaBuscaProf()
        {
            InitializeComponent();
        }

        private void buttonPesqNomPro_Click(object sender, EventArgs e)
        {
            if (textBoxPesqNome.Text == "")
            {
                MessageBox.Show("Digite um nome para a busca", "Atenção");
                textBoxPesqNome.Focus();

                return;
            }

            Professor.NomeProf = textBoxPesqNome.Text;
            ProfessorController professor = new();
            dataGridView1.DataSource = ProfessorController.visuNomeProfessor();

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

        private void TelaBuscaProf_Load(object sender, EventArgs e)
        {
            buttonAlterar.Enabled = true;
            buttonExcPro.Enabled = true;
        }

        private void buttonExcPro_Click(object sender, EventArgs e)
        {
            Professor.Codigo = Convert.ToInt32(textBox2.Text);
            ProfessorController professorController = new ProfessorController();
            professorController.deletarProfessor();

            limpaTudo();
            return;
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            Professor.Codigo = Convert.ToInt32(textBox2.Text);

            ProfessorController professorController = new ProfessorController();
            professorController.deletarProfessor();

            limpaTudo();
        }
        private void limpaTudo()
        {

            Professor.Codigo = 0;
            Professor.NomeProf = "";
            Professor.EmailProf = "";
            Professor.FoneProf = "";
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox2.Clear();

            buttonAlterar.Enabled = false;
            buttonExcPro.Enabled = false;

        }

        private void buttonPesqCodPro_Click(object sender, EventArgs e)
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
                Professor.Codigo = Convert.ToInt32(textBox1.Text);
                ProfessorController professor = new ProfessorController();
                professor.visuCodigoProfessor();
                textBox3.Text = Professor.NomeProf;
                textBox4.Text = Professor.EmailProf;
                textBox5.Text = Professor.FoneProf;
                textBox2.Text = Professor.Codigo.ToString();
                buttonAlterar.Enabled = true;
                buttonExcPro.Enabled = true;

            }
            if (Professor.Retorno == "False")
            {

                limpaTudo();
            }
        }
    }
}
