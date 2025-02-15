using System;

namespace Laboratorio_2
{
    public class Operaciones_Matematicas
    {
        public void operacionesMatematicas()
        {
            // Variables int
            Console.WriteLine("Ingrese el primer número (int):");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número (int):");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Suma (int): {num1 + num2}");
            Console.WriteLine($"Resta (int): {num1 - num2}");
            Console.WriteLine($"Multiplicación (int): {num1 * num2}");
            Console.WriteLine($"División (int): {(num2 != 0 ? (num1 / num2).ToString() : "No se puede dividir por cero")}");

            // Variables decimal
            Console.WriteLine("Ingrese el primer número (decimal):");
            decimal dec1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número (decimal):");
            decimal dec2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Suma (decimal): {dec1 + dec2}");
            Console.WriteLine($"Resta (decimal): {dec1 - dec2}");
            Console.WriteLine($"Multiplicación (decimal): {dec1 * dec2}");
            Console.WriteLine($"División (decimal): {(dec2 != 0 ? (dec1 / dec2).ToString() : "No se puede dividir por cero")}");

            // Variables float
            Console.WriteLine("Ingrese el primer número (float):");
            float float1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número (float):");
            float float2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"Suma (float): {float1 + float2}");
            Console.WriteLine($"Resta (float): {float1 - float2}");
            Console.WriteLine($"Multiplicación (float): {float1 * float2}");
            Console.WriteLine($"División (float): {(float2 != 0 ? (float1 / float2).ToString() : "No se puede dividir por cero")}");

            // Variables Int16
            Console.WriteLine("Ingrese el primer número (Int16):");
            Int16 int16_1 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número (Int16):");
            Int16 int16_2 = Int16.Parse(Console.ReadLine());

            Console.WriteLine($"Suma (Int16): {int16_1 + int16_2}");
            Console.WriteLine($"Resta (Int16): {int16_1 - int16_2}");
            Console.WriteLine($"Multiplicación (Int16): {int16_1 * int16_2}");
            Console.WriteLine($"División (Int16): {(int16_2 != 0 ? (int16_1 / int16_2).ToString() : "No se puede dividir por cero")}");

            // Variables byte
            Console.WriteLine("Ingrese el primer número (byte):");
            byte byte1 = byte.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número (byte):");
            byte byte2 = byte.Parse(Console.ReadLine());

            Console.WriteLine($"Suma (byte): {byte1 + byte2}");
            Console.WriteLine($"Resta (byte): {byte1 - byte2}");
            Console.WriteLine($"Multiplicación (byte): {byte1 * byte2}");
            Console.WriteLine($"División (byte): {(byte2 != 0 ? (byte1 / byte2).ToString() : "No se puede dividir por cero")}");
        }
    }
}