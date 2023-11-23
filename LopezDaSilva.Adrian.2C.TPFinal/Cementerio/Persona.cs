using Entidades;
using Entidades.Excepciones;
using System.Text;

namespace Funeraria
{
    public class Persona
    {
        protected string nombre;
        protected int edad;
        protected string dni;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Edad
		{
			get { return edad; }
            set { edad = value; }
		}

        public string Dni
        {
            get { return dni; }
            set { Dni = value; }
        }
        public Persona (string nombre, int edad, string dni)
		{
			this.nombre = ValidarNombre(nombre);
			this.edad = ValidarEdad(edad);
            this.dni = ValidarDni(dni);
		}

        public virtual string MostrarPersona()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + this.nombre);
            sb.AppendLine("Edad: " + this.edad.ToString());
            sb.AppendLine("DNI: " + this.dni);

            return sb.ToString();
        }

        public int ValidarEdad(int edad)
        {
             if (edad >= 0 && edad <= 100)
             {
                return edad;
             }
             else
             {
                throw new EdadInvalidaException(message: "No es una edad valida");
            }

        }

        public string ValidarDni(string dni)
        {
            if (!string.IsNullOrEmpty(dni) && dni.Length == 8)
            {
                return dni;
            }
            else
            {
                throw new DniInvalidoException(message: "El Dni no es valido");
            }
        }

        public string ValidarNombre(string nombre)
        {
            if (!string.IsNullOrEmpty(nombre))
            {
                return nombre;
            }
            else
            {
                throw new NombreInvalidoException(message: "El nombre no es valido");
            }
        }


        public override string ToString()
        {
            return MostrarPersona();
        }

        /// <summary>
        /// Dos personas son iguales si tienen el mismo DNI
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==(Persona p1, Persona p2)
        {
            return p1.dni == p2.dni;
        }

        /// <summary>
        /// Dos personas son distintas si tienen un DNI distinto
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=(Persona p1, Persona p2)
        {
            return !(p1 == p2);
        }

        /// <summary>
        /// Verifica que el dni ingresado corresponda a una persona de la lista
        /// </summary>
        /// <param name="listaPersonas"></param>
        /// <param name="dni"></param>
        /// <returns></returns>
        public static Persona BuscarPersonaPorDni(List<Persona> listaPersonas, string dni)
        {
            if (dni != null)
            {
                foreach (Persona item in listaPersonas)
                {
                    if (item.dni == dni)
                    {
                        return item;
                    }
                }
            }
            return null;
        }



    }
}