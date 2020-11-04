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

        public ActionResult Lista()
        {
            return View(listaProfessores);
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
        public ActionResult Excluir()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Detalhes()
        {
            return View();
        }

        [Route("alterar/{id}")]
        public ActionResult Alterar(string id)
        {
            return View();
        }
    }
}
