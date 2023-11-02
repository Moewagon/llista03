namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.WriteLine("Comprobador d'ordre");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Introdueix un numero qualsevol");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introdueix un numero qualsevol de nou");
            num2 = Convert.ToDouble(Console.ReadLine());
            if (num1 < num2)
            {
                Console.WriteLine("Els numeros estan escrits en ordre ascendent");
            }
            else if (num2 < num1) 
            {
                Console.WriteLine("Els numeros estan escrits en ordre descendent");
            }
            else
            {
                Console.WriteLine("Els numeros son iguals");
            }
        }
    }
}