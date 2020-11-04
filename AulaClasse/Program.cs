using System;

namespace AulaClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            string nome = "vitor";

            Produto mesa = new Produto();
            mesa.Nome = "Mesa de madeira";

            Produto cadeira = new Produto();
            cadeira.Nome = "Cadeira giratória";

            Console.ReadKey();
        }
    }

    public class Produto
    {
        public string Nome { get; set; }
        public static decimal Preco { get; set; }
    }
}
