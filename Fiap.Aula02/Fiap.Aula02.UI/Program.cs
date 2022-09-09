//CTRL + L -> apaga a linha
using Fiap.Aula02.UI.Exceptions;
using Fiap.Aula02.UI.Models;

//Instanciar um aluno
Aluno aluno = new Aluno("Emily", Genero.Feminino, 89545)
{
    Curso = "TDS",
    AnoIngresso = 2021
};

//Instanciar um professor
Professor parducci = new Professor("Renato", Genero.Masculino, 150, 40);

Professor kazuo = new Professor(genero: Genero.Masculino, horas: 20,
                valorHora: 100, nome: "Marcelo", especialidade: "Mobile");


//Chamar o método exibir dados do professor e do aluno
Console.WriteLine(aluno.ExibirDados());
Console.WriteLine(kazuo.ExibirDados());

//Chamar o método falar do professor e do aluno
aluno.Falar(); //Método da classe Pessoa
parducci.Falar(); //Método da classe Professor

Pessoa menk = new Professor("Menk", Genero.Masculino, 1000, 40);
menk.Falar(); //Método da classe Professor

//kazuo.Especialidade = "Android";
//kazuo.CalcularSalario();
//((Professor)menk).Especialidade = "Cloud";
//((Professor)menk).CalcularSalario();

//Sobrescrever o método ToString para exibir os dados do objeto
Console.WriteLine(menk);
Console.WriteLine(kazuo);
Console.WriteLine(parducci);

//Criar uma lista de Professor
IList<Professor> professores = new List<Professor>();

//Adicionar alguns professores do curso
professores.Add((Professor)menk); //cast para forçar o objeto na variável menk ser do tipo Professor
professores.Add(kazuo);
professores.Add(parducci);
professores.Add(new Professor("Hellynson", Genero.Masculino, 100, 12));

//Exibir a quantidade de professores na lista
Console.WriteLine($"Quantidade de professores na lista: {professores.Count}");

//Exibir os dados dos professores
foreach (var item in professores)
{
    Console.WriteLine(item.ExibirDados());
}

//Tratar a exception 
try
{
    //Calcular o salário parducci com -10 horas extras e exibir o resultado
    Console.WriteLine(parducci.CalcularSalario(-10));
}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
}

try
{
    //Colocar o aluno para fazer a prova
    aluno.FazerProva("");
}
catch (DisciplinaInvalidaException e)
{
    Console.WriteLine(e.Message);
}