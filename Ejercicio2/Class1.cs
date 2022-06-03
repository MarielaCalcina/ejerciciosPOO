using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Cuenta
    {
        //atributos
        public string nombre;
        public int cantidad;
        private int dineroEnCuenta;

        //constructor
        public Cuenta(string nombre, int cantidad)
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
        }

        public void Mostrar()
        {
            Console.WriteLine("Los datos de " + this.nombre + " son:");
            Console.WriteLine("Nombre: " + this.nombre);
            if(cantidad == 0 || cantidad < 0)
            {

            }
            else
            {
                Console.WriteLine("Cantidad de dinero en cuenta : " + this.cantidad);
            }  
        }

        public void ingresar(int nuevaCantidad)
        {
            if (nuevaCantidad == 0 || nuevaCantidad < 0)
            {
                Console.WriteLine("El disponible en la cuenta es " + this.cantidad);
            }
            else
            {
                this.dineroEnCuenta = nuevaCantidad + this.cantidad;
                //int totalcuenta = dineroEnCuenta + this.cantidad;
                Console.WriteLine("El nuevo saldo disponible en la cuenta es " + dineroEnCuenta);
            }
        }

        public void retirar(int cantidadRetirar)
        {
            this.dineroEnCuenta = dineroEnCuenta - cantidadRetirar;
            Console.WriteLine("El nuevo saldo es " + dineroEnCuenta);
        }
    }
}
