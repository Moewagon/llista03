namespace Ex25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, numTemp;
            string resultat;

            Console.WriteLine("Entra un numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entra un altre numero");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entra un altre numero");
            num3 = Convert.ToInt32(Console.ReadLine());

            resultat = $"Els numeros ordenats son {num1}, {num2} y {num3}";

            if (num1 <= num2 && num2 <= num3)
            {
                Console.WriteLine(resultat);
            }
            else if ()
            {

            }
        }
    }
}
/*Fes un programa que donats tres números, els ordeni creixentment. Ha de permutar el valor
de les variables si cal.*/