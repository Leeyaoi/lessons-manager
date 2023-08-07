using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace практика
{
    public partial class Teacher
    {
        public List<Student> students;
        public List<string> names;
        public string path;
        public string name;

        public Teacher(string path, string name)
        {
            this.students = new List<Student>();
            this.names = new List<string>();
            this.path = path;
            this.name = name;
        }

        public Teacher()
        {
            this.students = new List<Student>();
            this.names = new List<string>();
        }

        public void GetTeacher()
        {
            name = File.ReadLines(path).First();

            foreach(string line in File.ReadAllLines(path).Skip(1))
            {
                if (line == "") continue;
                var student = new Student();
                student.path = line;
                student.GetStudent();
                students.Add(student);
                names.Add(student.name);
            }
        }
    }
}