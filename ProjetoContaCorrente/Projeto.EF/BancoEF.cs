using Projeto.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.EF
{
    public class BancoEF : IRepositorio<Banco>
    {

        ConexaoBD ObjConexaoBD;

        public BancoEF()
        {
            ObjConexaoBD = new ConexaoBD();
        }


        public void Atualizar(Banco objClasse)
        {
            throw new NotImplementedException();
        }

        public void Criar(Banco objClasse)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int ClinteID)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Banco objClasse)
        {
            throw new NotImplementedException();
        }

        public List<Banco> ListarTodos()
        {
            return ObjConexaoBD.banco.ToList<Banco>();
        }

        public bool PesquisaPorCPF(Banco objClasse)
        {
            throw new NotImplementedException();
        }

        public Banco PesquisarClientePorID(int? ClienteID)
        {
            throw new NotImplementedException();
        }

        public Banco PesquisarContaID(int? ContaID)
        {
            throw new NotImplementedException();
        }
    }
}
