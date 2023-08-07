using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace практика
{
    public partial class Form3 : Form
    {
        static string UsersFolder = @"Accounts\Students";
        static string AllUsersFile = @"Accounts\Users.txt";
        static string DataBase = @"Accounts\Students\UsersFiles.txt";

        static int col_stud = 0;

        public static void CheckPovtor(ref string file, string file_name)
        {
            col_stud = 0;
            while (File.Exists(file))
            {
                col_stud++;
                file = $"{UsersFolder}\\{file_name}{col_stud}.txt";
            }
        }

        public Form3()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string file_name = loginTB.Text.Replace(' ', '_');
            string file = $"{UsersFolder}\\{file_name}{col_stud}.txt";

            CheckPovtor(ref file, file_name);

            File.AppendAllLines(DataBase, new string[] { file });
            File.AppendAllLines(AllUsersFile, new string[] { $"{loginTB.Text} {passwordTB.Text} 0" });

            File.AppendAllLines(Database.teachers[TeacherCB.Text].path, new string[] { file });
            Database.teachers[TeacherCB.Text].students.Add(new Student(file, name.Text));

            using (StreamWriter sw = new StreamWriter(file))
            {
                sw.WriteLine(name.Text);
                sw.WriteLine("----------------------");
                sw.WriteLine(TeacherCB.Text);
                sw.WriteLine("----------------------");
                sw.WriteLine(info.Text);
                sw.WriteLine("----------------------");
                sw.WriteLine(temes.Text);
            }

            File.Create(file.Replace(".txt", "less.txt")).Close();

            this.Close();
        }
    }
}
