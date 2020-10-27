using System;
using System.Reflection.Metadata.Ecma335;

namespace TesteInicial
{
    class Program
    {
        static int leituraInt()
        {
            string ler;
            int numero;
            ler = Console.ReadLine();
            numero = Convert.ToInt32(ler);
            return numero;
        }

        static void soma()
        {
            int a, b, sum;
            a = leituraInt();
            b = leituraInt();
            sum = a + b;
            Console.WriteLine("\nA soma dos números é: " + sum + "\n");
        }

        static void multiplicacao()
        {
            int a, b, mult;
            a = leituraInt();
            b = leituraInt();
            mult = a * b;
            Console.WriteLine("\nA multiplicação dos números é: " + mult + "\n");
        }

        static void subtracao()
        {
            int a, b, sub;
            a = leituraInt();
            b = leituraInt();
            sub = a - b;
            Console.WriteLine("\nA subtração dos números é: " + sub + "\n");
        }

        static void divisao()
        {
            double a, b;
            double div;
            a = leituraInt();
            b = leituraInt();
            div = a / b;
            Console.WriteLine("\nA divisão dos números é: " + div.ToString("N2") + "\n");
        }

        static void potenciacao()
        {
            double x, expoente;
            Console.Write("Escreva o número: ");
            x = leituraInt();
            Console.Write("Agora escreva o expoente: ");
            expoente = leituraInt();
            Console.WriteLine("O resultado da potenciação é: " + Math.Pow(x,expoente) + "\n");
        }

        static void raizQuadrada()
        {
            double x;
            Console.Write("Escreva o valor da raiz: ");
            x = leituraInt();
            Console.WriteLine("O resultado da raiz quadrada é: " + Math.Sqrt(x) + "\n");
        }

        static void Main(string[] args)
        {
            int menu;
            string nome;
            Console.Write("Olá! Qual o seu nome? ");

            nome = Console.ReadLine();

            Console.WriteLine("\n" + nome + " Started MyCalculator! have fun!!!\n");

            while(true)
            {
                Console.WriteLine("Menu de operações:");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Multiplicação");
                Console.WriteLine("3 - Subtração");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Potenciação");
                Console.WriteLine("6 - Raiz quadrada");
                Console.WriteLine("0 - Sair");

                menu = leituraInt();
                if (menu == 0) break;

                switch (menu)
                {
                    case 1:
                        soma();
                        break;
                    case 2:
                        multiplicacao();
                        break;
                    case 3:
                        subtracao();
                            break;
                    case 4:
                        divisao();
                            break;
                    case 5:
                        potenciacao();
                        break;
                    case 6:
                        raizQuadrada();
                        break;
                    default:
                        Console.WriteLine("\nValor inválido, por favor tente novamente!\n");
                        break;
                }
            }
            Console.WriteLine("Fim de execução!");
        }
    }
}
