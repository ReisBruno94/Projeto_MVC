using Projeto.EF;
using Projeto.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Neg
{
    public class ContaNeg
    {
        private ContaEF objContaDao;

        public ContaNeg()
        {
            objContaDao = new ContaEF();
        }

        public void Criar(Conta objConta)
        {
            Boolean bValidacao;



            objContaDao.Criar(objConta);
            return;
        }

        public List<Conta> PesquisarTodos()
        {
            return objContaDao.ListarTodos();
        }

        public void Excluir(int id)
        {
            objContaDao.Deletar(id);
            return;
        }

        public Conta PesquisarContaID(int? ContaID)
        {
            return objContaDao.PesquisarContaID(ContaID);
        }
    }
}
