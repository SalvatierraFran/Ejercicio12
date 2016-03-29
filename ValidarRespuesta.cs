using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio12
{
    class ValidarRespuesta
    {
        public static void ValidaS_N(char letra)
        {
            while (letra != 's' && letra != 'n')
            {
                Console.Write("Error. Reingrese: ");
                letra = char.Parse(Console.ReadLine());
            }
        }

        public static bool NO(char letra)
        {
            if (letra == 's')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
