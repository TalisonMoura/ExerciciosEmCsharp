namespace Exercicio5_SomaImpares {
    internal class Program {
        static void Main(string[] args) {

            int x, y, soma=0, change;

            Console.WriteLine("Digite dois Números");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x > y) {
                change = x;
                x = y;
                y = change;
            }
            for (int i = x + 1; i < y; i++) {
                if(i %2 != 0) {
                    soma = soma + i;
                }
            }

            Console.WriteLine("SOMA DOS IMPARES = " + soma);
        }
    }
}