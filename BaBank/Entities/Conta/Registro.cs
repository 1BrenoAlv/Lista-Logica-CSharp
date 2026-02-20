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

        public Registro(DateTime dataRegistro, decimal movimentacao)
        {
           DataRegistro = dataRegistro;
            Movimentacao = movimentacao;
        }
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

        void ExibirRegistro()
        {
            Console.WriteLine($"Data: {DataRegistro}, Movimentação: {Movimentacao}");
        }
    }
}
