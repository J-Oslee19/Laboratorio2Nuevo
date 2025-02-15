using System;

namespace Dia_De_La_Semana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número del 1 al 7:");
            int numero = int.Parse(Console.ReadLine());

            string dia = numero switch
            {
                1 => "Lunes",
                2 => "Martes",
                3 => "Miércoles",
                4 => "Jueves",
                5 => "Viernes",
                6 => "Sábado",
                7 => "Domingo",
                _ => "Número inválido"
            };

            Console.WriteLine($"El día correspondiente es: {dia}");
        }
    }
}