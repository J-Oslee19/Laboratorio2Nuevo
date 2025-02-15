using System;

namespace Verificacion_Acceso
{
    class Program
    {
        static void Main(string[] args)
        {
            // Datos de ejemplo
            string usuarioCorrecto = "jeferson";
            string contrasenaCorrecta = "futbol";

            // Solicitar nombre de usuario y contraseña
            Console.Write("Ingrese su nombre de usuario: ");
            string usuarioIngresado = Console.ReadLine();

            Console.Write("Ingrese su contraseña: ");
            string contrasenaIngresada = Console.ReadLine();

            // Verificar acceso
            if (usuarioIngresado == usuarioCorrecto)
            {
                if (contrasenaIngresada == contrasenaCorrecta)
                {
                    Console.WriteLine("Acceso concedido");
                }
                else
                {
                    Console.WriteLine("Contraseña incorrecta");
                }
            }
            else
            {
                Console.WriteLine("Usuario no registrado");
            }
        }
    }
}