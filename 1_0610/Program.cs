using System;
/// <summary>
/// Distanta pana la Stormwind
/// </summary>
// XML
namespace _1_0610
{
    class Program
    {
        static void Main(string[] args)
        {
            // definitie vs. declaratie
            int k;

            Console.WriteLine("Introduceti distanta la care sunteti pe autostrada");
            string line;
            line = Console.ReadLine();

            k = int.Parse(line);

            int d;
            
            if (k > 60)
                d = k - 60;
            else
                d = 60 - k;

            Console.WriteLine("Va aflati la {0} km de Stormwind", d);
            //Console.WriteLine($"Va aflati la {d} km de Stormwind");


            // test pt git hub

            //test HalaszG Github
        }
    }
}

