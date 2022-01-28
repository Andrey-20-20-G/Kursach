
namespace Черновик
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
            this.label1 = new System.Windows.Forms.Label();
            this.Отмена = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.Регистрация = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 9;
            // 
            // Отмена
            // 
            this.Отмена.Location = new System.Drawing.Point(404, 171);
            this.Отмена.Name = "Отмена";
            this.Отмена.Size = new System.Drawing.Size(83, 48);
            this.Отмена.TabIndex = 8;
            this.Отмена.Text = "Отмена";
            this.Отмена.UseVisualStyleBackColor = true;
            this.Отмена.Click += new System.EventHandler(this.Отмена_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(150, 127);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(337, 22);
            this.Password.TabIndex = 7;
            // 
            // Регистрация
            // 
            this.Регистрация.Location = new System.Drawing.Point(151, 171);
            this.Регистрация.Name = "Регистрация";
            this.Регистрация.Size = new System.Drawing.Size(201, 48);
            this.Регистрация.TabIndex = 6;
            this.Регистрация.Text = "Регистрация";
            this.Регистрация.UseVisualStyleBackColor = true;
            this.Регистрация.Click += new System.EventHandler(this.Регистрация_Click_1);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(150, 45);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(337, 22);
            this.Email.TabIndex = 5;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(150, 84);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(337, 22);
            this.Login.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Password";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 268);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Отмена);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Регистрация);
            this.Controls.Add(this.Email);
            this.Name = "Form3";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Отмена;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button Регистрация;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}