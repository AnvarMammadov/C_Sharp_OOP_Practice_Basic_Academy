using System.ComponentModel;
using System.Security.Cryptography;

namespace C_Sharp_OOP_Practice_Basic_Academy_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Academy academy = new Academy("Best Academy");
                Group g1 = new Group("A-15");
                Teacher t1 = new Teacher("Elvin", "Camalzade", 24, 6, ".Net Developer");
                Teacher t2 = new Teacher("Aysu", "Ahmedova", 30, 8, "Design");
                g1.AddTeacher(t1);
                Student s1 = new Student("Anvar", "Mammadov", 22, 90.4, ".Net Developer");
                g1.AddStudent(s1);
                Student s2 = new Student("Ali", "Aliyev", 23, 90.8, "Full Stack Developer");
                g1.AddStudent(s2);
                Student s3 = new Student("Nigar", "Quliyeva", 32, 77.1, "Design");
                g1.AddStudent(s3);
                Student s4 = new Student("Coshqun", "Hashimli", 25, 95, "SQL Developer");
                g1.AddStudent(s4);

                Group g2 = new Group("B-20");
                Teacher t3 = new Teacher("Rafiq", "Ceferov", 27, 4, "Java Developer");
                g2.AddTeacher(t3);
                Student s5 = new Student("Reshad", "Mehdizade", 21, 99, "Java Developer");
                g2.AddStudent(s5);
                Student s6 = new Student("Mahmud", "Qadirzade", 25, 77.2, "Java Developer");
                g2.AddStudent(s6);

                academy.AddGroup(g1); academy.AddGroup(g2);

                while (true)
                {
                    MyClear();
                    Console.WriteLine($"\t\t = = = Welcome {academy.AcademyName} = = =\n\n");
                    Console.WriteLine("Make new group   [1]");
                    Console.WriteLine("Show all groups  [2]");
                    string? chooseOperation = Console.ReadLine()?.Trim();
                    MyClear();
                    if (chooseOperation != null)
                    {
                        if (chooseOperation == "1")
                        {

                            Console.WriteLine("\t\t= = = Make new Group = = = \n\n");
                            var newGroup = academy.GetGroup();
                            while (true)
                            {
                                MyClear();
                                Console.WriteLine("\t = = Enter New Teacher Info = =\n\n");
                                var newTeacher = newGroup.GetTeacher();
                                newGroup.AddTeacher(newTeacher);
                                Console.Write("Add teacher one more [y/n] : ");
                                string? yesOrNo = Console.ReadLine();
                                if (yesOrNo == "y") { continue; }
                                else if (yesOrNo == "n") { break; }
                                else { Console.WriteLine("This operation not found..."); break; }
                            }
                            while (true)
                            {
                                MyClear();
                                Console.WriteLine("\t= = Enter new Student Info = =\n\n");
                                var newStudent = newGroup.GetStudent();
                                newGroup.AddStudent(newStudent);
                                Console.Write("Add student one more [y/n] : ");
                                string? yesOrNo = Console.ReadLine();
                                if (yesOrNo == "y") { continue; }
                                else if (yesOrNo == "n") { break; }
                                else { Console.WriteLine("This operation not found..."); break; }
                            }

                            academy.AddGroup(newGroup); Console.WriteLine("Group added successfully...");
                        }
                        else if (chooseOperation == "2")
                        {
                            Console.WriteLine("\t\t = = = All Groups = = =\n\n");
                            foreach (var group in academy.Groups)
                            {
                                group.ShowGroupMembers(); Console.WriteLine("\n");
                            }
                        }
                        else { Console.WriteLine("This operation not found..."); Console.ReadLine(); continue; }
                    }
                    else { Console.WriteLine("This operation not found..."); Console.ReadLine(); continue; }

                    Console.WriteLine("Press any key for contiue..."); Console.ReadLine(); MyClear();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void MyClear() { Console.Clear(); Console.WriteLine("\x1b[3J"); }
    }
}