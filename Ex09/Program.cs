namespace Ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double angle;
            
            Console.WriteLine("Introdueix un valor d'un angle en graus");
            angle = Convert.ToDouble(Console.ReadLine());

            if (angle >= 0 && angle < 90)
            {
                Console.WriteLine("L'angle està al 1r quadrant");
            }

            else if (angle >= 90 && angle < 180)
            {
                Console.WriteLine("L'angle està al 2n quadrant");
            }

            else if (angle >= 180 && angle < 270)
            {
                Console.WriteLine("L'angle està al 3r quadrant");
            }

            else if (angle >= 270 && angle < 360)
            {
                Console.WriteLine("L'angle està al 4t quadrant");
            }

            else
            {
                Console.WriteLine("Aquest valor no es valid.");
            }
        }
    }
}