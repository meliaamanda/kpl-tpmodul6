using System;
using tpmodul6_103082400039;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Melia Amanda");

            video.PrintVideoDetails();

            // normal
            video.IncreasePlayCount(5000000);
            video.PrintVideoDetails();

            // test overflow
            for (int i = 0; i < 100; i++)
            {
                video.IncreasePlayCount(10000000);
            }

            video.PrintVideoDetails();
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}