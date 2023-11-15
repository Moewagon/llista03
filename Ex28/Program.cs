namespace Ex28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dni;
            char lletra;
            string lletres = "TRWAGMYFPDXBNJZSQVHLCKE";

            
            Console.WriteLine("Posa un numero de DNI (8 digits sense lletra)");
            dni = Convert.ToInt32(Console.ReadLine());

            if (dni < 100000000 && dni >= 10000000)
            {
                /*Amb els [] es troba el index de lletres (es a dir, agafa el numero resultat de dni%23 i agafa el numero de la posicio resultan al string lletres)*/
                lletra = lletres[dni % 23];
                Console.WriteLine($"El DNI final es {dni}{lletra}");
            }
            else
            {
                Console.WriteLine("No has entrat un numero valid");
            }
        }
    }
}