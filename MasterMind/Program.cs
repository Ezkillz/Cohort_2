using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    class Program
    {
        static void Main(string[] args)
        {
            Player();
            Console.ReadLine();
        }
        public static  void Mastermind()
        {


        }
        public static void Player()
        {
            string[] colors = new string[]
            {"1","2","3"};
            string color1;
            string color2;
            Random Gen = new Random();
            int Index1 = Gen.Next(0, 3);
            int Index2 = Gen.Next(0, 3);
            //
            color1 = colors[Index1];
            color2 = colors[Index2];

            Console.WriteLine("Guess what 2 colors im thinking of, out of Red(1), Yellow(2), Blue(3).(Both colors may be the same)");
            bool win = false;
            while (win == false)
            {

                Console.WriteLine("Guess the first color.");
                string Guess1 = Console.ReadLine();
                Console.WriteLine("Guess the second color");
                string Guess2 = Console.ReadLine();

                int first = 0;
                int sec = 0;

                if (color1 == Guess1)
                {
                    sec++;
                }
                if (color1 == Guess2)
                {
                    first++;
                }
                if (color2 == Guess1)
                {
                    first++;
                }
                if (color2 == Guess2)
                {
                    sec++;
                }
                Console.WriteLine(first+"-"+sec);
               if(sec == 2)
                {
                    win = true;
                }
            }

                //if (color1 != Guess1 && color1 != Guess2 && color2 != Guess1 && color2 != Guess1)
                //{
                //    Console.WriteLine("0-0");
                //}
                //else if (color1 == Guess2 && color2 == Guess1)
                //{
                //    Console.WriteLine("2-0");
                //}
                //else if (color1 == Guess1 || color2 == Guess2)
                //{
                //    Console.WriteLine("0-1");
                //}
                //else if (color1 == Guess2 || color2 == Guess1)
                //{
                //    Console.WriteLine("1-0");
                //}
                //else if (color1 == Guess1 && color2 == Guess2)
                //{
                //    Console.WriteLine("0-2");
                //    win = true;
                //}
            
            Console.WriteLine("You Win");
        }
    }
}
