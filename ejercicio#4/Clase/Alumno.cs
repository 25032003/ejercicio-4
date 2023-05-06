using ejercicio_4.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_4.Clase
{
    internal class Alumno : IPersona

    {
        public string Nombre { get; }

        public int Edad { get; }

        public void CumplirAños()
        {
            Console.WriteLine($"Ya va hacer tu cumpleaños tu edad es {Edad}");
        }

        public void saludando()
        {
            Console.WriteLine($"Hola como estas {Nombre}  todo bien?");
        }

        public Alumno(int edad, string nombre)
        {
            Nombre = nombre;
            Edad = edad;
        }

    }
}

