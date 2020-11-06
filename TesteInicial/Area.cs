using System;

namespace MyCalculator
{
    public class Area
    {
        public static void Quadrado()
        {
            Console.WriteLine("Digite o valor da lateral");
            int lateral = Program.LeituraInt();
            Console.WriteLine($"Área do quadrado = {Math.Pow(lateral, 2)}\n");
        }

        public static void Retangulo()
        {
            Console.Write("Comprimento = ");
            int comprimento = Program.LeituraInt();
            Console.Write("Altura = ");
            int Altura = Program.LeituraInt();
            Console.WriteLine($"Área do retângulo = {comprimento * Altura}");
        }
    }
}
