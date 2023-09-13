using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_OOP_Practice_Basic_Academy_
{
    public abstract class Human
    {
        protected Human(){ ID = ++id; }
        protected Human(string?name,string?surname,int age):this(){ Name = name;Surname = surname;Age = age; }

        private static int id = 0;

        public readonly int ID;
        public string? Name { get; set; } = "No Name";

        public string? Surname { get; set; } = "No Surname";

        public int Age { get; set; } = default;

        public override string ToString()
        {
            return $"ID : {ID}\nName : {Name}\nSurname : {Surname}\nAge : {Age}\n\n";
        }

        public void ShowInfo()
        {
            Console.WriteLine($"ID : {ID}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Surname : {Surname}");
            Console.WriteLine($"Age : {Age}");
            Console.WriteLine("\n\n");
        }
    }
}
