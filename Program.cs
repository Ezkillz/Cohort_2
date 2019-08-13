using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> Gradebook = new Dictionary<string, string>();
            Console.WriteLine("Enter in a name if no name is needed then please type \"quit\".");
            string userName = Console.ReadLine() ;

            while (userName != "quit")
            {
            Console.WriteLine("Please enter the students grades.");
            string studGrades = Console.ReadLine();
                Gradebook.Add(userName, studGrades);
                Console.WriteLine("Enter in the name of student.If not please type\"quit\".");
                userName = Console.ReadLine();
            }

            int lowestGrade;
            int highestGrade;
            double averageGrade;

            foreach (var key in Gradebook.Keys)
            {
                Console.WriteLine(key);
                Console.WriteLine(Gradebook[key]);

                int[] theGrades;
                theGrades = Array.ConvertAll<string, int>(Gradebook[key].Split(),Convert.ToInt32);

                lowestGrade = theGrades.Min();
                highestGrade = theGrades.Max();
                averageGrade = theGrades.Average();

                Console.WriteLine(key + "lowest grade:" +lowestGrade + "Highest Grade:"+ highestGrade + "Average Grade:"+ averageGrade);
            }


        }

    }
}
