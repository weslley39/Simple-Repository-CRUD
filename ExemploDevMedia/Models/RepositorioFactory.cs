﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExemploDevMedia.Models
{
    public class RepositorioFactory
    {
        public static ClienteRepositorio InstanciarRepositorio()
        {
            if (HttpContext.Current.Application["repositorioCliente"] == null)
                return new ClienteRepositorio();
            return (ClienteRepositorio)HttpContext.Current.Application["repositorioCliente"];
        }
    }
}