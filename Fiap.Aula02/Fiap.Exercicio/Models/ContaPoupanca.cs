using Fiap.Exercicio.Exceptions;

namespace Fiap.Exercicio.Models
{
    internal class ContaPoupanca : Conta, IContaInvestimento
    {
        public Decimal Taxa { get; set; }
        public ContaPoupanca(int agencia, int numero, IList<Cliente> clientes, Decimal taxa) : base(agencia, numero, clientes)
        {
            Taxa = taxa;
        }

        public decimal CalcularRetornoInvestimento() => Saldo *= (decimal)0.04;

        public override void Retirar(decimal valor)
        {
            if (Saldo < (valor + Taxa)) throw new SaldoInsuficienteException($"Valor disponível: {Saldo}");
            Saldo -= valor + Taxa;
        }
    }
}
