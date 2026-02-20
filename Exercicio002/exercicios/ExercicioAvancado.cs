using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio002.exercicios
{
    class ExercicioAvancado
    {
        public static void NumeroAleatorio()
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 100);
            bool laco = true;
            Console.Write("Tente acertar o número entre 1 a 100!\nDigite um número:");
            int numero = int.Parse(Console.ReadLine());
            while (laco)
            {
                if (numeroAleatorio > numero)
                {
                    Console.WriteLine("O número é maior!");
                }
                else if (numeroAleatorio < numero)
                {
                    Console.WriteLine("O número é menor!");
                }
                else
                {
                    Console.WriteLine("Parabéns! Você acertou o número!");
                    laco = false;
                }
                if (laco)
                {
                    Console.Write("Digite outro número:");
                    numero = int.Parse(Console.ReadLine());
                }
            }
        }

        public static void ManipulacaoArray()
        {
            int[] array = new int[10];
            int numeroMaior = array[0];
            int numeroMenor = array[0];
            int numeroMedia = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > numeroMaior)
                {
                    numeroMaior = array[i];
                }
                if (array[i] < numeroMenor)
                {
                    numeroMenor = array[i];
                }
            }
            numeroMedia = array.Sum() / array.Length;
            //Bubble Sort 
            for (int i = 0; i < array.Length; i++) // esse primeiro for é para percorrer o array
            {
                for (int j = 0; j < array.Length; j++) // esse segundo é para comparar o valor do array e alterar a posição do valor
                {
                    if (array[i] < array[j]) // se o a posicao do array[i] for menor que a posicao do array[j] ele troca a posicao
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Console.WriteLine($"O número maior é: {numeroMaior}");
            Console.WriteLine($"O número menor é: {numeroMenor}");
            Console.WriteLine($"A média dos números é: {numeroMedia}");
            Console.WriteLine("Os números em ordem decrescente são:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }


        public static void CalculadoraCaixa()
        {
            Console.Write($"Digita o valor para saque: ");
            decimal reais = decimal.Parse(Console.ReadLine());
            int[] notas = { 200, 100, 50, 20, 10, 5, 2, 1 };
            for (int i = 0; i < notas.Length; i++)
            {
                int quantidadeNotas = (int)(reais / notas[i]);
                reais -= quantidadeNotas * notas[i];
                if (quantidadeNotas != 0)
                    Console.WriteLine($"Notas de R${notas[i]}: {quantidadeNotas}");
            }
        }

        public static void ValidadorCPF()
        {
            Console.Write("Digite seu CPF 👀👀: ");
            string entrada = Console.ReadLine();
            int[] cpf = new int[11];
            for (int i = 0; i < cpf.Length; i++)
            {
                cpf[i] = int.Parse(entrada[i].ToString());
            }
            int somaPrimeira = 0;
            for (int i = 0; i < 9; i++)
            {
                somaPrimeira += cpf[i] * (10 - i) ;
            }
           int resto = somaPrimeira % 11;
            int primeiroDigito = resto < 2 ? 0 : 11 - resto;
            int somaSegunda = 0; 
            for (int i = 0; i < 10; i++)
            {
                somaSegunda += cpf[i] * (11 - i);
               
            }
           resto = somaSegunda % 11;
            int segundoDigito = resto < 2 ? 0 : 11 - resto;
             bool cpfValido = primeiroDigito == cpf[9] && segundoDigito == cpf[10];
          string masc = new string(cpf.Select((c, i) => i < cpf.Length - 2 ? '*' : (char)('0' + c)).ToArray());
            string cpfFormatado = $"{masc.Substring(0, 3)}.{masc.Substring(3, 3)}.{masc.Substring(6, 3)}-{masc.Substring(9, 2)}";
            Console.WriteLine(cpfValido ? $"O CPF {cpfFormatado} Válido!" : $"O CPF {cpfFormatado} Inválido!");
        }
        public static void MiniBanco() {
           
        }
    }
}
