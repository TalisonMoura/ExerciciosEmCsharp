using System.Globalization;

namespace Exercicio6_SomaVetor {
    internal class Program {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;  

            int i, n;
            double soma=0, media=0;
            Console.Write("Quantos números você vai digitar? ");
            n = int.Parse(Console.ReadLine());
            
            double[] vet = new double[n];

            for(i=0;i<n; i++) {
                Console.Write("Digite um numero: ");
                vet[i] = double.Parse(Console.ReadLine(), ci);
            }
            Console.Write("\nVALORES = ");
            for(i=0;i<n; i++) {
                Console.Write(vet[i].ToString("f1", ci)+ " || ");
            }
            for(i=0;i<n; i++) {
                soma  = soma + vet[i];
            }
            media = soma / n;
            Console.WriteLine("\nSOMA = " + soma.ToString("f2", ci));
            Console.WriteLine("MEDIA = " + media.ToString("f2", ci));


        }
    }
}