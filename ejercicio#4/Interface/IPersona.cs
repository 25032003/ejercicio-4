using ejercicio_4.Clase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_4.Interface
{
    internal interface IPersona

    {
        String Nombre { get; }
        int Edad { get; }

        void saludando();
        void CumplirAños();
    }
}