using System.Collections.Generic;

namespace Faculdade.Models.Turma
{
    public class ProfessoresModel
    {
        public static List<string> Professores { get; set; } = new List<string>();

        public void AdicionarProfessor(string nome)
        {
            Professores.Add(nome);
        }
    }
}
