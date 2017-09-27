using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DojoArtesMarciais.Models;

namespace DojoArtesMarciais.Controllers
{
    public class AlunoController : Controller
    {
        public List<Aluno> Alunos = new List<Aluno>
        {
        new Aluno {Id= 1, Nome = "Martim Castro Ribeiro", CPF = "158.778.735-04", Faixa = "Branca", TipoDeAssociacao ="Mensal"},
        new Aluno {Id= 2, Nome = "Lucas Alves Melo", CPF = "916.749.332-74", Faixa = "Verde", TipoDeAssociacao ="Semestral"},
        new Aluno {Id= 3, Nome = "Breno Castro Carvalho", CPF = "454.019.800-94", Faixa = "Amarela", TipoDeAssociacao ="Trimestral"},
        new Aluno {Id= 4, Nome= "Laura Cardoso Rocha", CPF = "361.089.665-56", Faixa = "Marrom", TipoDeAssociacao ="Anual"}
        };
         // GET: Aluno
        public ActionResult Index()
        {
            return View(Alunos);
        }

        public ActionResult Details(int id)
        {
            var aluno = Alunos.SingleOrDefault(c => c.Id == id);
            if (aluno == null)
                return HttpNotFound();

            return View(aluno);
        }
    }
}