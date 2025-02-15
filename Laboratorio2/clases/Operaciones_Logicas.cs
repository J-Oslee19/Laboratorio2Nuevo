using System;

namespace Laboratorio_2
{
    public class OperacionesLogicas
    {
        public void operacionsLogicas()
        {
            Console.WriteLine("Ingrese el primer valor numérico:");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo valor numérico:");
            int valor2 = int.Parse(Console.ReadLine());

            // Comparaciones
            bool esMayor = valor1 > valor2;
            bool esMenor = valor1 < valor2;
            bool esIgual = valor1 == valor2;

            // Resultados de comparaciones
            Console.WriteLine($"¿El primer valor es mayor que el segundo? {esMayor}");
            Console.WriteLine($"¿El primer valor es menor que el segundo? {esMenor}");
            Console.WriteLine($"¿Ambos valores son iguales? {esIgual}");

            // Uso de AND (&&) y OR (||)
            bool andResultado = esMayor && esIgual;
            bool orResultado = esMayor || esIgual;

            // Resultados de expresiones lógicas
            Console.WriteLine($"Resultado de AND (&&) entre 'esMayor' y 'esIgual': {andResultado}");
            Console.WriteLine($"Resultado de OR (||) entre 'esMayor' y 'esIgual': {orResultado}");
        }

    }
}