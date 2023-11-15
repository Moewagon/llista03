namespace Ex24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dig1, dig2, dig3;

            Console.WriteLine("Entra un numero de fins a tres xifres");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero >=100 && numero <= 999)
            {
                dig1 = numero / 100;
                dig3 = numero % 10;
                if (dig1 == dig3)
                {
                    Console.WriteLine("El teu numero es capicua");
                }
                else
                {
                    Console.WriteLine("El teu numero no es capicua");
                }
            }
            else if (numero >= 10 && numero <= 99)
            {
                dig1 = numero % 10;
                dig2= numero / 10;
                if (dig1 == dig2)
                {
                    Console.WriteLine("El teu numero es capicua");
                }
                else
                {
                    Console.WriteLine("El teu numero no es capicua");
                }
            }
            else if (numero >=0 && numero <= 9)
            {
                Console.WriteLine("El teu numero es capicua");
            }
            else
            {
                Console.WriteLine("No has entrat un numero valid");
            }
        }
    }
}
/*. Fes un programa que donat un nombre de fins a 3 xifres (té 1, 2 ó 3 xifres), digui si és cap-icua.*/