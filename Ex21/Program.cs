using System.ComponentModel.Design;

namespace Ex21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hora, minut, segon, horaFinal, minutFinal, segonFinal;
            string missatgeError;

            missatgeError = "Has entrat una dada invalida";
            Console.WriteLine("Introdueix les hores en format 24h");
            hora = Convert.ToInt32(Console.ReadLine());

            if (hora >= 0 && hora <= 23)
            {
                Console.WriteLine("Introdueix els minuts");
                minut = Convert.ToInt32(Console.ReadLine());
            
                if (minut >= 0 && minut <=59)
                {
                    Console.WriteLine("Introdueix els segons");
                    segon = Convert.ToInt32(Console.ReadLine());
                    if (segon >= 0 && segon <= 59)
                    {
                        segonFinal= segon+1;
                        if (segonFinal>= 0 && segonFinal <= 59)
                        {
                            minutFinal = minut;
                            horaFinal = hora;
                            Console.WriteLine($"{horaFinal:00}:{minutFinal:00}:{segonFinal:00}");
                        }
                        else
                        {
                            segonFinal = 0;
                            minutFinal = minut + 1;
                            if (minutFinal >= 0 && minutFinal <= 59)
                            {
                                horaFinal = hora;
                                Console.WriteLine($"{horaFinal:00}:{minutFinal:00}:{segonFinal:00}");
                            }
                            else
                            {
                                minutFinal= 0;
                                horaFinal = hora+1;
                                if (horaFinal >=0 && horaFinal <= 23)
                                {
                                    Console.WriteLine($"{horaFinal:00}:{minutFinal:00}:{segonFinal:00}");
                                }
                                else
                                {
                                    horaFinal = 0;
                                    Console.WriteLine($"{horaFinal:00}:{minutFinal:00}:{segonFinal:00}");
                                }
                            }
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
            else
            {
                Console.WriteLine(missatgeError);
            }
        }
    }
}

/*Fes un programa que donada una hora, minut i segon, incrementi un segon i mostri l’hora
resultant. Cal verificar que l’hora estigui entre 0 i 23, els minuts entre 0 i 59 i els segons
entre 0 i 59.*/
