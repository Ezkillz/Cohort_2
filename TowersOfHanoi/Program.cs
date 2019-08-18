using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowersOfHanoi
{
    class Program
    {
        static Dictionary<string, Stack<int>> hold = new Dictionary<string, Stack<int>>();
        static void Main(string[] args)
        {
            
            hold.Add("A", new Stack<int>());
            hold.Add("B", new Stack<int>());
            hold.Add("C", new Stack<int>());
            hold["A"].Push(4);
            hold["A"].Push(3);
            hold["A"].Push(2);
            hold["A"].Push(1);
      
            while(hold["C"].Count != 4)
            {
                printBoard();
                makeMove();
            }
            Console.WriteLine("Congrats ypour a winner!");
            Console.ReadLine();

        }

        public static void printStack(Stack<int>stack)
        {
            int[] ArrTower = stack.ToArray();
            for (int i = ArrTower.Length - 1; i >= 0; i--)
            {
                Console.Write(ArrTower[i]);
            }

        }
        public static void printBoard()
        {
            foreach (string key in hold.Keys)
            {
                Console.Write($"{ key}:");
                printStack(hold[key]);
                Console.WriteLine();
            }
        }
        public static bool legalMoves(string from, string to)
        {
            if (hold[from].Peek() < hold[to].Peek() && hold[from].Count() !=0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Move not valid");
                return false;
            }
        }
        public static void makeMove()
        {
            Console.WriteLine();
            Console.WriteLine("Whats the tower you want to move from?");
            string from = Console.ReadLine();
            Console.WriteLine("Which tower do you want to move to?");
            string to = Console.ReadLine();
            if (legalMoves(from, to))
            {
                int move = hold[from].Peek();
                hold[to].Push(move);
                hold[from].Pop();
            }
        }


    }
}
