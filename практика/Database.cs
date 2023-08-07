using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace практика
{
    public partial class Database
    {
        public static string TeachersFolder = @"Accounts\Teachers";
        public static string TeachersFile = @"Accounts\Teachers\TeachersFiles.txt";

        public static Dictionary<string, Teacher> teachers;
        public static List<string> TeachersNames = new List<string>();

        public static void GetAllTeachers()
        {
            teachers = new Dictionary<string, Teacher>();
            TeachersNames = new List<string>();
            foreach(string line in File.ReadAllLines(TeachersFile))
            {
                if (line == "") break;
                Teacher thisOne = new Teacher();
                thisOne.path = line;
                thisOne.GetTeacher();
                teachers.Add(thisOne.name, thisOne);
                TeachersNames.Add(thisOne.name);
            }
        }
    }
}
