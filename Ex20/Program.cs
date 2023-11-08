namespace Ex20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char carnetJove,esDimarts,esFinde;
            double preuTotal,descDimarts,descCJ;
            string missatgeError;
            missatgeError = "\nHas entrat una resposta invalida.";
            preuTotal = 5;
            descDimarts = 0.2;
            descCJ = 0.15;

            Console.WriteLine("Avui es cap de setmana? (s/n)");
            esFinde = Console.ReadKey().KeyChar;
            if (esFinde == 's')
            {
                Console.WriteLine($"\nLa entrada te un preu de {preuTotal} euros");
            }
            else if (esFinde =='n')
            {
                Console.WriteLine("\nAvui es dimarts? (s/n)");
                esDimarts = Console.ReadKey().KeyChar;
                if (esDimarts == 's')
                {
                    preuTotal = 5 - (5 * descDimarts);
                    Console.WriteLine($"\nLa entrada te un preu de {preuTotal} euros");
                }
                else if (esDimarts == 'n')
                {
                    Console.WriteLine("\nTens carnet jove? (s/n)");
                    carnetJove = Console.ReadKey().KeyChar;
                    if(carnetJove == 's')
                    {
                        preuTotal = 5 - (5 * descCJ);
                        Console.WriteLine($"\nLa entrada te un preu de {preuTotal} euros");
                    }
                    else if(carnetJove == 'n')
                    {
                        Console.WriteLine($"\nLa entrada te un preu de {preuTotal} euros");
                    }
                    else
                    {
                        Console.WriteLine(missatgeError);
                    }
                }
                else
                {
                    Console.WriteLine(missatgeError);
                }
            }
            else
            {
                Console.WriteLine(missatgeError);
            }
        }
    }
}
/*Volem calcular el preu d’una entrada de cinema:
Sabem que una entrada estàndard val 5 €.
Si tens carnet jove et fan un 15% de descompte.
Els dimarts fan un 20%.
El cap de setmana no fan cap descompte a ningú.
Només et poden fer un descompte.
Fes un programa que demani per cada opció si es cumpleix o no (resposta s/n) i ens digui el
preu que hem de pagar. (escull l’ordre de preguntes correcte)*/