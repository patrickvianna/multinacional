using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Multinacional.Models
{
    public class Sede
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
    }
}