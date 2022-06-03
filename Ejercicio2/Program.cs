using System;
using System.Collections.Generic;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Cuenta Sofia = new Cuenta("Sofia", 4000);
            Cuenta bam = new Cuenta("bam", 1000);

            List<Cuenta> listaDeCuentas = new List<Cuenta>();
            listaDeCuentas.Add(Sofia);
            listaDeCuentas.Add(bam);

            foreach (Cuenta datos in listaDeCuentas)
            {
                datos.Mostrar();

                Console.WriteLine("desea ingresar?");
                string respuesta = Console.ReadLine();
                if(respuesta == "si")
                {
                    Console.WriteLine("ingrese el importe qdesea entregar");
                    int nuevaCantidad = Convert.ToInt32(Console.ReadLine());
                    datos.ingresar(nuevaCantidad);
                }

                Console.WriteLine("desea retirar?");
                string respuestaRetiro = Console.ReadLine();
                if(respuestaRetiro== "si")
                {
                    Console.WriteLine("ingrese el importe qdesea retirar");
                    int cantidadRetirar = Convert.ToInt32(Console.ReadLine());
                    datos.retirar(cantidadRetirar);
                }
                

            }


        }
    }
    
}
