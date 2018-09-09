using Projeto.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.EF
{
    public interface IRepositorio<objClasse>
    {
        void Criar(objClasse objClasse);

        void Deletar(int ClinteID);

        void Atualizar(objClasse objClasse);

        bool Existe(objClasse objClasse);

        List<objClasse> ListarTodos();

        objClasse PesquisarClientePorID(int? ClienteID);

        objClasse PesquisarContaID(int? ContaID);

        bool PesquisaPorCPF(objClasse objClasse);
    }
}
