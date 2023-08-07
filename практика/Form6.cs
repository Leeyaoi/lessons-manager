using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace практика
{
    public partial class Form6 : Form
    {
        static string TeachersFolder = @"Accounts\Teachers";
        static string AllUsersFile = @"Accounts\Users.txt";
        static string DataBase = @"Accounts\Teachers\TeachersFiles.txt";

        static int col_tech = 0;

        public static void CheckPovtor(ref string file, string file_name)
        {
            col_tech = 0;
            while (File.Exists(file))
            {
                col_tech++;
                file = $"{TeachersFolder}\\{file_name}{col_tech}.txt";
            }
        }

        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string file_name = loginTB.Text.Replace(' ', '_');
            string file = $"{TeachersFolder}\\{file_name}{col_tech}.txt";

            string name = $"{SurnameTB.Text} {nameTB.Text} {SecNameTB.Text}";

            CheckPovtor(ref file, file_name);

            File.AppendAllLines(DataBase, new string[] { file });
            File.AppendAllLines(AllUsersFile, new string[] { $"{loginTB.Text} {passwordTB.Text} 1" });

            using (StreamWriter sw = new StreamWriter(file))
            {
                sw.WriteLine(name);
            }

            Database.teachers.Add(name, new Teacher(file_name, name));
            Database.TeachersNames.Add(name);
        }
    }
}
