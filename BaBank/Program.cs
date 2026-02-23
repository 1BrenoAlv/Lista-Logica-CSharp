using BaBank.Entities.Conta;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<Conta> contas = new List<Conta>();
        Conta contaLogado = null;
        Console.WriteLine("");
        string menu = "1 - Depositar\n2 - Sacar\n3 - Ver saldo\n4 - Extrato\n5 - Pix\n0 - Sair";
        while (true)
        {

            if (contaLogado == null)
            {
                Console.WriteLine("1 - Criar conta\n2 - Entrar na Conta\n0 - Encerrar");
                Console.Write("Escolha a opção: ");
                int escolha = int.Parse(Console.ReadLine());
                switch (escolha)
                {
                    case 1:
                        Console.Write("Digite seu Nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Digite seu Sobrenome: ");
                        string sobrenome = Console.ReadLine();
                        Console.Write("Digite o numero da conta: ");
                        int numeroConta = int.Parse(Console.ReadLine());
                        Conta conta = new Conta(nome, sobrenome, numeroConta, 0, new List<Registro>());
                        contas.Add(conta);
                        break;
                    case 2:
                        Console.Write("Digite o numero da conta: ");
                        int numeroContaLogin = int.Parse(Console.ReadLine());
                        contaLogado = contas.FirstOrDefault(c => c.NumeroConta == numeroContaLogin);
                        if (contaLogado != null)
                        {
                            Console.WriteLine($"Bem-vindo, {contaLogado.Titular}!");
                            while (true)
                            {
                                Console.WriteLine(menu);
                                Console.Write("Escolha a opção: ");
                                int opcao = int.Parse(Console.ReadLine());
                                switch (opcao)
                                {
                                    case 1:
                                        Console.Write("Digite o valor para depositar: ");
                                        decimal valorDeposito = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                                        contaLogado.Depositar(valorDeposito);
                                        Console.WriteLine("Depósito realizado com sucesso!");
                                        break;
                                    case 2:
                                        Console.Write("Digite o valor para sacar: ");
                                        decimal valorSaque = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                                        if (valorSaque > contaLogado.Saldo)
                                        {
                                            Console.WriteLine("Saldo insuficiente!");
                                        }
                                        else
                                        {
                                            contaLogado.Sacar(valorSaque);
                                            Console.WriteLine("Saque realizado com sucesso!");
                                        }
                                        break;
                                    case 3:
                                        contaLogado.ExibirSaldo();
                                        break;
                                    case 4:
                                        contaLogado.ExibirExtrato();
                                        break;
                                    case 5:
                                        Console.Write("Digite o numero da conta para transferir: ");
                                        int numeroContaPix = int.Parse(Console.ReadLine());
                                        foreach (var p in contas)
                                        {
                                            if (p == null) continue;
                                            if (p.NumeroConta == numeroContaPix)
                                            {
                                                Console.Write("Digite o valor para transferir: ");
                                                decimal valorPix = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                                                if (valorPix > contaLogado.Saldo)
                                                {
                                                    Console.WriteLine("Saldo insuficiente!");
                                                }
                                                else
                                                {
                                                    contaLogado.Pix(valorPix, p.Titular);
                                                    p.Depositar(valorPix);
                                                    Console.WriteLine($"Transferência para {p.Titular} realizada com sucesso!");
                                                }
                                            }
                                        }
                                        break;
                                    case 0:
                                        Console.WriteLine("Saindo da conta...");
                                        contaLogado = null;
                                        break;
                                    default:
                                        Console.WriteLine("Opção inválida!");
                                        break;
                                }
                                if (contaLogado == null)
                                {
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Conta não encontrada!");
                        }
                        break;
                    case 0:
                        Console.WriteLine("Encerrando...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            }
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}