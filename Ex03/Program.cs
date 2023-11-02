using System.Timers;

namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num;

            Console.WriteLine("Escriu un numero qualsevol. (positiu o negatiu)");
            num = Convert.ToDouble(Console.ReadLine());
            if (num < 0){
                num = num * (-1);
                Console.WriteLine($"El valor absolut del teu numero es {num}.");
            }
            else
            {
                Console.WriteLine($"El valor absolut del teu numero es {num}.");
            }
        }
    }
}