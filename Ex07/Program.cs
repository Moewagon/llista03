namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int selec;
            double esp, eur;
            Console.WriteLine("Convertidor de Pessetes a Euros i Euros a Pessetes");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Quina operació vols fer:");
            Console.WriteLine("1.Pessetes a Euros");
            Console.WriteLine("2.Euros a Pessetes");
            selec = Convert.ToInt32(Console.ReadLine());
            if (selec == 1) {
                Console.WriteLine("Introdueix el numero de pessetes a convertir:");
                esp = Convert.ToDouble(Console.ReadLine());
                eur = esp/166.386;
                Console.WriteLine($"{esp} pessetes equivaleixen a {eur} euros.");
            }
            else if (selec == 2)
            {
                Console.WriteLine("Introdueix el numero de euros a convertir:");
                eur = Convert.ToDouble(Console.ReadLine());
                esp = eur * 166.386;
                Console.WriteLine($"{eur} euros equivaleixen a {esp} pessetes.");
            }
        }
    }
}