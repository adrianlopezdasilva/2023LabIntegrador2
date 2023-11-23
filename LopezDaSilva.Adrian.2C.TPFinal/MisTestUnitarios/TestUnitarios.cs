using Entidades;
using Entidades.Excepciones;
using Funeraria;
namespace MisTestUnitarios
{
    [TestClass]
    public class TestUnitarios
    {
        [TestMethod]
        [ExpectedException (typeof (EdadInvalidaException))]
        public void Test_Validar_EDAD()
        {
           //Arrange
            int edad = -1;
           //Act
            Persona persona = new Persona("John", edad, "39328492");
            Cementerio cementerio = new Cementerio();
            cementerio = cementerio + persona;
        }

        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void Test_Validar_DNI()
        {
            //Arrange
            string dni = "3666";
            //Act
            Persona persona = new Persona("John", 18, dni);
            Cementerio cementerio = new Cementerio();
            cementerio = cementerio + persona;
        }
    }
}