class Program
{
    static void Main(string[] args)
    {
        string menu = "1 - Criar conta\n2 - Depositar\n3 - Sacar\n4 - Ver saldo\n5 - Extrato\n0 - Encerrar";
        bool laco = true;
        while (laco)
        {
            Console.WriteLine(menu);
            int escolha = int.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Criar conta");
                    break;
                case 2:
                    Console.WriteLine("Depositar");
                    break;
                case 3:
                    Console.WriteLine("Sacar");
                    break;
                case 4:
                    Console.WriteLine("Ver saldo");
                    break;
                case 5:
                    Console.WriteLine("Extrato");
                    break;
                case 0:
                    Console.WriteLine("Encerrando...");
                    laco = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
        ;
    }
}