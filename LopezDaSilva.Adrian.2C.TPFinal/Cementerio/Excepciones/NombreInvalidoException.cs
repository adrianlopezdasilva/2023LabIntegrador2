using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class NombreInvalidoException : Exception
    {
        public NombreInvalidoException(string? message) : base("Nombre invalido")
        {
        }

        public NombreInvalidoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
