namespace Ex17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
            Console.WriteLine("Escriu el primer numero:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escriu el segon numero:");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escriu el tercer numero:");
            z = Convert.ToDouble(Console.ReadLine());

            if (x > y && x > z)
            {
                Console.WriteLine($"El numero mes gran es {x} ");
            }

            else if (y > x && y > z)
            {
                Console.WriteLine($"El numero mes gran es {y} ");
            }

            else if (z > x && z > y)
            {
                Console.WriteLine($"El numero mes gran es {z} ");
            }

            else 
            { 
                Console.WriteLine("Tots els numeros son iguals");
            }
        }
    }
}
/*Fes un programa que demani tres números introduïts per teclat i ens digui quin és el més
gran.*/