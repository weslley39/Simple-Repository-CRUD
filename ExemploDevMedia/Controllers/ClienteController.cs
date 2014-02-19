using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExemploDevMedia.Models;

namespace ExemploDevMedia.Controllers
{
    public class ClienteController : Controller
    {
        //
        // GET: /Cliente/

        private ClienteRepositorio clienteRepositorio;

        public ClienteController()
        {
            clienteRepositorio = RepositorioFactory.InstanciarRepositorio();
        }

        public ActionResult Index()
        {
            var clientes = clienteRepositorio.RetornarTodos();
            return View(clientes);
        }

        public ActionResult Inserir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Inserir(Clientes cliente)
        {
            var cli = clienteRepositorio.RetornarTodos().OrderByDescending(c => c.id).FirstOrDefault();
            cliente.id = cli.id + 1;
            clienteRepositorio.Inserir(cliente);

            var clientes = clienteRepositorio.RetornarTodos();

            return View("Index", clientes);
        }

    }
}
