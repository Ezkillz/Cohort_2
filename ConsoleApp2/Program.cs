using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ToDo> toDoItem = new List<ToDo>();
            Console.WriteLine("Would you like to add an item, if not then please type \"quit\".");
            string Ting = Console.ReadLine();
            while (Ting != "quit")
            {
                
    //ask for description, due date, and priority.
    //create a ToDoItem representing the user's input
    //add the new instance to a list of items
                Console.WriteLine("Please entering in a description");
                string userDescript = Console.ReadLine();
                Console.WriteLine("Please enter in the date");
                string theDate = Console.ReadLine();
                Console.WriteLine("Is your priority high or low");
                string thePrior = Console.ReadLine();
                toDoItem.Add(new ToDo(userDescript, theDate, thePrior));

                Console.WriteLine("Would you like to add an item, if not then please type \"quit\".");
                Ting = Console.ReadLine();
            }
            foreach(ToDo Item in toDoItem)
            {
                Console.WriteLine(Item.Description+" "+ Item.Date+" "+Item.Priority);
                
            }
        }
    }
    class ToDo
    {
        public string Description { get; set; }
        public string Date { get; set; }
        public string Priority { get; set; }
        public ToDo(string descript,  string date, string prior )
        {
            Description = descript;
            Date = date;
            Priority = prior;
        }

    }
}
