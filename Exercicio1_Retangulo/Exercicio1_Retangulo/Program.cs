using System.Globalization;

namespace Exercicio1_Retangulo {
    internal class Program {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;      

            double largura, altura, area, perimetro, diagonal;

            Console.Write("Base do Retangulo: ");
            largura = double.Parse(Console.ReadLine(), ci);
            Console.Write("Altura do Retangulo: ");
            altura = double.Parse(Console.ReadLine(), ci);  

            area = largura * altura;
            perimetro = 2 * (largura + altura);
            diagonal = Math.Sqrt(Math.Pow(largura, 2.0) + Math.Pow(altura, 2.0));

            Console.WriteLine("Area = " + area.ToString("F4", ci));
            Console.WriteLine("Perimetro = " + perimetro.ToString("F4", ci));
            Console.WriteLine("Diagonal = " + diagonal.ToString("F4", ci));


        }
    }
}