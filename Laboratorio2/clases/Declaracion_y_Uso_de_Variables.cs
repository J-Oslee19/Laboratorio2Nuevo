using System;

namespace Laboratorio_2
{
    public class Declaracion_y_Uso_de_Variables
    {
       public void declaracionVariables()
        {
            // Declaración de variables
            int numeroEntero;
            double numeroDecimal;
            string texto;
            bool valorBooleano;

            // Solicitar valores por teclado
            Console.Write("Ingrese un número entero: ");
            numeroEntero = int.Parse(Console.ReadLine());

            Console.Write("Ingrese un número decimal: ");
            numeroDecimal = double.Parse(Console.ReadLine());

            Console.Write("Ingrese un texto: ");
            texto = Console.ReadLine();

            Console.Write("Ingrese un valor verdadero o falso (true/false): ");
            valorBooleano = bool.Parse(Console.ReadLine());

            // Mostrar valores en consola
            Console.WriteLine("Número entero: " + numeroEntero);
            Console.WriteLine("Número decimal: " + numeroDecimal);
            Console.WriteLine("Texto: " + texto);
            Console.WriteLine("Valor verdadero o falso: " + valorBooleano);
        }


    }
}