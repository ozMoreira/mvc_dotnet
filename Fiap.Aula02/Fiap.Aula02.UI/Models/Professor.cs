
namespace Fiap.Aula02.UI.Models
{
    internal class Professor : Pessoa
    {
        public string Especialidade { get; set; }
        public decimal ValorHora { get; set; }
        public int Horas { get; set; }

        //Construtor com nome, genero, valorhora e horas
        public Professor(string nome, Genero genero, 
                        decimal valorHora, int horas) : base(nome, genero)
        {
            ValorHora = valorHora;
            Horas = horas;
        }

        //Construtor com nome, genero, valorhora, horas e especialidade
        public Professor(string nome, Genero genero, decimal valorHora, 
                        int horas, string especialidade): base(nome, genero)
        {
            ValorHora = valorHora;
            Horas = horas;
            Especialidade = especialidade;
        }

        //Métodos
        //Sobrescrever o método Falar da Pessoa
        public override void Falar()
        {
            //base.Falar(); //Chama o método Falar da classe Pessoa
            Console.WriteLine("Professor dando aula..");
        }

        public override string ExibirDados()
        {
            return $"Nome: {Nome}, Especialidade: {Especialidade}";
        }

        public decimal CalcularSalario()
        {
            //Retorna o valor hora * as horas trabalhadas
            return ValorHora * Horas;
        }

        //Sobrecarga de método
        public decimal CalcularSalario(int horasExtras)
        {
            //Validar se a horasExtras é maior do zero
            if (horasExtras < 0)
                //Se for negativo, lançar a exception ArgumentException()
                throw new ArgumentException("Horas extras precisa ser maior do que 0");
            //Retorna o valor hora * (as horas trabalhadas + horas extras)
            return (Horas + horasExtras) * ValorHora; 
        }

        public override string ToString()
        {
            //base.ToString() -> chama o método ToString da classe Pessoa
            return base.ToString() + $", Valor Hora: {ValorHora}, Horas: {Horas}, Especialidade: {Especialidade}";
        }

    }
}