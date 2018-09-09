using Projeto.Entity;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Projeto.Dao
{
    public class ClienteDAO : IRepositorio<Cliente>
    {
        private ConexaoBD objConexao;
        private SqlCommand sqlComando;

        public ClienteDAO()
        {
            objConexao = ConexaoBD.EstadoConexao();
        }

        public void Atualizar(Cliente objCliente)
        {
            throw new System.NotImplementedException();
        }

        public void Criar(Cliente objCliente)
        {
            throw new System.NotImplementedException();
        }

        public void Deletar(Cliente objCliente)
        {
            throw new System.NotImplementedException();
        }

        public bool Existe(Cliente objCliente)
        {
            throw new System.NotImplementedException();
        }

        public List<Cliente> ListarTodos()
        {
            throw new System.NotImplementedException();
        }
    }
}
