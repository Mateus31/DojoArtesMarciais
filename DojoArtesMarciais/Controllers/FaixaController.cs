using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DojoArtesMarciais.Models;


namespace DojoArtesMarciais.Controllers
{
    public class FaixaController : Controller
    {
        public List<Faixa> Faixas = new List<Faixa>
        {
        new Faixa {Id = 1,Nome = "Branca", Grau = "6K"},
        new Faixa {Id = 2,Nome = "Amarela", Grau = "5K"},
        new Faixa {Id = 3,Nome = "Roxa", Grau = "4K"},
        new Faixa {Id = 4,Nome = "Verde", Grau = "3K"},
        new Faixa {Id = 5,Nome = "Azul", Grau = "2K"},
        new Faixa {Id = 6,Nome = "Marrom", Grau = "1K"},
        new Faixa {Id = 7,Nome = "Preta", Grau = "1D"},
        };

        // GET: Faixa
        public ActionResult Index()
        {
            return View(Faixas);
        }

        public ActionResult Details(int id)
        {
           var faixa = Faixas.SingleOrDefault(c => c.Id == id);
            if (faixa == null)
                return HttpNotFound();

            return View(faixa);
        }
    }
}