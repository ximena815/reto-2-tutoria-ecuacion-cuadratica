using System;

namespace Reto_2_tutoria_ecuacion_cuadratica
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entradas
            Console.WriteLine("Calcula tu ecuacion cuadratica ;3");
            Console.WriteLine("ax^2+bx+c=0");

            Console.WriteLine("Introdusca a: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Introdusca b: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Introdusca c: ");
            double c = double.Parse(Console.ReadLine());

            //procedimiento
            double bal2 = Math.Pow(b, 2);
            double discriminante = bal2 - (4*a*c);
            Console.WriteLine("discriminante: " + discriminante);
            //condicionales

           if (discriminante == 0)
            {
                double x = (-b) / (2 * a);
                Console.WriteLine("La solucion existe y es unica");
                Console.WriteLine("x: " + x);
            }
            else if (discriminante > 0)
            {
                Console.WriteLine("Existen dos soluciones correctas");
                double raiz = Math.Sqrt(discriminante);
                //x1
                double x1 = (-b + raiz) / (2 * a);
                Console.WriteLine("x1: " + x1);
                //x2
                double x2 = ((-b) - (raiz)) / (2 * a);
                Console.WriteLine("x2: " + x2);
            }
            else if ( discriminante < 0)
            {
                Console.WriteLine("no tiene solucion -u-r");
            }

        }
    }
}
