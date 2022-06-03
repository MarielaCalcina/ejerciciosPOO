using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Personas
    {
        //Atributos
        public string nombre;
        public int edad;
        private int DNI;


        //constructor
        public Personas(string nombre, int edad, int DNI)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.DNI = DNI;
        }

        public void Mostrar()
        {
            Console.WriteLine("Los datos de " + this.nombre + " son:");
            Console.WriteLine("Nombre: " + this.nombre);
            Console.WriteLine("Edad: " + this.edad);
            Console.WriteLine("DNI: "+ this.DNI);
        }

        public void esMayorDeEdad()
        {
            if(this.edad>= 18)
            {
                Console.WriteLine("La persona es mayor de edad");
            }
            else
            {
                Console.WriteLine("La persona no es mayor de edad");
            }
        }

    }   
}
