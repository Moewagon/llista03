using System.Runtime.ConstrainedExecution;

namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //. Fes un programa que calculi les solucions d’una equació de segon grau i que no falli mai.
            //No es poden fer arrels de valors negatius ni divisions per 0.
            {
                Console.WriteLine("Introdueix els coeficients de l'equació de segon grau (ax^2 + bx + c = 0):");

                Console.Write("a = ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.Write("b = ");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.Write("c = ");
                double c = Convert.ToDouble(Console.ReadLine());

                double discriminant = b * b - 4 * a * c;

                if (discriminant > 0)
                {
                    double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                    Console.WriteLine("Les solucions de l'equació són: x1 = " + x1 + " i x2 = " + x2);
                }
                else if (discriminant == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine("L'equació té una única solució: x = " + x);
                }
                else
                {
                    Console.WriteLine("L'equació no té solucions reals.");
                }
            }
        }


    }
}
