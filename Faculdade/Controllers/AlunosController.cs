using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Faculdade.Models.Alunos;

namespace Faculdade.Controllers
{
    public class AlunosController : Controller
    {
        public ActionResult Inicio()
        {
            return View();
        }

        

        public ActionResult Lista()
        {
            return View(alunos);
        }

        private static List<Aluno> alunos = new List<Aluno>();

        [HttpGet]
        public ActionResult Cadastro()
        {
            CadastroModel cadastroModel = new CadastroModel();
            return View(cadastroModel);
        }

        [HttpPost]
        public ActionResult Cadastro(string nome, int idade)
        {
            if (idade > 120)
            {
                CadastroModel cadastroModel = new CadastroModel();
                cadastroModel.ListaDeErros.Add("Idade não pode ser maior que 120");

                return View(cadastroModel);
            }

            Aluno aluno = new Aluno();
            aluno.Nome = nome;
            aluno.Idade = idade;

            alunos.Add(aluno);

            return RedirectToAction("Lista");
        }
    }

    public class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}
