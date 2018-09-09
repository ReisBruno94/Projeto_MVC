using Projeto.EF;
using Projeto.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Neg
{
    public class ClienteNeg
    {
        private ClienteEF objClienteDao;

        public ClienteNeg()
        {
            objClienteDao = new ClienteEF();
        }

        public void Criar(Cliente objCliente)
        {
            bool verificacao = true;

            string Nome = objCliente.Nome;
            if (Nome == null)
            {
                objCliente.Estado = 20;
                return;
            }
            else
            {
                Nome = objCliente.Nome.Trim();
                verificacao = Nome.Length <= 50 && Nome.Length > 0;
                if (!verificacao)
                {
                    objCliente.Estado = 2;
                    return;
                }

            }
            
            //begin verificar duplicidade CPF retorna Estado=8
            Cliente objCliente1 = new Cliente();
            objCliente1.CPF = objCliente.CPF;
            verificacao = objClienteDao.PesquisaPorCPF(objCliente1);

            if (verificacao)
            {
                objCliente.Estado = 9;
                return;
            }
            //end validar duplicidade CPF

            //se nao tem erro
            objCliente.Estado = 99;
            objClienteDao.Criar(objCliente);
            return;
        }

        public void Atualizar(Cliente objCliente)
        {
            bool verificacao = true;

            //begin validar Nome retorna Estado=2
            string Nome = objCliente.Nome;
            if (Nome == null)
            {
                objCliente.Estado = 20;
                return;
            }
            else
            {
                Nome = objCliente.Nome.Trim();
                verificacao = Nome.Length <= 30 && Nome.Length > 0;
                if (!verificacao)
                {
                    objCliente.Estado = 2;
                    return;
                }

            }
            //end validar Nome

            //begin validar Telefone retorna Estado=7
            string Telefone = objCliente.Telefone;
            if (Telefone == null)
            {
                objCliente.Estado = 70;
                return;
            }
            else
            {
                Telefone = objCliente.Telefone.Trim();
                verificacao = Telefone.Length <= 30 && Telefone.Length > 0;
                if (!verificacao)
                {
                    objCliente.Estado = 7;
                    return;
                }

            }
            //end validar Telefone

            //begin verificar duplicidade CPF retorna Estado=8
            //verificacao = objClienteDao.PesquisaPorCPF(objCliente);

            //if (!verificacao)
            //{
            //    objCliente.Estado = 9;
            //    return;
            //}
            //end validar duplicidade CPF

            //se nao tem erro
            objCliente.Estado = 99;
            objClienteDao.Atualizar(objCliente);
            return;
        }

        public void Excluir(int id)
        {
            bool verificacao = true;
            //verificando se existe
           
            //objCliente.Estado = 99;
            objClienteDao.Deletar(id);
            return;
        }

        public Cliente PesquisarClientePorID(int? ClienteID)
        {
            return objClienteDao.PesquisarClientePorID(ClienteID); 
        }

        public List<Cliente> ListarTodos()
        {
            return objClienteDao.ListarTodos();
        }
    }
}
