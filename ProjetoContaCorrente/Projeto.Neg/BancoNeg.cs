using Projeto.EF;
using Projeto.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Neg
{
    public class BancoNeg
    {
        BancoEF objBancoEF;

        public BancoNeg()
        {
            objBancoEF = new BancoEF();
        }

        public List<Banco> ListarTodos()
        {
            return objBancoEF.ListarTodos();
        }
    }
}
