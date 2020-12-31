using System;
using System.Data.Entity;
using System.Linq;

namespace ControlleCodeFirst
{
    public class MyDb : DbContext
    {
       public MyDb()
            : base("name=MyDb")
        {

        }

        public virtual DbSet<Atome> Atomes { get; set; }
        public virtual DbSet<Matiere> Matieres { get; set; }
        public virtual DbSet<Produit> Produits { get; set; }
    }

   
}