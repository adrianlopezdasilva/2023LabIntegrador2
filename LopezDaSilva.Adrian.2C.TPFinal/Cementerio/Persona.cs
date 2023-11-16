namespace Cementerio
{
    public abstract class Persona
    {
		protected string nombre;
        protected int edad;

		public int Edad
		{
			get { return edad; }

		}

		public string Nombre
		{
			get { return nombre; }
		}

		public Persona (string nombre, int edad)
		{
			this.nombre = nombre;
			this.edad = edad;
		}
	}
}