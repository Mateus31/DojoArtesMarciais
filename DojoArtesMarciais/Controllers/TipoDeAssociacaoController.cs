using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DojoArtesMarciais.Models;

namespace DojoArtesMarciais.Controllers
{
    public class TipoDeAssociacaoController : Controller
    {
        // GET: TipoDeAssociacao
        public List<TipoDeAssociacao> TipoDeAssociacao = new List<TipoDeAssociacao>
        {
        new TipoDeAssociacao {Id = 1,Nome = "Mensal", Periodo = 1, Mensalidade = 140},
        new TipoDeAssociacao {Id = 2,Nome = "Trimestral", Periodo = 3, Mensalidade = 400},
        new TipoDeAssociacao {Id = 3,Nome = "Semestral", Periodo = 6, Mensalidade = 600},
        new TipoDeAssociacao {Id = 4,Nome = "Anual", Periodo = 12, Mensalidade = 1400},

        };

        // GET: Faixa
        public ActionResult Index()
        {
            return View(TipoDeAssociacao);
        }

        public ActionResult Details(int id)
        {
            var tipo = TipoDeAssociacao.SingleOrDefault(c => c.Id == id);
            if (tipo == null)
                return HttpNotFound();

            return View(tipo);
        }
    }
}