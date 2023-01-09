namespace Exercicio7_Duracao {
    internal class Program {
        static void Main(string[] args) {

            int segundos,minutos,horas,resto,num;
            Console.Write("Digite a duaração em segundos: ");
            num = int.Parse(Console.ReadLine());

            horas = num / 3600;
            resto = num % 3600;
            minutos = resto / 60;
            segundos = resto % 60;

            Console.Write(horas+":"+minutos+":"+segundos);
        
        
        
        }
    }
}