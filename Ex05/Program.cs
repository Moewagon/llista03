using System;

namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.WriteLine("Comprobador d'ordre creixent");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Introdueix un numero qualsevol");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introdueix un numero qualsevol de nou");
            num2 = Convert.ToDouble(Console.ReadLine());
            if (num1 < num2) {
                Console.WriteLine("Els numeros estan escrits en ordre ascendent");
            }
            else
            {
                Console.WriteLine("Els numeros no estan en ordre ascendent");
            }
        }
    }
}