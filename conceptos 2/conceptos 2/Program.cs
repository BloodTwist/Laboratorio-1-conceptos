using System;

namespace conceptos_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double res1 = 0, res2 = 0;
            Console.WriteLine("La ecuación debe ser de la forma ax^2+bx+c");

            Console.WriteLine("Digite a");
            var a = Console.ReadLine();
            var result1 = double.TryParse(a, out double salida1);

            Console.WriteLine("Digite b");
            var b = Console.ReadLine();
            var result2 = double.TryParse(b, out double salida2);

            Console.WriteLine("Digite c");
            var c = Console.ReadLine();
            var result3 = double.TryParse(c, out double salida3);

            double cua = salida2 * salida2;
            double ac = (4) * (salida1 * salida3);

            if ((result1 == true) && (result2 == true) && (result3 == true))
            {
                if ((cua > ac) && (salida1 > 0))
                {
                    res1 = -((salida2) + Math.Sqrt((cua) - 4 * (salida1 * salida3))) / (2 * (salida1));
                    res2 = -((salida2) - Math.Sqrt((cua) - 4 * (salida1 * salida3))) / (2 * (salida1));

                    Console.WriteLine("El resultado positivo es " + res1);
                    Console.WriteLine("El resultado Negativo es " + res2);
                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine("El resultado esta dentro del conjunto de los imaginarios o es indeterminado");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Alguna incognita no es un número");
                Console.ReadKey();
            }
        }
    }
}
