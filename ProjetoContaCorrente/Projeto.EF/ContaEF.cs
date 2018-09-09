using Projeto.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.EF
{
    public class ContaEF : IRepositorio<Conta>
    {
        private readonly ConexaoBD ConexaoBD;

        public ContaEF()
        {
            ConexaoBD = new ConexaoBD();
        }

        public void Atualizar(Conta objClasse)
        {
            throw new NotImplementedException();
        }

        public void Criar(Conta objClasse)
        {
            ConexaoBD.conta.Add(objClasse);
            ConexaoBD.SaveChanges();
        }

        public void Deletar(int ContaID)
        {
            var Conta = ConexaoBD.conta.First(x => x.ContaID == ContaID);
            ConexaoBD.Set<Conta>().Remove(Conta);
            ConexaoBD.SaveChanges();
        }

        public bool Existe(Conta objClasse)
        {
            throw new NotImplementedException();
        }

        public List<Conta> ListarTodos()
        {
            return ConexaoBD.conta.ToList(); 
        }

        public bool PesquisaPorCPF(Conta objClasse)
        {
            throw new NotImplementedException();
        }

        public Conta PesquisarClientePorID(int? ClienteID)
        {
            throw new NotImplementedException();
        }

        public Conta PesquisarContaID(int? ContaID)
        {
            return ConexaoBD.conta.First(x => x.ContaID == ContaID);
        }
    }
}
