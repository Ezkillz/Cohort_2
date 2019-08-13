using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        }

    }
    class DriversLincense
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string genderType { get; set; }
        public string licenseNumber { get; set; }

        public DriversLincense(string First, string Last, string Gendder, string License)
        {
            firstName = First;
            lastName = Last;
            genderType = Gendder;
            licenseNumber = License;
        }
        public String GetFullName()
        {
            string fullName = firstName + " " + lastName;
            return fullName;
        }
    }

}
