using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MultinacionalAPI.Models
{
    public class Contexto: DbContext
    {
        DbSet<Cliente> Clientess { get; set; }
        DbSet<Produto> Produtos { get; set; }

        public System.Data.Entity.DbSet<MultinacionalAPI.Models.Cliente> Clientes { get; set; }

        public System.Data.Entity.DbSet<MultinacionalAPI.Models.Produto> Produtoes { get; set; }
    }
}