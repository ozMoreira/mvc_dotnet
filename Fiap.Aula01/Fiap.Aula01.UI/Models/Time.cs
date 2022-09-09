using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula01.UI.Models
{
    public class Time
    {
        //Atributos (Campos/Fields)
        private string _formacao;
        private int _titulos;

        //Propriedade
        public string Nome { get; set; }
        public bool Mundial { get; set; }

        //Propriedade para o titulos
        public int Titulos
        {
            get { return _titulos; }
            set { _titulos = value; }
        }

        public string Formacao
        {
            get { return _formacao;  }
            set { _formacao = value; }
        }
    }
}
