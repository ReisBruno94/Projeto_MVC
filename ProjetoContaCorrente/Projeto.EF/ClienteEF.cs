using Projeto.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.EF
{
    public class ClienteEF : IRepositorio<Cliente>
    {

        private readonly ConexaoBD conexaoBD;

        public ClienteEF()
        {
            conexaoBD = new ConexaoBD();
        }

        public void Atualizar(Cliente objClasse)
        {
            Cliente objCliente = new Cliente();

            objCliente = conexaoBD.cliente.First<Cliente>(x => x.ClienteID == objClasse.ClienteID);
            objCliente.Nome = objClasse.Nome;
            objCliente.CPF = objClasse.CPF;
            objCliente.Telefone = objClasse.Telefone;
            objCliente.Email = objClasse.Email;

            conexaoBD.SaveChanges();
                
        }

        public void Criar(Cliente objClasse)
        {
            conexaoBD.cliente.Add(objClasse);
            conexaoBD.SaveChanges();
        }

        public void Deletar(int ClienteID)
        {
            var Cliente = conexaoBD.cliente.First(x => x.ClienteID == ClienteID);
            conexaoBD.Set<Cliente>().Remove(Cliente);
            conexaoBD.SaveChanges();
        }

        public bool Existe(Cliente objClasse)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> ListarTodos()
        {
            return conexaoBD.cliente.ToList();
        }

        public Cliente PesquisarClientePorID(int? ClienteID)
        {
            return conexaoBD.cliente.First(x => x.ClienteID == ClienteID);
        }

        public bool PesquisaPorCPF(Cliente cliente)
        {
            
            List<Cliente> lstCliente = new List<Cliente>();
            lstCliente = conexaoBD.cliente.Where<Cliente>(x => x.CPF == cliente.CPF).ToList<Cliente>();
            if (lstCliente.Count > 0)
            {
                return true;
            }
            else { return false; }
            
        }

        public Cliente PesquisarContaID(int? ContaID)
        {
            throw new NotImplementedException();
        }
    }
}
