using System.Globalization;

namespace ExemploVetor {
    internal class Program {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int i,n;
            Console.Write("Quantos numeros voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            for(i=0;i<n;i++) {
                Console.Write("Digite um numero: ");
                vet[i] = double.Parse(Console.ReadLine(), ci);
            }
            Console.WriteLine();
            Console.WriteLine("NUMEROS DIGITADOS:");
            for(i=0;i<n;i++) {
                Console.WriteLine(vet[i].ToString("F1"), ci) ;
            }
        }
    }
}