using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula02.UI.Exceptions
{

    [Serializable]
    public class DisciplinaInvalidaException : Exception
    {
        public DisciplinaInvalidaException() { }
        public DisciplinaInvalidaException(string message) : base(message) { }
        public DisciplinaInvalidaException(string message, Exception inner) : base(message, inner) { }
        protected DisciplinaInvalidaException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
   
}
