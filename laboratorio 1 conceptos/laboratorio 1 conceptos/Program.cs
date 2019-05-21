using System;

namespace laboratorio_1_conceptos
{
    class Program
    {
        static void Main(string[] args)
        {
            int salida;

            Console.WriteLine("ingrese su edad");
            var edad = Console.ReadLine();
            var result = int.TryParse(edad, out salida);

            if (result == true)
            {
                
                Console.WriteLine("Su edad es " + edad);
                salida = int.Parse(edad);

            }
            else
            {
                Console.WriteLine("El valor se puede convertir");

            }
            Console.ReadKey();
        }
    }
}
