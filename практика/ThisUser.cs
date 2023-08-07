using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практика
{
    internal class ThisUser
    {
        public static string login;
        public static int role;
        public static string password;
        //public static string whosStud = "";

        public static string GetTeachersPath()
        {
            int x = 0;
            foreach(var user in File.ReadAllLines(@"Accounts\Users.txt"))
            {
                if (user.Split()[2] == "1")
                {
                    if(user == $"{login} {password} 1")
                    {
                        return File.ReadAllLines(@"Accounts\Teachers\TeachersFiles.txt")[x];
                    }
                    x++;
                }
            }
            return "";
        }

        public static Teacher GetTeacher()
        {
            return Database.teachers[File.ReadAllLines(GetTeachersPath()).First()];
        }

        public static string GetStudsLessons()
        {
            int x = 0;
            foreach (var user in File.ReadAllLines(@"Accounts\Users.txt"))
            {
                if (user.Split()[2] == "0")
                {
                    if (user == $"{login} {password} 0")
                    {
                        return File.ReadAllLines(@"Accounts\Students\UsersFiles.txt")[x].Replace(".txt", "less.txt");
                    }
                    x++;
                }
            }
            return "";
        }
    }
}
