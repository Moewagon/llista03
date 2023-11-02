namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fes un programa que demani una lletra i digui si és majúscula, minúscula o no és lletra.
            char caracter;

            Console.WriteLine("Entra un caracter qualsevol:");
            caracter = Console.ReadKey().KeyChar;

            if (char.IsLetter(caracter))
            {
                if (char.IsUpper(caracter))
                {
                    Console.WriteLine("\nLa lletra es majuscula.");
                }
                else
                {
                    Console.WriteLine("\nLa lletra es minuscula.");
                }
            }
            else
            {
                Console.WriteLine("\nNo es una lletra.");
            }
        }
    }
}