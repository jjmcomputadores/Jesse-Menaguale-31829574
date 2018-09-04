using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercícios 1

            // Questão 1

            Console.WriteLine("\nQuestão 01\n");
            Console.WriteLine("1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31 32 33 34 35 36 37 38 39 40");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("\nQuestão 1.1\n");
               int num;
               num = 1;
               while (num <= 40)
           {               
               Console.Write(num);
               Console.Write("\t");
               num = num + 1;
           }
             Console.ReadKey();
             Console.Clear();

            // Questão 2

            Console.WriteLine("\nQuestão 02\n");

            int x = 2;
            int y = 3;

           {
               Console.WriteLine("x = " + x);
               Console.WriteLine("O valor de x + x é " + (x + x));
               Console.WriteLine("x = " + x);
               Console.WriteLine((x + y) + " = " + (y + x));
               Console.ReadKey();
               Console.Clear();

            }
             // Questão 3
             {
                Console.WriteLine("\nQuestão 03\n");
                Console.WriteLine("*\n**\n***\n****\n*****");
                Console.ReadKey();
                Console.Clear();
            }
             // Questão 4
             {
                Console.WriteLine("\nQuestão 04\n");
                Console.Write("*");
                Console.Write("***");
                Console.WriteLine("*****");
                Console.Write("****");
                Console.WriteLine("**");
                Console.ReadKey();
                Console.Clear();
             }
             // Questão 5

             {
                Console.WriteLine("\nQuestão 05\n");
                Console.WriteLine("\nBem vindo ");
                Console.WriteLine("\nDigite seu nome");
                var nome = Console.ReadLine();
                Console.WriteLine("\nDigite seu sobrenome");
                var sobrenome = Console.ReadLine();
                Console.WriteLine("\nDigite sua matricula");
                var matricula = Console.ReadLine();
                Console.Write("\nBem vindo ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write($"{matricula}");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(" - ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{nome} ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write($"{sobrenome}");
                Console.Write("\nPress any key to exit...\n");
                Console.ReadKey(true);
                Console.Clear();

            }

            // QUESTÃO 06
            
            Console.WriteLine("\nQuestão 06\n");
            double numero1, numero2;

            Console.WriteLine("\n\tDigite um número: ");
            numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\n\tDigite outro número: ");
            numero2 = double.Parse(Console.ReadLine());

            double soma = numero1 + numero2;
            double subtracao = numero1 - numero2;
            double multiplicacao = numero1 * numero2;
            double divisao = numero1 / numero2;

            Console.WriteLine("\tA soma dos números é {0}\n\tA subtração dos números é {1}\n\tA multiplicação dos número é {2}\n\tA divisão dos números é {3:N1}", soma, subtracao, multiplicacao, divisao);

            Console.ReadKey();
            Console.Clear();

            // QUESTÃO 07
            
            Console.WriteLine("\nQuestão 07\n");

            const double PI = 3.14D;
            double area = 0;
            double raio = 0;
            double diam = 0;
            double circ = 0;

            Console.Write("Qual o valor do raio? ");
            raio = double.Parse(Console.ReadLine());

            area = PI * raio * raio;
            diam = 2 * raio;
            circ = PI * diam;

            Console.Write("\n\tA área do circulo é: " + area);
            Console.Write("\n\tO diâmetro do circulo é: " + diam);
            Console.Write("\n\tA circunferência do circulo é: " + circ);

            Console.ReadKey();
            Console.Clear();

            // QUESTÃO 08
            Console.WriteLine("\nQuestão 08\n");
            
            int a;
            int b;
            int resto = 0;

            Console.WriteLine("Informe um valor para a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe um valor para b: ");
            b = Convert.ToInt32(Console.ReadLine());

            resto = a % b;

            if (resto == 0)
            {
                Console.WriteLine($"{a} é divisível de {b}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"{a} não é divisível de {b}");
                Console.ReadKey();
                Console.Clear();
            }

            Console.Clear();
            
            //Questão 9
             {
                Console.WriteLine("\nQuestão 09\n");

                int unidade = 0;
                int dezena = 0;
                int centena = 0;
                int unidadeDeMilhar = 0;
                int dezenaDeMilhar = 0;
                int restoDivisao = 0;
                int quociente = 0;

                const int DECIMAL = 10;

                Console.WriteLine("Digite um número inteiro com 5 dígitos");
                Console.Write("\nNúmero: ");
                int numeroCincoDigitos = Int32.Parse(Console.ReadLine());

                restoDivisao = numeroCincoDigitos % DECIMAL;
                quociente = numeroCincoDigitos / DECIMAL;
                unidade = restoDivisao;

                restoDivisao = quociente % DECIMAL;
                quociente = quociente / DECIMAL;
                dezena = restoDivisao;

                restoDivisao = quociente % DECIMAL;
                quociente = quociente / DECIMAL;
                centena = restoDivisao;

                restoDivisao = quociente % DECIMAL;
                quociente = quociente / DECIMAL;
                unidadeDeMilhar = restoDivisao;

                dezenaDeMilhar = quociente;

                Console.WriteLine("Número Espaçado: {0}   {1}   {2}   {3}   {4}", dezenaDeMilhar, unidadeDeMilhar, centena, dezena, unidade);
                
                Console.WriteLine("\n\n");
                Console.Clear();
            } 


            //Questão 10
            {
                Console.WriteLine("\nQuestão 10\n");
                Console.WriteLine("\n Número Quadrado Cubo");
                                
                //Condiçao
                for (int i = 0; i <= 10; i++)
                
                {
                    Console.WriteLine((i) + "         " + (i * i) + "          " + (i * i * i));
                }
                Console.ReadKey();
            }
                Console.Write("\nPress any key to exit...\n");



        }
    }
}
