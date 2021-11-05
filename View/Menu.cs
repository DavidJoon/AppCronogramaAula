using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCronogramaAula.View
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void pesquisarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaBuscaAluno telaAlunos = new TelaBuscaAluno();
            telaAlunos.Show();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaBuscaProf telaProfessores = new TelaBuscaProf();
            telaProfessores.Show();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaAluno addAluno = new TelaAluno();
            addAluno.Show();
        }

        private void adicionarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaProf addProf = new TelaProf();
            addProf.Show();
        }

        private void adicionarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TelaTurma addTurma = new TelaTurma();
            addTurma.Show();
        }

        private void adicionarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            TelaUc addUc = new TelaUc();
            addUc.Show();
        }

        private void adicionarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            TelaSala addSala = new TelaSala();
            addSala.Show();
        }
    }
}
