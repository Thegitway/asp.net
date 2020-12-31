using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControlleCodeFirst
{
    public class Matiere
    {
        [Key]
        public Int32 Idm { get; set; }

        [Required]
        public String atome { get; set; }
        //Liquide Solide Gaz...
        public String etat { get; set; }
        public String name { get; set; }
        //Mass Volumique
        public float MV { get; set; }
        public bool rare { get; set; }
    }
}