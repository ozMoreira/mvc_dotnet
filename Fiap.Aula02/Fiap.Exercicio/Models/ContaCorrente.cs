using Fiap.Exercicio.Exceptions;

namespace Fiap.Exercicio.Models
{
    internal class ContaCorrente : Conta
    {
        public ContaCorrente(int agencia, int numero, IList<Cliente> clientes, TipoConta tipo)
                                                                : base(agencia, numero, clientes)
        {
            Tipo = tipo;
            //Definir o limite da conta
            if (tipo == TipoConta.Especial)
                Limite = 500;
            else if (tipo == TipoConta.Premium)
                Limite = 1000;
            //Limite = (tipo == TipoConta.Especial ? 500 : (tipo == TipoConta.Premium ? 1000 : 0));
        }

        public TipoConta Tipo { get; set; }
        public decimal Limite { get; set; }

        public override void Retirar(decimal valor)
        {
            if (Saldo + Limite < valor)
            {
                throw new SaldoInsuficienteException($"Valor disponível: {Saldo + Limite}");
            }
            Saldo -= valor;
        }

        public override string? ToString()
        {
            return $"Agencia: {base.Agencia}\n" +
                $"Conta: {base.Numero}\n" +
                $"Tipo de Conta: {Tipo}\n" +
                $"Limite: {Limite}"

                ;
        }
    }//class

    public enum TipoConta
    {
        Comum, Especial, Premium
    }

}//namespace
