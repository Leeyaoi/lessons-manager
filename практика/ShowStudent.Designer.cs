namespace практика
{
    partial class ShowStudent
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
            this.name = new System.Windows.Forms.Label();
            this.charact = new System.Windows.Forms.Label();
            this.temes = new System.Windows.Forms.Label();
            this.prevBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.teacher = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(12, 9);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(50, 20);
            this.name.TabIndex = 0;
            this.name.Text = "label1";
            // 
            // charact
            // 
            this.charact.Location = new System.Drawing.Point(12, 44);
            this.charact.Name = "charact";
            this.charact.Size = new System.Drawing.Size(195, 157);
            this.charact.TabIndex = 1;
            this.charact.Text = "label2";
            // 
            // temes
            // 
            this.temes.Location = new System.Drawing.Point(235, 44);
            this.temes.Name = "temes";
            this.temes.Size = new System.Drawing.Size(195, 157);
            this.temes.TabIndex = 2;
            this.temes.Text = "label3";
            // 
            // prevBtn
            // 
            this.prevBtn.Location = new System.Drawing.Point(12, 204);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(179, 29);
            this.prevBtn.TabIndex = 3;
            this.prevBtn.Text = "Предыдущий";
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(235, 204);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(179, 29);
            this.NextBtn.TabIndex = 4;
            this.NextBtn.Text = "Следующий";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // teacher
            // 
            this.teacher.AutoSize = true;
            this.teacher.Location = new System.Drawing.Point(235, 9);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(50, 20);
            this.teacher.TabIndex = 5;
            this.teacher.Text = "label4";
            // 
            // ShowStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 249);
            this.Controls.Add(this.teacher);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.temes);
            this.Controls.Add(this.charact);
            this.Controls.Add(this.name);
            this.Name = "ShowStudent";
            this.Text = "Электронный дневник";
            this.Load += new System.EventHandler(this.ShowStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label name;
        private Label charact;
        private Label temes;
        private Button prevBtn;
        private Button NextBtn;
        private Label teacher;
    }
}