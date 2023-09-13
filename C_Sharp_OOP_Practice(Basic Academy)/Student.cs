using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_OOP_Practice_Basic_Academy_
{
    public class Student :Human
    {
        public Student(string?name,string?surname,int age,double score,string?speciality):base(name,surname,age){
            Score = score;Speciality = speciality;
        }
        public double Score { get; set; }
        public string? Speciality { get; set; }

        public new void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Score : {Score}");
            Console.WriteLine($"Speciality : {Speciality}\n");
        }
    }
}
