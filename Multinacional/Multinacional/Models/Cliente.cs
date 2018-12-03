using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Multinacional.Models
{
    public class Cliente
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public float dinheiro { get; set; }
        public Sede sede { get; set; }
    }
}