using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControlleCodeFirst
{
   public class Atome
    {
        [Key]
        public String symbole { get; set; }
        public int proton { get; set; }
        public int neutron { get; set; }
        public int electron { get; set; }


    }
}