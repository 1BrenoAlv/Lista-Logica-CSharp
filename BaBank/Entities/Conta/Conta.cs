using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaBank.Entities.Conta
{
     class Conta
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int NumeroConta { get; set; }
        public string Titular { get; set; } 
        public decimal Saldo { get; set; }
        List<Registro> Registros { get; set; }
        private static int _contadorId = 0;
        public Conta(string nome, string sobrenome, int numeroConta, decimal saldo, List<Registro> registros)
        {
            Id = Interlocked.Increment(ref _contadorId);
            Nome = nome;
            Sobrenome = sobrenome;
            NumeroConta = numeroConta;
            Titular = $"{Nome} {Sobrenome}"; 
            Saldo = saldo;
            Registros = registros;
        }
        public Conta() { }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
            Registro registro = new Registro();
            registro.RegistrarMovimentacaoDeposito(valor);
            Registros.Add(registro);
        }
        public void Sacar(decimal valor)
        {
            Saldo -= valor;
            Registro registro = new Registro();
            registro.RegistrarMovimentacaoSaque(valor);
            Registros.Add(registro);
        }

        public void Pix(decimal valor, string? pix)
        {
            Saldo -= valor;
            Registro registro = new Registro();
            registro.RegistrarMovimentacaoPix(valor, pix);
            Registros.Add(registro);
        }

        public void ExibirSaldo()
            {
                Console.WriteLine($"Saldo atual: R${Saldo}");
        }

        public void ExibirExtrato()
        {
            Console.WriteLine("Extrato:");
            foreach (var reg in Registros)
            {
                reg.ExibirRegistro();
            }
            Console.WriteLine($"Total em conta: R${Saldo}");
        }

        public override string ToString()
        {
            return $"ID: {Id}\nTitular: {Titular}\n" +
                $"Conta: {NumeroConta}\n";
               
        }

    }
}
