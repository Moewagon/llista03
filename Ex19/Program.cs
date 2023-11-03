using System;

namespace Ex19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, mitjana;
            Console.WriteLine("Introdueix la nota practica (30% de la nota total)");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introdueix la nota teorica (70% de la nota total)");
            nota2 = Convert.ToDouble(Console.ReadLine());

            if (nota1 < 3 || nota2 < 3)
            {
                Console.WriteLine("Suspés (Una de les dues notes es menor que 3)");
            }

            else
            {
                mitjana = (nota1 * 0.3 + nota2 * 0.7);
                if (mitjana >= 0 && mitjana < 5)
                {
                    Console.WriteLine($"Suspés (Nota mitjana inferior a 5). NOTA FINAL: {mitjana}");
                }
                else if (mitjana >= 5 && mitjana < 7)
                {
                    Console.WriteLine($"Aprovat. NOTA FINAL: {mitjana}");
                }
                else if (mitjana >= 7 && mitjana < 9)
                {
                    Console.WriteLine($"Notable. NOTA FINAL: {mitjana}");
                }
                else if (mitjana >= 9 && mitjana < 10)
                {
                    Console.WriteLine($"Excel.lent. NOTA FINAL: {mitjana}");
                }
                else if (mitjana == 10)
                {
                    Console.WriteLine($"Matricula d'honor!!. NOTA FINAL: {mitjana}");
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }
    }
}
/*Fes un programa que donades dues notes amb decimals (0-10), corresponents a pràctiques
(30%) i a teoria (70%), calculi la mitjana i expressi el resultat en lletres, tenint en compte la
següent taula, i que si una nota qualsevol és inferior a 3 ja no fa mitjana (suspèn
automàticament):
[0 .. 5) ...... suspès
[5 .. 7) ...... aprovat
[7 .. 9) ...... notable
[9 .. 10) ... excel.lent
10 ............. matrícula d’honor
*/