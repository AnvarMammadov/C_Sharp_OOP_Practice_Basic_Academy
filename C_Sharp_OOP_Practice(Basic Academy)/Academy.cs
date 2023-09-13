using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_OOP_Practice_Basic_Academy_
{
    public class Academy
    {
        public Academy() { }
        public Academy(string name) { AcademyName = name; Groups = new Group[0]; }

        public string? AcademyName { get; set; } = "No Name";
        public Group[]? Groups { get; set; } = new Group[0];

        public Teacher[]? Teachers { get; set; }
        public Student[]? Students { get; set; }

        public Group GetGroup()
        {
            Console.Write("Group Name : ");
            string? groupName = Console.ReadLine();
            return new Group(groupName);
        }

        public void AddGroup(Group group)
        {
            var temp = new Group[Groups.Length + 1];
            if (Groups != null) { Groups.CopyTo(temp, 0); }
            temp[temp.Length - 1] = group;
            Groups = temp;
        }

          
       

    }
}
