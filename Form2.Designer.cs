
namespace Черновик
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
            this.MessageLabel = new System.Windows.Forms.Label();
            this.MessageBoxTxt = new System.Windows.Forms.TextBox();
            this.ShiphBox = new System.Windows.Forms.TextBox();
            this.ShifrovanoeMessage = new System.Windows.Forms.Label();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ShiphrButton = new System.Windows.Forms.Button();
            this.RashiprovatButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(12, 29);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(84, 17);
            this.MessageLabel.TabIndex = 0;
            this.MessageLabel.Text = "Сообщение";
            // 
            // MessageBoxTxt
            // 
            this.MessageBoxTxt.Location = new System.Drawing.Point(102, 29);
            this.MessageBoxTxt.Multiline = true;
            this.MessageBoxTxt.Name = "MessageBoxTxt";
            this.MessageBoxTxt.Size = new System.Drawing.Size(367, 72);
            this.MessageBoxTxt.TabIndex = 1;
            // 
            // ShiphBox
            // 
            this.ShiphBox.Location = new System.Drawing.Point(102, 260);
            this.ShiphBox.Multiline = true;
            this.ShiphBox.Name = "ShiphBox";
            this.ShiphBox.Size = new System.Drawing.Size(367, 72);
            this.ShiphBox.TabIndex = 3;
            // 
            // ShifrovanoeMessage
            // 
            this.ShifrovanoeMessage.AutoSize = true;
            this.ShifrovanoeMessage.Location = new System.Drawing.Point(27, 260);
            this.ShifrovanoeMessage.Name = "ShifrovanoeMessage";
            this.ShifrovanoeMessage.Size = new System.Drawing.Size(46, 17);
            this.ShifrovanoeMessage.TabIndex = 2;
            this.ShifrovanoeMessage.Text = "Шифр";
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(102, 151);
            this.PassBox.Multiline = true;
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(367, 72);
            this.PassBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Пароль";
            // 
            // ShiphrButton
            // 
            this.ShiphrButton.Location = new System.Drawing.Point(547, 37);
            this.ShiphrButton.Name = "ShiphrButton";
            this.ShiphrButton.Size = new System.Drawing.Size(176, 64);
            this.ShiphrButton.TabIndex = 6;
            this.ShiphrButton.Text = "Зашифровать";
            this.ShiphrButton.UseVisualStyleBackColor = true;
            this.ShiphrButton.Click += new System.EventHandler(this.ShiphrButton_Click);
            // 
            // RashiprovatButton
            // 
            this.RashiprovatButton.Location = new System.Drawing.Point(547, 154);
            this.RashiprovatButton.Name = "RashiprovatButton";
            this.RashiprovatButton.Size = new System.Drawing.Size(176, 64);
            this.RashiprovatButton.TabIndex = 7;
            this.RashiprovatButton.Text = "Расшифровать";
            this.RashiprovatButton.UseVisualStyleBackColor = true;
            this.RashiprovatButton.Click += new System.EventHandler(this.RashiprovatButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(547, 260);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(176, 64);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 477);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.RashiprovatButton);
            this.Controls.Add(this.ShiphrButton);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShiphBox);
            this.Controls.Add(this.ShifrovanoeMessage);
            this.Controls.Add(this.MessageBoxTxt);
            this.Controls.Add(this.MessageLabel);
            this.Name = "Form2";
            this.Text = "Шифратор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.TextBox MessageBoxTxt;
        private System.Windows.Forms.TextBox ShiphBox;
        private System.Windows.Forms.Label ShifrovanoeMessage;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShiphrButton;
        private System.Windows.Forms.Button RashiprovatButton;
        private System.Windows.Forms.Button SaveButton;
    }
}