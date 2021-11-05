using AppCronogramaAula.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCronogramaAula.Controller
{
    class TurmaController
    {
        public void cadastroTurma()
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comando = new SqlCommand("pInserirTurma", conexao);
            comando.CommandType = CommandType.StoredProcedure;
            try
            {

                comando.Parameters.AddWithValue("@turma", Turma.NomeTurma);
                comando.Parameters.AddWithValue("@edataInicio", Turma.DataInicioTurma);
                comando.Parameters.AddWithValue("@dataFim", Turma.DataFimTurma);
                comando.Parameters.AddWithValue("@periodo", Turma.Periodo);

                SqlParameter codigo = comando.Parameters.Add("@codigo", SqlDbType.Int);
                codigo.Direction = ParameterDirection.Output;

                conexao.Open();
                comando.ExecuteNonQuery();

                var resposta = MessageBox.Show("Turma cadastrada com sucesso! \n" +
                    "Deseja cadastrar outra Turma ?",
                    "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    Turma.Retorno = "False";
                    return;
                }
                else
                {
                    Turma.Retorno = "True";
                    return;
                }

            }
            catch
            {
                MessageBox.Show("Turma não cadastrada", "Atenção");
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }


        }
    }
}
