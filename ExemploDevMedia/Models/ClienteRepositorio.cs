using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExemploDevMedia.Models
{
    public class ClienteRepositorio
    {
        private IList<Clientes> clientes;
        public ClienteRepositorio()
        {
            clientes = new List<Clientes>();
            clientes.Add(new Clientes()
            {
                id = 1,
                Nome = "Weslley",
                Idade = 19
            });

            clientes.Add(new Clientes()
            {
                id = 2,
                Nome = "Gabriele",
                Idade = 18
            });
        }
        public void Inserir(Clientes cliente)
        {

                clientes.Add(cliente);
        }

        public IList<Clientes> RetornarTodos()
        {
            return clientes;
        }
    }
}