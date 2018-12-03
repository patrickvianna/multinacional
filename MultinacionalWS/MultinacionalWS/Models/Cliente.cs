using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MultinacionalWS.Models
{
    public class Cliente
    {
        [Key]
        public int id { get; set; }
        public int nome { get; set; }
        public int email { get; set; }
        public int dinheiro { get; set; }
        public int sessao { get; set; }
    }
}