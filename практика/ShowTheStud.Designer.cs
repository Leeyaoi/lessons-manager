namespace практика
{
    partial class ShowTheStud
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
            this.ExitBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.temes = new System.Windows.Forms.Label();
            this.charact = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(235, 207);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(179, 29);
            this.ExitBtn.TabIndex = 10;
            this.ExitBtn.Text = "Назад";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(12, 207);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(179, 29);
            this.deleteBtn.TabIndex = 9;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // temes
            // 
            this.temes.Location = new System.Drawing.Point(235, 47);
            this.temes.Name = "temes";
            this.temes.Size = new System.Drawing.Size(195, 157);
            this.temes.TabIndex = 8;
            this.temes.Text = "label3";
            // 
            // charact
            // 
            this.charact.Location = new System.Drawing.Point(12, 47);
            this.charact.Name = "charact";
            this.charact.Size = new System.Drawing.Size(195, 157);
            this.charact.TabIndex = 7;
            this.charact.Text = "label2";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(12, 12);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(50, 20);
            this.name.TabIndex = 6;
            this.name.Text = "label1";
            // 
            // ShowTheStud
            // 
            this.AcceptButton = this.ExitBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 246);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.temes);
            this.Controls.Add(this.charact);
            this.Controls.Add(this.name);
            this.Name = "ShowTheStud";
            this.Text = "Электронный дневник";
            this.Load += new System.EventHandler(this.ShowTheStud_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ExitBtn;
        private Button deleteBtn;
        private Label temes;
        private Label charact;
        private Label name;
    }
}