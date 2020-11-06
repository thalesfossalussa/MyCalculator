using System;

namespace MyCalculator
{
    class Program
    {
        public static int LeituraInt()
        {
            string ler = Console.ReadLine();
            int numero = Convert.ToInt32(ler);
            return numero;
        }

        static void Soma()
        {
            int a = LeituraInt();
            int b = LeituraInt();
            Console.WriteLine($"\n{a} + {b} = {a + b}\n");
        }

        static void Multiplicacao()
        {
            int a = LeituraInt();
            int b = LeituraInt();
            Console.WriteLine($"\n{a} * {b} = {a * b}\n");
        }

        static void Subtracao()
        {
            int a = LeituraInt();
            int b = LeituraInt();
            Console.WriteLine($"\n{a} - {b} = {a - b}\n");
        }

        static void Divisao()
        {
            double a = LeituraInt();
            double b = LeituraInt();
            Console.WriteLine($"\n{a} / {b} = {(a / b):N2}\n");
        }

        static void Potenciacao()
        {
            int x = LeituraInt();
            int expoente = LeituraInt();
            Console.WriteLine($"\n{x}^{expoente} = {Math.Pow(x, expoente)}\n");
        }

        static void RaizQuadrada()
        {
            double x = LeituraInt();
            Console.WriteLine($"\nRaiz quadrade de {x} = {Math.Sqrt(x):N2}\n");
        }

        static void RaizCubica()
        {
            double x = LeituraInt();
            Console.WriteLine($"\nRaiz cubicade de {x} = {Math.Cbrt(x):N2}\n");
        }

        static double Delta(double a, double b, double c)
        {
            double delta;
            delta = Math.Pow(b, 2) - (4 * a * c);
            return delta;
        }

        static void Bhaskara()
        {
            Console.Write("a = ");
            double a = LeituraInt();
            Console.Write("b = ");
            double b = LeituraInt();
            Console.Write("c = ");
            double c = LeituraInt();
            double x1, x2;
            if (Delta(a,b,c) < 0) Console.WriteLine("Não possui raiz real\n");
            else
            {
                x1 = (-b + Math.Sqrt(Delta(a, b, c))) / (2 * a);
                x2 = (-b - Math.Sqrt(Delta(a, b, c))) / (2 * a);

                if (x1 == x2) Console.WriteLine($"Raiz única {x1:N2}\n");
                else Console.WriteLine($"x1 = {x1:N2}\nx2 = {x2:N2}\n");
            }
        }

        static void Media()
        {
            Console.Write("Digite a quantidade de números: ");
            int tamanho = LeituraInt();
            double media = 0;
            for (int i = 0; i < tamanho; i++) media += LeituraInt();
            media /= tamanho;
            Console.WriteLine($"Media = {media:N2}\n");
        }

        static void MenuAreas()
        {
            int selecionarMenu;
            while (true)
            {
                Console.Write
                (
                    "1 - Quadrado\n" +
                    "2 - Retângulo\n" +
                    "3 - Triângulo\n" +
                    "4 - Losango\n" +
                    "0 - Voltar\n"
                );

                selecionarMenu = LeituraInt();
                if (selecionarMenu == 0) break;
                else
                {
                    switch (selecionarMenu)
                    {
                        case 1:
                            Area.Quadrado();
                            break;
                        case 2:
                            Area.Retangulo();
                            break;
                        case 3:
                            Area.Triangulo();
                            break;
                        case 4:
                            Area.Losango();
                            break;
                        default:
                            Console.WriteLine("Esse menu não existe!\n");
                            break;
                    }
                }
            }
        }

        static void Main()
        {
            int selecionarMenu;
            string nomeUsuario;
            Console.Write("Olá! Qual o seu nome? ");

            nomeUsuario = Console.ReadLine();

            Console.WriteLine("\n" + nomeUsuario + " Started MyCalculator! have fun!!!\n");

            while (true)
            {
                Console.Write
                (
                    "Menu de operações:\n" +
                    "1 - Soma\n" +
                    "2 - Multiplicação\n" +
                    "3 - Subtração\n" +
                    "4 - Divisão\n" +
                    "5 - Potenciação\n" +
                    "6 - Raiz quadrada\n" +
                    "7 - Raiz cubica\n" +
                    "8 - Bhaskara\n" +
                    "9 - Média\n" +
                    "10 - Áreas\n" +
                    "0 - Sair\n"
                ); ;

                selecionarMenu = LeituraInt();
                if (selecionarMenu == 0) break;

                switch (selecionarMenu)
                {
                    case 1:
                        Soma();
                        break;
                    case 2:
                        Multiplicacao();
                        break;
                    case 3:
                        Subtracao();
                        break;
                    case 4:
                        Divisao();
                        break;
                    case 5:
                        Potenciacao();
                        break;
                    case 6:
                        RaizQuadrada();
                        break;
                    case 7:
                        RaizCubica();
                        break;
                    case 8:
                        Bhaskara();
                        break;
                    case 9:
                        Media();
                        break;
                    case 10:
                        MenuAreas();
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
