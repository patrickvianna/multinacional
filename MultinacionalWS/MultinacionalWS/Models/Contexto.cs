using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MultinacionalWS.Models
{
    public class Contexto: DbContext
    {
        DbSet<Cliente> Clientes { get; set; }
        DbSet<Produto> Produtos { get; set; }

        public System.Data.Entity.DbSet<MultinacionalWS.Models.Cliente> Cliente { get; set; }

        public System.Data.Entity.DbSet<MultinacionalWS.Models.Produto> Produto { get; set; }
    }
}