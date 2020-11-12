using System;

namespace MyCalculator
{
    class Area
    {
        public double Quadrado(int lateral)
        {
            return Math.Pow(lateral, 2);
        }

        public double Retangulo(int comprimento, int altura)
        {
            return comprimento * altura;
        }

        public double Triangulo(int b, int altura)
        {
            return b * altura / 2;
        }

        public double Losango(int diagonalMaior, int diagonalMenor)
        {
            return diagonalMaior * diagonalMenor / 2;
        }
    }
}
