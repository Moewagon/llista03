namespace Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;

            Console.WriteLine("Entra una caracter:");
            ch = Console.ReadKey().KeyChar;
            Console.WriteLine(" "); //Aquesta linea es per donar un salt de linea

            if (char.IsLetter(ch))
            {
                
                Console.WriteLine("Es una lletra");
               
            }

            else
            {
                Console.WriteLine("No has entrat una lletra");
            }
        }
    }
}