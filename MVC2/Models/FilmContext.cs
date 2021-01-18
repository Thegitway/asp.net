using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data;

namespace MVC2.Models
{
    public class FilmContext :DbContext
    {
        public FilmContext() : base("DBFilm")
        {
        }
        public DbSet<Film> Films { get; set; }
    }
}