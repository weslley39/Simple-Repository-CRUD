using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExemploDevMedia.Models.Scripts
{
    public class RepositorioFactory
    {

        public static ClienteRepositorio InstanciarRepositorio()
        {
            if (HttpContext.Current.Session["repositorioCliente"] == null)
                return new ClienteRepositorio();
            return (ClienteRepositorio)HttpContext.Current.Session["repositorioCliente"];
        }
    }
}