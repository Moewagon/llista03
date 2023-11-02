namespace Ex11
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
                if (ch == 'a' || ch == 'A' || ch == 'e' || ch == 'E' || ch == 'i'
                || ch == 'I' || ch == 'o' || ch == 'O' || ch == 'u' || ch == 'U')
                {
                    Console.WriteLine("La lletra es vocal.");
                }
                else
                {
                    Console.WriteLine("La lletra es consonant.");
                }
            }

            else 
            {
                Console.WriteLine("No has entrat una lletra");
            }
        }
    }
}