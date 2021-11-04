using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCronogramaAula.Controller
{
    class Conexao
    {
        public static string conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pichau\source\repos\AppCronogramaAula\AppCronogramaAula\bdcronograma.mdf;Integrated Security=True";
        }
    }
}
