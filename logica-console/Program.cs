using logica_console.exercicios;

class Program
{
    static void Main(string[] args)
    {
        string modelo = "1 - Calculadora simples\n2 - Par ou Ímpar\n3 - Tabuada\n4 - Maior de Três\n5 - Contagem Regressiva\n6 - FizzBuzz\n7 - Verificador de palíndromo\n8 - Sequência de Fibonacci\n9 - Calculadora de média\n10 - Número primo\n0 - Encerrar";

        Console.WriteLine("Exercicio 1\n");
        Console.WriteLine("Escolha o Exercicio de sua preferencia e teste:\n");
        bool laco = true;

        while (laco)
        {
            Console.WriteLine(modelo);
            Console.Write("Digite: ");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Console.Write("Digite um numero: ");
                    double numero1 = double.Parse(Console.ReadLine());
                    Console.Write("Digite outro numero: ");
                    double numero2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"${numero1} + ${numero2} = ${ExercicioIniciante.Exercicio01(numero1, numero2)}");
                    break;
                case 2:
                    Console.Write("Digite um numero para saber se é par ou ímpar: ");
                    int numero3 = int.Parse(Console.ReadLine());
                    Console.WriteLine(ExercicioIniciante.Exercicio02(numero3));
                    break;
                case 3:
                    Console.Write("Digite um numero: ");
                    int numero4 = int.Parse(Console.ReadLine());
                    ExercicioIniciante.Exercicio03(numero4);
                    break;
                case 4:
                    Console.Write("Digite um numero: ");
                    int numero01 = int.Parse(Console.ReadLine());
                    Console.Write("Digite outro numero: ");
                    int numero02 = int.Parse(Console.ReadLine());
                    Console.Write("Digite outro numero: ");
                    int numero03 = int.Parse(Console.ReadLine());
                    ExercicioIniciante.Exercicio04(numero01, numero02, numero03);
                    break;
                case 5:
                    Console.Write("Digite um numero: ");
                    int numero = int.Parse(Console.ReadLine());
                    ExercicioIniciante.Exercicio05(numero);
                    break;
                case 6:
                    ExercicioIniciante.Exercicio06();
                    break;
                case 7:
                    Console.Write("Digite uma palavra: ");
                    string palavra = Console.ReadLine();
                    Console.WriteLine(ExercicioIniciante.Exercicio07(palavra));
                    break;
                case 8:
                    Console.Write("Digite um número para Fibonacci:");
                    int n = int.Parse(Console.ReadLine());
                    ExercicioIniciante.Exercicio08(n);
                    break;
                case 9:
                    Console.Write("Digite a quantidades de notas para calcular a nota:");
                    int quantNota = int.Parse(Console.ReadLine());
                    double[] notas = new double[quantNota];
                    for(int i =0; i< notas.Length; i++)
                    {
                        Console.WriteLine($"Digite a {i}° nota");
                        notas[i] = double.Parse(Console.ReadLine());
                    }
                    ExercicioIniciante.Exercicio09(notas);
                    break;
                case 10:
                    ExercicioIniciante.Exercicio10();
                    break;
                case 0:
                    Console.WriteLine("Programa Encerrado!");
                    laco = false;
                    break;
                default:
                    Console.WriteLine("Opção Inválida!");
                    break;
            }
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

    }
}