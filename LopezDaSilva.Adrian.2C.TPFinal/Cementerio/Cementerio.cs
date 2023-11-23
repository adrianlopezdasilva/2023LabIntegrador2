using Funeraria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Collections;
using System.Runtime.CompilerServices;


namespace Entidades
{
    public class Cementerio
    {
        private List<Persona> personas;

        public  List<Persona> Personas
        {
            get { return personas; }
            set { personas = value; }
        }

        public Cementerio()
        {
            this.personas = new List<Persona>();

        }

        /// <summary>
        /// Agrega una persona al Cementerio solamente si esa persona no se encuentra en la lista
        /// </summary>
        /// <param name="cementerio"></param>
        /// <param name="persona"></param>
        /// <returns></returns>
        public static Cementerio operator +(Cementerio cementerio, Persona persona)
        {
            bool aux = true;
            foreach (Persona item in cementerio.Personas)
            {
                if (item ==  persona)
                {
                    aux = false;
                }
            }
            if (aux == true)
            {
                cementerio.personas.Add(persona);
            }

            return cementerio;
        }
    }
}
