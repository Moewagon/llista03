namespace ex16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
            Console.WriteLine("Entra el primer numero");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entra el segon numero");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entra el tercer numero");
            z = Convert.ToDouble(Console.ReadLine());

            if (x <= y && y <= z) 
            {
                Console.WriteLine("Els numeros estan en ordre ascendent");
            }
            else if (x >= y && y >= z) 
            {
                Console.WriteLine("Els numeros estan en ordre descendent");
            }
            else
            {
                Console.WriteLine("Els numeros no estan ordenats");
            }
        }
    }
}
/*Fes un programa que demani tres números introduïts per teclat o digui si estan ordenats. (dos
nombres entrats consecutivament iguals considerarem que no trenquen l’ordre).*/