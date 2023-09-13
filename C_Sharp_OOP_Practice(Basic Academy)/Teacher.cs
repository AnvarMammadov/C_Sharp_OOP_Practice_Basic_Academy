using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_OOP_Practice_Basic_Academy_
{
    public class Teacher:Human
    {
        public Teacher(string?name,string?surname,int age,int experience,string?speciality):base(name,surname,age) {
            Experience = experience;
            Speciality = speciality;
        }
        public int Experience { get; set; }
        public string? Speciality { get; set; }

        public new void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Experience : {Experience}");
            Console.WriteLine($"Speciality : {Speciality}\n");
        }
    }
}
