//ejemplos 4
using System;

namespace Ejercicio4_1
{
    class ejercicio
    {
        static void Main()
        {
            int i = 1;
            int suma = 0;
            while (i <= 10)
            {
                Console.WriteLine("Digite un numero ({0})", i);
                int datos = Convert.ToInt32(Console.ReadLine());
                suma = suma + datos;
                i++;
                Console.WriteLine("La suma actual de los numeros es: {0}", suma);
                Console.WriteLine();
            }
        }
    }
}
