namespace Ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double year;
            bool trasp;
            Console.WriteLine("Escriu un any en format AAAA");
            year = Convert.ToDouble(Console.ReadLine());
            trasp = (year % 4 == 0) && ((year % 100 != 0) || (year % 400 == 0));

            if (trasp)
            {
                Console.WriteLine("Es any de traspàs");
            }
            else
            {
                Console.WriteLine("No es any de traspàs");
            }
        }
    }
}

/* Fes un programa que digui si un any és de traspàs o no. Ho serà quan sigui múltiple de 4,
com el 2020. Compte, els múltiples de 100 no són tots de traspàs, només aquells que són
múltiples de 400 com el 2000 (1900 no va ser de traspàs)*/