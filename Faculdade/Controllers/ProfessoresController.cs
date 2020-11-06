using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Faculdade.Models.Professores;

namespace Faculdade.Controllers
{
    public class ProfessoresController : Controller
    {
        static List<Professor> listaProfessores = new List<Professor>();

        public ActionResult Lista(string pesquisa)
        {
            if (pesquisa == null)
            {
                return View(listaProfessores);
            }
            else
            {
                List<Professor> listaDeProfessoresEncontradosPeloNome = listaProfessores.Where(professor => professor.Nome.Contains(pesquisa, StringComparison.InvariantCulture)).ToList();

                return View(listaDeProfessoresEncontradosPeloNome);
            }
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(string cpf, string nome, int formacao)
        {
            //textos = string, numeros = (int, decimal), datas = DateTime
            Professor professor = new Professor();
            professor.Nome = nome;
            professor.Formacao = formacao;
            professor.Cpf = cpf;

            listaProfessores.Add(professor);

            return View();
        }

        [HttpGet]
        public ActionResult Excluir(string cpf)
        {
            Professor professor = listaProfessores.First(professor => professor.Cpf == cpf);

            return View(professor);
        }

        [HttpPost]
        public ActionResult Excluir(string cpf, bool confirmou)
        {
            Professor professor = listaProfessores.First(professor => professor.Cpf == cpf);

            listaProfessores.Remove(professor);

            return RedirectToAction("Lista");
        }

        [HttpGet]
        public ActionResult Detalhes()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Alterar(string cpf)
        {
            Professor professor = listaProfessores.First(professor => professor.Cpf == cpf);

            return View(professor);
        }

        [HttpPost]
        public ActionResult Alterar(string cpf, string nome, int formacao)
        {
            Professor professor = listaProfessores.First(professor => professor.Cpf == cpf);
            professor.Nome = nome;
            professor.Formacao = formacao;

            return View(professor);
        }
    }

    //exemplo buscar professor pelo CPF
    //foreach (var professor in listaProfessores)
    //{
    //    if (professor.Cpf == cpf)
    //    {
    //        professorParaAlterarOsDados = professor;
    //    }
    //}
}
