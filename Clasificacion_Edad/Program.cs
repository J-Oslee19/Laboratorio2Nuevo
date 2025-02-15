using System;

namespace ClasificacionEdad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad < 12)
            {
                Console.WriteLine("Niño");
            }
            else if (edad >= 12 && edad <= 17)
            {
                Console.WriteLine("Adolescente");
            }
            else if (edad >= 18 && edad <= 59)
            {
                Console.WriteLine("Adulto");
            }
            else if (edad >= 60)
            {
                Console.WriteLine("Adulto mayor");
            }
            else
            {
                Console.WriteLine("Edad no válida");
            }
        }
    }
}