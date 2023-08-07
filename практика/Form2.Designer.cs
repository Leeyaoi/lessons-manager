namespace практика
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.seeStudents = new System.Windows.Forms.Button();
            this.seeLessons = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Меню учителя";
            // 
            // seeStudents
            // 
            this.seeStudents.Location = new System.Drawing.Point(14, 50);
            this.seeStudents.Name = "seeStudents";
            this.seeStudents.Size = new System.Drawing.Size(311, 29);
            this.seeStudents.TabIndex = 3;
            this.seeStudents.Text = "Просмотреть учеников";
            this.seeStudents.UseVisualStyleBackColor = true;
            this.seeStudents.Click += new System.EventHandler(this.seeStudents_Click);
            // 
            // seeLessons
            // 
            this.seeLessons.Location = new System.Drawing.Point(12, 85);
            this.seeLessons.Name = "seeLessons";
            this.seeLessons.Size = new System.Drawing.Size(311, 29);
            this.seeLessons.TabIndex = 4;
            this.seeLessons.Text = "Просмотреть уроки";
            this.seeLessons.UseVisualStyleBackColor = true;
            this.seeLessons.Click += new System.EventHandler(this.seeLessons_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(464, 339);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(311, 29);
            this.button4.TabIndex = 5;
            this.button4.Text = "Выход";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(12, 120);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(311, 29);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 159);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.seeLessons);
            this.Controls.Add(this.seeStudents);
            this.Name = "Form2";
            this.Text = "Электронный дневник";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Button seeStudents;
        private Button seeLessons;
        private Button button4;
        private Button Exit;
    }
}