using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Vehicle
    {
        // properties
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        public Vehicle(string name)
        {
            Name = name;
        }

        public void PrintData()
        {
            Console.WriteLine("Car data : ");
            Console.WriteLine("- name : " + Name);
            Console.WriteLine("- speed : " + Speed);
            Console.WriteLine("- tyres : " + Tyres);
        }

        public override string ToString()
        {
            return "Vehicle: " + Name + ", " + Speed + ", " + Tyres;
        }

    }
}
