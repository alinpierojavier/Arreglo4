using System;

namespace Arreglo6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingresar por pantalla los nombres, apellidos, edad y sexo de cinco clientes, emplee los tipos de datos arreglos.
            string[] nombre = new string[5];
            string[] apellido = new string[5];
            string[] sexo = new string[5];
            int[] edad = new int[5];

            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine("Ingrese nombre del estudiante " + i);
                nombre[i] = Console.ReadLine();
                Console.WriteLine("Ingrese su apellido");
                apellido[i] = Console.ReadLine();
                Console.WriteLine("Ingrese sexo del estudiante ");
                sexo[i] = Console.ReadLine();
                Console.WriteLine("Ingresar su edad ");
                edad[i] =Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
