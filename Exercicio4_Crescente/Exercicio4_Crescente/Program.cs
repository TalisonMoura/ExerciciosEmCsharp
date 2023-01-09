using System.Security.Cryptography.X509Certificates;

namespace Exercicio4_Crescente {
    internal class Program {
        static void Main(string[] args) {

            int x, y;

            Console.WriteLine("Digite dois números:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            while (x != y) {
            
                if(x>y) {
                    Console.WriteLine("DECRESCENTE!");
                }
                else {
                    Console.WriteLine("CRESCENTE!");
                }
                Console.WriteLine("DIGITE OUTROS DOIS NÚMEROS:");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
            }


        }
    }
}