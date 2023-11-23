using Entidades;
using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funeraria
{
    public class Heroe : Persona, ILogro<string>
    {
        string logro;
        public Heroe(string nombre, int edad, string dni) : base(nombre, edad, dni)
        {

        }

        public string Logro
        {
            get { return logro; }
            set { logro = AgregarLogro(value); }
        }


        public string AgregarLogro(string logro) 
        {
            List<string> lista = new List<string>();
            lista.Add(logro);
            return logro;
        }

        public override string MostrarPersona()
        {
            return base.ToString() + MostrarLogro();      
        }

        public string MostrarLogro()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in this.Logro)
            {
                sb.AppendLine(logro);
            }

            return sb.ToString();
        }

    }
}
