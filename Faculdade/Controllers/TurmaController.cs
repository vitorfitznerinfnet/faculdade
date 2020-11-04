using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Faculdade.Models.Turma;

namespace Faculdade.Controllers
{
    public class TurmaController : Controller
    {
        public IActionResult Professores()
        {
            return View(ProfessoresModel.Professores);
        }

        public IActionResult Participantes()
        {
            return View();
        }

        public IActionResult Inicio()
        {
            return View();
        }

        public IActionResult CadastrarProfessor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EfetivarCadastroDeProfessor(string nomeDoProfessor)
        {
            ProfessoresModel professoresModel = new ProfessoresModel();

            professoresModel.AdicionarProfessor(nomeDoProfessor);
            
            return RedirectToAction("Professores");
        }
    }
}
