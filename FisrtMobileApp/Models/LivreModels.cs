using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstMobileApp.Models
{
    public class LivreModel
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public string Editeur { get; set; }
        public string ISBN { get; set; }
    }
}