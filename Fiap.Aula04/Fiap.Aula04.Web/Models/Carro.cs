using System.ComponentModel.DataAnnotations;

namespace Fiap.Aula04.Web.Models
{
    public class Carro
    {
        public int IdCarro { get; set; }
        public String? Modelo { get; set; }
        public int Ano { get; set; }
        public Decimal Valor { get; set; }
        public String? Tipo { get; set; }
        public String? Marca { get; set; }
        [Display(Name = "Possui teto solar?")]
        public Boolean TetoSolar { get; set; }
        [Display(Name = "Combustível")]
        public Combustivel? Combustivel { get; set; }
    }

    public enum Combustivel
    {
        Etanol, Gasolina, Flex, Eletrico, Diesel
    }
}
