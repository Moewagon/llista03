using System.Timers;

namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num, resNum;
            Console.WriteLine("Comprobador de parell o senar");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Introdueix un numero qualsevol");
            num=Convert.ToDouble(Console.ReadLine());
            resNum = num % 2;
            if (resNum == 0)
            {
                Console.WriteLine("El teu numero es parell");
            }
            else
            {
                Console.WriteLine("El teu numero es senar");
            }
        }
    }
}