//aqui tenes que colocar el llamado de las clases que creaste
using System;
using Laboratorio_2;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // ahora llama asi como este a las demas clases y ya 
            Declaracion_y_Uso_de_Variables declaracionVariables = new Declaracion_y_Uso_de_Variables();
            declaracionVariables.declaracionVariables();

            OperacionesLogicas operacionesLogicas = new OperacionesLogicas();
            operacionesLogicas.operacionsLogicas();

            Operaciones_Matematicas operacionesMatematicas = new Operaciones_Matematicas();
            operacionesMatematicas.operacionesMatematicas();
        }
    }
}