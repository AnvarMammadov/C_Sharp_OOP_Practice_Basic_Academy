using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace C_Sharp_OOP_Practice_Basic_Academy_
{
    public class Group
    {
        public Group() { }
        public Group(string?groupName) { GroupName = groupName;Teachers = new Teacher[0];Students = new Student[0];}
        public string? GroupName { get; set; } = "No name";
        public Teacher[]? Teachers { get; set; } = new Teacher[0];

        public Student[]? Students { get; set; } = new Student[0];

        public Teacher GetTeacher()
        {
            Console.Write("Name : ");
            string? name = Console.ReadLine()?.Trim();
            Console.Write("Surname : ");
            string? surname = Console.ReadLine()?.Trim();
            Console.Write("Age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Experience : ");
            int exprience = Convert.ToInt32(Console.ReadLine());
            Console.Write("Speciality : ");
            string? speciality = Console.ReadLine()?.Trim();
            return new Teacher(name, surname, age, exprience, speciality);
        }

        public void AddTeacher(Teacher newTeacher)
        {
            var temp = new Teacher[Teachers.Length + 1];
            if (Teachers != null) { Teachers.CopyTo(temp, 0); }
            temp[temp.Length - 1] = newTeacher;
            Teachers = temp;
        }

        public Student GetStudent()
        {
            Console.Write("Name : ");
            string? name = Console.ReadLine()?.Trim();
            Console.Write("Surname : ");
            string? surname = Console.ReadLine()?.Trim();
            Console.Write("Age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Score : ");
            double score = Convert.ToDouble(Console.ReadLine());
            Console.Write("Speciality : ");
            string? speciality = Console.ReadLine()?.Trim();
            return new Student(name, surname, age, score, speciality);
        }

        public void AddStudent(Student student)
        {
            var temp = new Student[Students.Length + 1];
            if (Students != null) { Students.CopyTo(temp, 0); }
            temp[temp.Length - 1] = student;
            Students = temp;
        }

        public void ShowGroupMembers()
        {
            Console.WriteLine($"Group Name : {GroupName}\n\n");
            Console.WriteLine("\t = = = = Teachers = = = =\n");
            foreach(var teacher in Teachers){
                teacher.ShowInfo(); Console.WriteLine("-------------------------------\n");
            }

            Console.WriteLine("\t = = = = Students = = = =\n");
            foreach (var student in Students) { 
                student.ShowInfo(); Console.WriteLine("-------------------------------\n");
            }
        }

    }
}
