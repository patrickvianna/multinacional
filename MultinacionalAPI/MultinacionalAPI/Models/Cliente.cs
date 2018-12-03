using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MultinacionalAPI.Models
{
    public class Cliente
    {
        [Key]
        public int id { get; set; }
        public int nome { get; set; }
        public string email { get; set; }
        public string sessao { get; set; }
    }
}