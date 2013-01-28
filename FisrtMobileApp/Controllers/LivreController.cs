using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMobileApp.Models;

namespace FirstMobileApp.Controllers
{
    public class LivreController : Controller
    {
        //
        // GET: /Livre/

        LivreModel[] Livres = new LivreModel[]
        {
        new LivreModel{Id = 1, Titre="Visual C# 2010 étape par étape", Auteur="John Sharp" , Editeur="Dunod", ISBN ="2100547410"},
        new LivreModel{Id = 2, Titre="Conception et Programmation orientées objet", Auteur="Bertrand MEYER" , Editeur="Eyrolles", ISBN ="2212091117"},
        new LivreModel{Id = 3, Titre="Ecrire du code .NET performant", Auteur="Jean-Philippe GOUIGOUX" , Editeur="ENI", ISBN ="2746064456"},
        new LivreModel{Id = 4, Titre="Programming Entity Framework", Auteur="Julia Lerman" , Editeur="O'Reilly UK", ISBN ="059652028X"},
        new LivreModel{Id = 5, Titre="WPF par la pratique", Auteur="Thomas Lebrun" , Editeur="Eyrolles", ISBN ="2212124228"},
        new LivreModel{Id = 6, Titre="Silverlight - Versions 2 et 3", Auteur="Olivier Dewit" , Editeur="ENI", ISBN ="2746049198"},
        new LivreModel{Id = 7, Titre="C# in Depth, Second Edition", Auteur="Jon Skeet" , Editeur="Manning", ISBN ="1935182471"},
        new LivreModel{Id = 8, Titre="De VB6 à VB.NET", Auteur="Dan Appleman" , Editeur="Eyrolles", ISBN ="2212110375"},
        new LivreModel{Id = 9, Titre="Manuel de référence Microsoft ASP.Net", Auteur="Douglas J. Reilly" , Editeur="Dunod", ISBN ="2-10-006472-X"},
        new LivreModel{Id = 10, Titre="ASP.NET 2.0 avec C#2", Auteur="Brice-Arnaud GUERIN" , Editeur="ENI", ISBN ="2746033755"},
        
    };

        public ViewResult Index()
        {
            return View(Livres.ToList());
        }

       
    }
}
