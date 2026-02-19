using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica_console.exercicios
{
    class ExercicioIniciante
    {
        public static double Exercicio01(double numero01, double numero02)
        {
            return numero01 + numero02;
        }
        public static string Exercicio02(int numero)
        {
            string impar = numero % 2 == 0 ? $"O número {numero} é par!" : $"O número {numero} é ímpar!";
            return impar;
        }
        public static void Exercicio03(int numero)
        {
            for (int i = 1; i < 11; i++)
            {
                int tabuada = numero * i;
                Console.WriteLine($"{numero} X {i} = {tabuada}");
            }
        }
        public static void Exercicio04(int numero01, int numero02, int numero03)
        {
            if (numero01 > numero02 && numero02 < numero03)
            {
                Console.WriteLine($"Número {numero01} é o maior de todos");
            }
            else if (numero02 > numero01 && numero01 > numero03)
            {
                Console.WriteLine($"Número {numero02} é o maior de todos");
            }
            else
            {
                Console.WriteLine($"Número {numero03} é o maior de todos");
            }
        }
        public static void Exercicio05(int numero)
        {
            for (int i = numero; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }
        public static void Exercicio06()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FIZZBUZZ");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("FIZZ");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("BUZZ");
                }
                else { Console.WriteLine(i); }
            }
        }
        public static string Exercicio07(string palavra)
        {
            string invertida = new string(palavra.Reverse().ToArray());
            string palindromo = invertida == palavra ? "É Palíndromo!" : "Não é Palíndromo";
            return palindromo;
        }
        public static void Exercicio08(int n)
        {
            int a = 0;
            int b = 1;
            Console.Write(a);
            for (int i = 0; i < n; i++)
            {
                int proximo = a + b;
                Console.Write($", {b}");
                a = b;
                b = proximo;
            }
        }
        public static void Exercicio09(double[] notas)
        {
            double media = notas.Average();
            if (media > 6.99)
            {
                Console.WriteLine("Aprovado!!");
            }
            else if (media > 4.99)
            {
                Console.WriteLine("Recuperação!!");
            }
            else
            {
                Console.WriteLine("Reprovado!!");
            }
        }
        public static void Exercicio10()
        {
            List<int> numerosPrimos = new List<int>();
            Console.Write("Digite um número: ");
            int nPrimo = int.Parse(Console.ReadLine());
            bool continuar = true;
            while (continuar)
            {
                bool ePrimo = true;
                if (nPrimo <= 1)
                {
                    ePrimo = false;
                }
                else
                {
                    for (int i = 2; i < nPrimo; i++)
                    {
                        if (nPrimo % i == 0)
                        {
                            ePrimo = false;
                            break;
                        }
                    }
                }
                if (ePrimo)
                {
                    Console.WriteLine($"O número {nPrimo} é Primo");
                    numerosPrimos.Add(nPrimo);
                }
                else
                {
                    Console.WriteLine($"O número {nPrimo} não é Primo");
                }
                Console.WriteLine("Deseja continuar? S/N");
                char simOrNao = char.Parse(Console.ReadLine());
                if (simOrNao == 'N')
                {
                    Console.WriteLine("Lista de números Primos citado: ");
                    foreach (int i in numerosPrimos)
                    {
                        Console.WriteLine($"- {i}");
                    }
                    continuar = false;
                }
                else
                {
                    Console.Write("Digite outro número: ");
                    nPrimo = int.Parse(Console.ReadLine());
                }

            }
        }
    }
}
