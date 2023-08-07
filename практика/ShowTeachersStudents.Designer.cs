namespace практика
{
    partial class ShowTeachersStudents
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
            this.NextBtn = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.Button();
            this.charact = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.temes = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(292, 212);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(125, 29);
            this.NextBtn.TabIndex = 10;
            this.NextBtn.Text = "Следующий";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // prevBtn
            // 
            this.prevBtn.Location = new System.Drawing.Point(15, 212);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(120, 29);
            this.prevBtn.TabIndex = 9;
            this.prevBtn.Text = "Предыдущий";
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // charact
            // 
            this.charact.Location = new System.Drawing.Point(15, 52);
            this.charact.Name = "charact";
            this.charact.Size = new System.Drawing.Size(195, 157);
            this.charact.TabIndex = 7;
            this.charact.Text = "label2";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(15, 17);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(50, 20);
            this.name.TabIndex = 6;
            this.name.Text = "label1";
            // 
            // temes
            // 
            this.temes.Location = new System.Drawing.Point(238, 49);
            this.temes.Multiline = true;
            this.temes.Name = "temes";
            this.temes.Size = new System.Drawing.Size(195, 154);
            this.temes.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowTeachersStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 258);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.temes);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.charact);
            this.Controls.Add(this.name);
            this.Name = "ShowTeachersStudents";
            this.Text = "Электронный дневник";
            this.Load += new System.EventHandler(this.ShowTeachersStudents_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button NextBtn;
        private Button prevBtn;
        private Label charact;
        private Label name;
        private TextBox temes;
        private Button button1;
    }
}