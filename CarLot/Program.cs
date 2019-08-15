using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLot
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot Lot = new CarLot("South Plains");
            Lot.add(new Car("coop", 4, "idk", "idk2", "KZ86FG", 10000));
            Lot.add(new Car("huh", 2, "nah", "huh", "KZ86FG", 10000));
            Lot.add(new Truck(10, "Ford", "F-150", "ytgrfedsa", 10000));
            Lot.printInventory();
            Console.ReadLine();
        }
    }
//CarLot should have methods to do the following actions:
//add a vehicle to the lot
//print the inventory of the car lot, including number of vehicles and details about each vehicle
    class CarLot
    {
        public List<vehicle> vehicles;
        public string name;
        public CarLot(string name)
        {
            vehicles = new List<vehicle>();
            this.name = name;
        } 
        public void add(vehicle toAdd)
        {
            vehicles.Add(toAdd);
        }
        public void printInventory()
        {
            foreach(vehicle item in this.vehicles)
            {
                Console.WriteLine(item);
            }
        }
    }
//Vehicle should have a method to do the following actions:
//return a description of the vehicle, including license number, make, model, and price
    public abstract class vehicle
    {
        string License;
        string Make;
        string Model;
        int Price;
        public vehicle(string make, string model, string license, int price)
        {
            this.License = license;
            this.Make = make;
            this.Model = model;
            this.Price = price;
        }
        public override string ToString()
        {
            return $"{Make},{Model},{Price},{License}";

        }
    }

    public class Car : vehicle
    {
        public int doors;
        public string type;
        public Car(string type, int doors, string make, string model, string license, int price) : base(make,model,license,price)
        {
            this.doors = doors;
            this.type = type;
        }
    }
    public class Truck : vehicle
    {
        public int bedSize;
        public Truck(int bedSize, string make, string model, string license, int price) : base(make, model, license, price)
        {
            this.bedSize = bedSize;
        }
    }
}
