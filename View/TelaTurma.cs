using AppCronogramaAula.Controller;
using AppCronogramaAula.Model;
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
    public partial class TelaTurma : Form
    {
        public TelaTurma()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            Turma.NomeTurma = textBox1.Text;
            Turma.DataInicioTurma = dateTimePicker1.MinDate;
            Turma.DataFimTurma = dateTimePicker2.MaxDate;
            Turma.Periodo = textBox4.Text;

            TurmaController turmaController = new TurmaController();
            turmaController.cadastroTurma();

            textBox1.Clear();

            textBox4.Clear();

            if (Turma.Retorno == "True")
            {
                this.Close();
            }
        }
    }
}
