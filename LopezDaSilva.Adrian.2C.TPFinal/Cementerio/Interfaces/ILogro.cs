using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    public interface ILogro <T>
    {
        
        public string AgregarLogro(T logro);
        public string MostrarLogro();


    }
}
