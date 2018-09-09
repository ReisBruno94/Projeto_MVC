using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Dao
{
    public interface IRepositorio<objClasse>
    {
        void Criar(objClasse objClasse);

        void Deletar(objClasse objClasse);

        void Atualizar(objClasse objClasse);

        bool Existe(objClasse objClasse);

        List<objClasse> ListarTodos();
    }
}
