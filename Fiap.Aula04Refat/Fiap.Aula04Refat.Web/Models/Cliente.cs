using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Fiap.Aula04Refat.Web.Models
{
    public class Cliente
    {
        [HiddenInput]
        public int Codigo { get; set; }
        [Display(Name = "Nome Completo")]
        public String? NomeCompleto { get; set; }
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }
        [Display(Name = "Cliente Fidelizado?")]
        public Boolean Fidelizado { get; set; }
        [Display(Name = "Gênero")]
        public Genero Genero { get; set; }
        [Display(Name = "Formação")]
        public String? Formacao { get; set; }
    }

    public enum Genero
    {
        Feminino, Masculino, Outros
    }
}
