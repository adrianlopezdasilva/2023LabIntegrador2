using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    public interface ITesoro <T>
    {
        public void AgregarTesoro(T tesoro);
        public string MostrarTesoro(T tesoro);


    }
}
