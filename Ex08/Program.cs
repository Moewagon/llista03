using System.Timers;

namespace Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int selec;
            double var1, var2, resOp;
            
            Console.WriteLine("Calculadora");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Quina operació vols fer:");
            Console.WriteLine("1.Suma");
            Console.WriteLine("2.Resta");
            Console.WriteLine("3.Multiplicació");
            Console.WriteLine("4.Divisio");
            selec = Convert.ToInt32(Console.ReadLine());

            if (selec == 1) 
            {
                Console.WriteLine("Introdueix el primer valor de la suma:");
                var1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Introdueix el segon valor de la suma:");
                var2 = Convert.ToDouble(Console.ReadLine());
                resOp = var1 + var2;
                Console.WriteLine($"El resultat de {var1}+{var2} es {resOp}");
            }
            else if (selec == 2)
            {
                Console.WriteLine("Introdueix el primer valor de la resta:");
                var1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Introdueix el segon valor de la resta:");
                var2 = Convert.ToDouble(Console.ReadLine());
                resOp = var1 - var2;
                Console.WriteLine($"El resultat de {var1}-{var2} es {resOp}");
            }
            else if (selec == 3)
            {
                Console.WriteLine("Introdueix el primer valor de la multiplicació:");
                var1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Introdueix el segon valor de la multiplicació:");
                var2 = Convert.ToDouble(Console.ReadLine());
                resOp = var1 * var2;
                Console.WriteLine($"El resultat de {var1}*{var2} es {resOp}");
            }
            else if (selec == 4)
            {
                Console.WriteLine("Introdueix el primer valor de la divisió:");
                var1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Introdueix el segon valor de la divisió:");
                var2 = Convert.ToDouble(Console.ReadLine());
                resOp = var1 / var2;
                Console.WriteLine($"El resultat de {var1}/{var2} es {resOp}");
            }
            else
            {
                Console.WriteLine("Si us plau, selecciona un valor valid");
            }
        }
    }
}