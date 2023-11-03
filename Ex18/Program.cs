namespace Ex18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota;
            Console.WriteLine("Escriu la teva nota del 0 al 10");
            nota = Convert.ToDouble(Console.ReadLine());

            if (nota >= 0 && nota < 5)
            {
                Console.WriteLine("Suspès");
            }
            else if (nota >= 5 && nota < 8) 
            {
                Console.WriteLine("Aprovat");
            }
            else if (nota >= 8 && nota < 9) 
            {
                Console.WriteLine("Excel.lent");
            }
            else if (nota >= 9 && nota <= 10)
            {
                Console.WriteLine("Matrícula d'honor");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
/* Fes un programa que a partir d’ una nota numèrica entera entre 0 i 10 indiqui si correspon a:
[0 .. 4]→suspès
[5 .. 8]→aprovat
9→excel.lent
10→MATRÍCULA D’ HONOR
altrament: error */