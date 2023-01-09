using System.Globalization;

namespace Exercicio2_Idades {
    internal class Program {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;

            String nome1,nome2;
            int idade1,idade2;
            double soma, media;

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            nome1 = Console.ReadLine();
            Console.Write("Idade: ");
            idade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da Segunda pessoa: ");
            Console.Write("Nome: ");
            nome2 = Console.ReadLine();
            Console.Write("Idade: ");
            idade2 = int.Parse(Console.ReadLine());

            soma = idade1 + idade2;
            media = soma / 2.0;

            Console.WriteLine("A idade media de " + nome1 + " e " + 
                nome2 + " é de " + media.ToString("F1", ci) + " anos");
        
        }
    }
}