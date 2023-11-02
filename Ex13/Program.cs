namespace Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;

            Console.WriteLine("Entra una lletra:");
            ch = Console.ReadKey().KeyChar;
            Console.WriteLine(" "); //Aquesta linea es per donar un salt de linea

            if (char.IsLetter(ch))
            {
                if (char.IsLower(ch))
                {
                    Console.WriteLine("La teva lletra majuscula es ");
                    Console.WriteLine(char.ToUpper(ch));
                }

                else
                {
                    Console.WriteLine("La lletra ja es majuscula");
                }
            }
            else
            {
                Console.WriteLine("No has entrat una lletra cap de suro");
            }
        }
    }
}