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
            Console.WriteLine($"Área do retângulo = {comprimento * Altura}\n");
        }

        public static void Triangulo()
        {
            Console.Write("Base = ");
            int b = Program.LeituraInt();
            Console.Write("Altura = ");
            int altura = Program.LeituraInt();
            Console.WriteLine($"Área do triângulo = {(b * altura) / (2)}\n");
        }

        public static void Losango()
        {
            Console.Write("Diagonal maior = ");
            int dMaior = Program.LeituraInt();
            Console.Write("Diagonal menor = ");
            int dMenor = Program.LeituraInt();
            Console.WriteLine($"Área do Losango = {(dMaior * dMenor) / (2)}\n");
        }
    }
}
