using System;

namespace GamblerLooseorwin
{
    public class Gambling_
    {
        
        static void Main(string[] args)
        {
            int Gambler_win = 1;
            Random random = new Random();
            int Gambler = random.Next(0, 2);
            Console.WriteLine("invested 1$");
            if (Gambler == Gambler_win) 
            {
                Console.WriteLine(" Win");
            }

            
            else
            {
                Console.WriteLine("Loose");
                Console.ReadKey();
            }
        }
    }
}


