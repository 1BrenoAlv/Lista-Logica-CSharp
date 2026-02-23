using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaBank.Entities.Conta
{
    class Registro
    {
        public DateTime DataRegistro { get; set; }
        public decimal Movimentacao { get; set; }
        public string? Pix { get; set; }

        public Registro() { }
        public void RegistrarMovimentacaoDeposito(decimal valor)
        {
            Movimentacao += valor;
            DataRegistro = DateTime.Now;
        }

        public void RegistrarMovimentacaoSaque(decimal valor)
        {
            Movimentacao -= valor;
            DataRegistro = DateTime.Now;
        }

        public void RegistrarMovimentacaoPix(decimal valor, string? pix)
        {
            Movimentacao -= valor;
            Pix = pix;
            DataRegistro = DateTime.Now;
        }

        public void ExibirRegistro()
        {
            if (Pix != null)
            {
                Console.WriteLine($"---------------------------" +
                $"\nData: {DataRegistro}\n" +
                $"Movimentação: R${Movimentacao}\n" +
                $"Transação: {Pix}\n" +
                $"---------------------------");
            }
            Console.WriteLine($"---------------------------" +
                $"\nData: {DataRegistro}\n" +
                $"Movimentação: R${Movimentacao}\n" +
                $"---------------------------");
        }
    }
}
