using Entidades;
using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funeraria
{
    public class Heroe : Persona, ILogro
    {
        public Heroe(string nombre, int edad, string dni) : base(nombre, edad, dni)
        {

        }

        public string Logro { get; set; }

        public string MostrarLogros()
        {
            StringBuilder sb = new StringBuilder();
            base.MostrarPersona();
            sb.AppendLine("Logro: " + this.dni);

            return sb.ToString();
        }

        public override string MostrarPersona()
        {
            return MostrarLogros();
        }

    }
}
