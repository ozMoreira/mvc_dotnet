
namespace Fiap.Exercicio.Models
{
    internal abstract class Conta
    {
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public decimal Saldo { get; protected set; }
        public DateTime DataAbertura { get; set; }
        public IList<Cliente> Clientes { get; set; }

        public Conta(int agencia, int numero, IList<Cliente> clientes)
        {
            Agencia = agencia;
            Numero = numero;
            Clientes = clientes;
        }

        public void Depositar(decimal valor) => Saldo += valor;

        public abstract void Retirar(decimal valor);

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
