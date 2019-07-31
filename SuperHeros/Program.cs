using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeros
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> Humans = new List<Person>();
            Person p1 = new Person("Zeke", "Ezkillz");
            Person p2 = new SuperHeros("Speed Force", "Barey", "Flash");
            Person p3 = new Villian("Batman","Joker");

            Humans.Add(p1);
            Humans.Add(p2);
            Humans.Add(p3);
            Humans.Add(new Person("Sara", "Nerd"));
            foreach(Person p in Humans)
            {
                p.PrintGreeting();
            }
            Console.ReadLine();
        }

    }
    class SuperHeros : Person
    {
        public string SuperPower { get; set; }
        public string RealName { get; set; }
        public override string Name { get; set; }

        public SuperHeros(string superPower, string realName, string name) : base(name, null)
        {
            SuperPower = superPower;
            RealName = realName;
        }
        public override void PrintGreeting()
        {
            Console.WriteLine($"I am {RealName}, when I am {Name}, my super power is {SuperPower}");
        }
    }
    class Person
    {
        public virtual string Name { get; set; }
        public string NickName { get; set; }
        public Person(string name, string nickname)
        {
            Name = name;
            NickName = nickname;
        }
        public override string ToString()
        {
            return Name;
        }
        public virtual void PrintGreeting()
        {
            Console.WriteLine($"Hi my name is {Name}, but you can call me {NickName}");
        }
    }
    class Villian : Person
    {
        public string Nemesis { get; set; }
        public override string Name { get; set; }
        public Villian(string nemesis, string name) : base(name, null)
        {
            Nemesis = nemesis;
        }
        public override void PrintGreeting()
        {
            Console.WriteLine($"I am the {Name}! Have you seen {Nemesis}?");
        }
    }
}
