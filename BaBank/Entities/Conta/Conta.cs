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

        public Conta(int id, string nome, string sobrenome, int numeroConta, string titular, decimal saldo, List<Registro> registros)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = saldo;
            Registros = registros;
        }

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
        
    }
}
