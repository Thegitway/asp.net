using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ControlleCodeFirst
{
    public class Produit
    {
        [Key]
        public Int32 Idp { get; set; }
        [Required]
        public String matiere { get; set; }
        public String name { get; set; }
        
    }
}