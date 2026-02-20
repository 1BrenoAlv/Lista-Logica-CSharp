using Exercicio002.exercicios;

class Program
{
    static void Main(string[] args)
    {
        string modelo = "1 - Jogo de adivinhação\n2 - Manipulação de array\n3 - Calculadora de caixa eletrônico\n4 - Validador de CPF\n0 - Encerrar";

        Console.WriteLine("Exercicio 2\n");
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
                    ExercicioAvancado.NumeroAleatorio();
                    break;
                case 2:
                    ExercicioAvancado.ManipulacaoArray();
                    break;
                case 3:
                    ExercicioAvancado.CalculadoraCaixa();
                    break;
                case 4:
                    ExercicioAvancado.ValidadorCPF();
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