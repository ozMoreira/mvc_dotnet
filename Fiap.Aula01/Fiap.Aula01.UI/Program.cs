// See https://aka.ms/new-console-template for more information
using Fiap.Aula01.UI.Models;

Console.WriteLine("Hello, World!");

//Instanciar um Time
//CTRL + . ou ALT + Enter
Time palmeiras = new Time();
//Atribuir uma formação pro time
palmeiras.Formacao = "4-2-3-1";
//Exibir a formação do time
Console.WriteLine(palmeiras.Formacao);