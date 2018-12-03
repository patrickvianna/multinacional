using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Multinacional.Models
{
    public class Produto
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public float valor { get; set; }
        public Sede sede { get; set; }
    }
}