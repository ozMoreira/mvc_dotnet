namespace Fiap.Aula02.UI.Models
{
    //CTRL + SHIFT + B -> buildar o projeto
    //Classe abstrata: não pode ser instanciada e pode conter métodos abstratos
    internal abstract class Pessoa
    {
        //Propriedades
        public string Nome { get; set; }
        //prop -> tab tab
        public Genero Genero { get; set; }

        //Construtor com nome e genero
        //ctor -> tab tab
        public Pessoa(string nome, Genero genero)
        {
            Nome = nome;
            Genero = genero;
        }

        //Métodos
        //virtual -> permite a sobrescrita do método na classe filha
        public virtual void Falar()
        {
            Console.WriteLine("Pessoa falando...");
        }

        public abstract string ExibirDados();

        //Sobrescrever o ToString para exibir os dados do objeto
        public override string ToString()
        {
            return $"Nome: {Nome}, Gênero: {Genero}";
        }

    }//class

    public enum Genero
    {
        Feminino, Masculino, Outros
    }

}//namespace
