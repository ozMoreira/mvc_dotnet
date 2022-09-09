using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula02.UI.Models
{
    internal interface IEstudante
    {
        void PagarBoleto(string codigoBarras);
        void FazerProva(string disciplina);
    }
}
