using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC2.Models
{
    public class Film
    {
        [Required]
        public Int32 Id { get; set; }
        [Required]
        public String Titre { get; set; }
        public String Realisateur { get; set; }
    }
}