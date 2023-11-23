using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class EdadInvalidaException : Exception
    {
        public EdadInvalidaException(string message) : base("Edad invalida") { }

        public EdadInvalidaException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
