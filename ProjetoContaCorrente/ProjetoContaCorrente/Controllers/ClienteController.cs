using Projeto.Entity;
using Projeto.Neg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ProjetoContaCorrente.Controllers
{
    public class ClienteController : Controller
    {
        ClienteNeg objClienteNeg;

        public ClienteController()
        {
            objClienteNeg = new ClienteNeg();
        }

        public ActionResult Index()
        {
            List<Cliente> ListaCliente = objClienteNeg.ListarTodos();
            return View(ListaCliente);
        }

        public ActionResult Detalhes(int id)
        {
            Cliente objCliente = new Cliente();
            objCliente = objClienteNeg.PesquisarClientePorID(id);
            return PartialView(objCliente);

        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            mensagemInicioRegistrar();
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Cliente objCliente)
        {
            mensagemInicioRegistrar();
            objClienteNeg.Criar(objCliente);
            MensagemErroAtualizar(objCliente);
            ModelState.Clear();
            return View("Cadastrar");
        }
               
        public ActionResult Editar(int? id)
        {
            Cliente objCliente = new Cliente();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            objCliente = objClienteNeg.PesquisarClientePorID(id);
            return View(objCliente);
        }
        
        [HttpPost]
        public ActionResult Editar(Cliente objCliente)
        {
            mensagemInicialAtualizar();
            objClienteNeg.Atualizar(objCliente);
            MensagemErroAtualizar(objCliente);
            return RedirectToAction("Index");
        }

        public ActionResult Deletar(int? id)
        {
            Cliente objCliente = new Cliente();
            objCliente = objClienteNeg.PesquisarClientePorID(id);
            return PartialView(objCliente);
        }

        [HttpPost]
        public ActionResult Deletar(int id)
        {
            objClienteNeg.Excluir(id);
            return RedirectToAction("Index");
        }

        public void mensagemInicialAtualizar()
        {
            ViewBag.MensagemInicialAtualizar = "Formulario para Atualizar Dados do Cliente";
        }


        public void mensagemInicioRegistrar()
        {
            ViewBag.MensagemInicio = "Insira os dados do Cliente e clique em salvar";
        }

        //Mensagem erro ao atualizar
        public void MensagemErroAtualizar(Cliente objCliente)
        {

            switch (objCliente.Estado)
            {
                case 9://campo cpf com letras
                    ViewBag.MensagemErro = "CPF já cadastrado";
                    break;

                case 1000://campo cpf com letras
                    ViewBag.MensagemErro = "Erro CPF, não insira Letras";
                    break;

                case 20://campo nome vazio
                    ViewBag.MensagemErro = "Insira Nome do Cliente";
                    break;

                case 2://erro de nome
                    ViewBag.MensagemErro = "O nome não pode ter mais de 30 caracteres";
                    break;


                case 50://campo cpf vazio
                    ViewBag.MensagemErro = "Insira CPF do Cliente";
                    break;

                case 250://campo cpf vazio
                    ViewBag.MensagemErro = "O CPF tem que ter 11 numeros, apenas numeros";
                    break;


                case 60://endereco vazio
                    ViewBag.MensagemErro = "Insira endereço do Cliente";
                    break;

                case 6://erro no endereço
                    ViewBag.MensagemErro = "Campo endereço não pode ter mais de 50 caracteres";
                    break;

                case 70://campo telefone vazio
                    ViewBag.MensagemErro = "Insira o telefone do cliente";
                    break;

                case 7://campo telefone vazio
                    ViewBag.MensagemErro = "O telefone tem que ter de 8 a 15 digitos";
                    break;


                case 99://Atualizado com sucesso
                    ViewBag.MensagemExito = "Dados do Cliente [" + objCliente.Nome + "] foi atualizado!";
                    break;

            }

        }
    }
}