using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace практика
{
    public partial class ShowTheStud : Form
    {
        Student student;
        string TeachersName;
        int index;

        public ShowTheStud(Student stud, string name, int ind)
        {
            InitializeComponent();
            student = stud;
            TeachersName = name;
            index = ind;
        }

        private void ShowTheStud_Load(object sender, EventArgs e)
        {
            string[] thisOne = File.ReadAllText(student.path).Split("\n----------------------");

            name.Text = thisOne[0];
            charact.Text = thisOne[2];
            temes.Text = thisOne[3];
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static int FindAllUsrsFile(string path)
        {
            int x = File.ReadAllLines(@"Accounts\Students\UsersFiles.txt").ToList().IndexOf(path);
            int i = 0;
            int j = 0;
            foreach (var user in File.ReadAllLines(@"Accounts\Users.txt"))
            {
                if (user.Split()[2] == "0")
                {
                    if (i == x)
                    {
                        return j;
                    }
                    i++;
                }
                j++;
            }
            return -1;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Database.teachers[TeachersName].students.RemoveAt(index);
            File.Delete(student.path);
            File.Delete(student.path.Replace(".txt","less.txt"));

            List<string> lines = File.ReadAllLines(Database.teachers[TeachersName].path).ToList();
            lines.Remove(student.path);
            File.WriteAllLines(Database.teachers[TeachersName].path, lines.ToArray());

            List<string> liness = File.ReadAllLines(@"Accounts\Users.txt").ToList();
            liness.RemoveAt(FindAllUsrsFile(student.path));
            File.WriteAllLines(@"Accounts\Users.txt", liness);

            this.Close();
        }
    }
}
