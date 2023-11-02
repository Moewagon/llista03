namespace Ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("Escriu un numero");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escriu el segon numero");
            b = Convert.ToDouble(Console.ReadLine());

            if (a<b)
            {
                Console.WriteLine($"{a},{b}");
            }
            else
            {
                c = b;
                b = a;
                a = c;
                Console.WriteLine($"{a},{b}");
            }
        }
    }
}
/*Fes un programa que demani dos números qualssevol i després els mostri en ordre creixent.
Demana a i b, i escriu a i b. Ha de permutar el valor de les variables si cal*/