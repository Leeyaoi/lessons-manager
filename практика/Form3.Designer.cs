namespace практика
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.saveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.temes = new System.Windows.Forms.TextBox();
            this.info = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.TeacherCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(24, 343);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(94, 29);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пройденные темы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Характеристика";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(24, 56);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(125, 27);
            this.name.TabIndex = 4;
            // 
            // temes
            // 
            this.temes.Location = new System.Drawing.Point(388, 195);
            this.temes.Multiline = true;
            this.temes.Name = "temes";
            this.temes.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.temes.Size = new System.Drawing.Size(325, 118);
            this.temes.TabIndex = 5;
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(24, 195);
            this.info.Multiline = true;
            this.info.Name = "info";
            this.info.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.info.Size = new System.Drawing.Size(294, 118);
            this.info.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Логин";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(588, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Пароль";
            // 
            // loginTB
            // 
            this.loginTB.Location = new System.Drawing.Point(388, 56);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(125, 27);
            this.loginTB.TabIndex = 9;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(588, 56);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(125, 27);
            this.passwordTB.TabIndex = 10;
            // 
            // TeacherCB
            // 
            this.TeacherCB.DataSource = ((object)(resources.GetObject("TeacherCB.DataSource")));
            this.TeacherCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TeacherCB.FormattingEnabled = true;
            this.TeacherCB.Location = new System.Drawing.Point(24, 125);
            this.TeacherCB.Name = "TeacherCB";
            this.TeacherCB.Size = new System.Drawing.Size(294, 28);
            this.TeacherCB.TabIndex = 11;
            this.TeacherCB.DataSource = Database.TeachersNames;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Учитель";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 398);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TeacherCB);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.info);
            this.Controls.Add(this.temes);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveBtn);
            this.Name = "Form3";
            this.Text = "Электронный дневник";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button saveBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox name;
        private TextBox temes;
        private TextBox info;
        private Label label4;
        private Label label5;
        private TextBox loginTB;
        private TextBox passwordTB;
        private ComboBox TeacherCB;
        private Label label6;
    }
}