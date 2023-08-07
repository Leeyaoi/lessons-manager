using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace практика
{
    public partial class Student
    {
        public List<string> lessons;
        public string path;
        public string name { get; set; }

        public Student() { this.lessons = new List<string>(); }

        public Student(string path, string name)
        {
            this.lessons = new List<string>();
            this.path = path;
            this.name = name;
        } 

        public void GetStudent()
        {
            name = File.ReadLines(path).First();

            var pathOfLessons = path.Replace(".txt", "less.txt");

            foreach (string line in File.ReadAllLines(pathOfLessons))
            {
                lessons.Add(line);
            }
        }
    }
}
