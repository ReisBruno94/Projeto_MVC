using Projeto.Entity;
using Projeto.Neg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoContaCorrente.Controllers
{
    public class ContaController : Controller
    {

        ContaNeg objContaNeg;
        ClienteNeg objClienteNeg;
        BancoNeg objBancoNeg;

        public ContaController()
        {
            objContaNeg = new ContaNeg();
            objClienteNeg = new ClienteNeg();
            objBancoNeg = new BancoNeg();
        }

        [HttpGet]
        public ActionResult Index()
        {
            List<Conta> lstConta = new List<Conta>();

            lstConta = objContaNeg.PesquisarTodos();
            return View(lstConta);
        }


        public ActionResult Cadastrar()
        {
            ViewBag.Cliente = objClienteNeg.ListarTodos();
            ViewBag.Banco = objBancoNeg.ListarTodos();

            var objConta = new Conta();
            return View(objConta);
        }

        [HttpPost]
        public ActionResult Cadastrar(Conta objConta)
        {

            objContaNeg.Criar(objConta);

            return RedirectToAction("Index");
        }

        public ActionResult Deletar(int? id)
        {
            Conta objConta = new Conta();
            objConta = objContaNeg.PesquisarContaID(id);
            return PartialView(objConta);
        }

        [HttpPost]
        public ActionResult Deletar(int id)
        {
            objContaNeg.Excluir(id);
            return RedirectToAction("Index");
        }
    }
}