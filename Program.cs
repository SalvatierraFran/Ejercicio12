using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 12";

            int numero, suma = 0;
            char rta = 's';

            do
            {
                Console.Write("Ingrese numero: ");
                numero = int.Parse(Console.ReadLine());

                suma = suma + numero;

                Console.Write("\n¿Continua? S/N: ");
                rta = char.Parse(Console.ReadLine());
                ValidarRespuesta.ValidaS_N(rta);
                ValidarRespuesta.NO(rta);

            }while(rta == 's');

            Console.Write("\nEl resultado de la suma es: " + suma);

            Console.ReadKey();
        }
    }
}
