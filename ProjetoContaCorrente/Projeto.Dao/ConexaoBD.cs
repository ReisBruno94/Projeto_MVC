using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Dao
{
    class ConexaoBD
    {
        private static ConexaoBD objConexao = null;

        private SqlConnection con;

        private ConexaoBD() {
            con = new SqlConnection("Data Source = DESKTOP-JMK95JK\\SQLEXPRESS; Initial Catalog=dbContaCorrente; Integrate Security = True");
        }

        public static ConexaoBD EstadoConexao()
        {
            if (objConexao == null)
            {
                objConexao = new ConexaoBD();
            }

            return objConexao;
        }
        public SqlConnection getCon()
        {
            return con;
        }

        public void CloseBD()
        {
            objConexao = null;
        }

    }
}
