using Entidades;
using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funeraria
{
    public class Heroe : Persona, ITesoro<string>
    {
        string tesoro;
        public Heroe(string nombre, int edad, string dni) : base(nombre, edad, dni)
        {
        }

        public string Tesoro { get; set; }


        public void AgregarTesoro(string tesoro) 
        {
            List<string> lista = new List<string>
            {
                tesoro
            };
        }
        public string MostrarTesoro(string tesoro)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in tesoro)
            {
                sb.AppendLine(tesoro);
            }

            return sb.ToString();
        }

    }
}
