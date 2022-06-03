using System;
using System.Collections.Generic;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Personas Sofia = new Personas("Sofia", 12, 44556666);

            List<Personas> listaDePersonas = new List<Personas>();
            listaDePersonas.Add(Sofia);

            foreach (Personas datos in listaDePersonas)
            {
                datos.Mostrar();
                datos.esMayorDeEdad();
            }
        }

        
    }
}
