
using Fiap.Aula02.UI.Exceptions;

namespace Fiap.Aula02.UI.Models
{
    //Aluno herda de Pessoa e implementa IEstudante
    internal class Aluno : Pessoa, IEstudante
    {
        //Propriedades rm, curso, ano ingresso
        public int Rm { get; set; }
        public string Curso { get; set; }
        public int AnoIngresso { get; set; }

        //Criar o construtor do Aluno com nome, genero e rm
        public Aluno(string nome, Genero genero, int rm) : base(nome, genero)
        {
            Rm = rm;
        }

        //Métodos
        public override string ExibirDados()
        {
            return $"RM: {Rm}, Nome: {Nome}, Curso: {Curso}";
        }

        public void PagarBoleto(string codigoBarras)
        {
            Console.WriteLine($"Pagando boleto {codigoBarras}");
        }

        public void FazerProva(string disciplina)
        {
            //Valida se a disciplina é vazia ou nula 
            if (string.IsNullOrEmpty(disciplina))
                //Lançar a exception da disciplina
                throw new DisciplinaInvalidaException("Disciplina inválida");
            Console.WriteLine($"Fazendo a prova de {disciplina}");
        }
    }
}
