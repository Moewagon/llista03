namespace EX01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fes un programa en c# que calculi la solució de l’equació de primer grau. ax+b=0 . Ha
            //de controlar quan la a és zero.
            double x, a, b;
            Console.WriteLine("Escribe un numero");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe otro numero");
            b = Convert.ToDouble(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("Que dise bobo no me pongas 0");
            }
            else
            {
                x = -b / a;
                Console.WriteLine($"El resultado de ax+b=0 vale {x}");
            }
        }
    }
}