namespace Danil_temp
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
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(273, 265);
            label3.Name = "label3";
            label3.Size = new Size(110, 37);
            label3.TabIndex = 14;
            label3.Text = "Пароль";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(273, 169);
            label2.Name = "label2";
            label2.Size = new Size(93, 37);
            label2.TabIndex = 13;
            label2.Text = "Логин";
            // 
            // button1
            // 
            button1.Location = new Point(329, 378);
            button1.Name = "button1";
            button1.Size = new Size(130, 23);
            button1.TabIndex = 12;
            button1.Text = "Зарегистрироваться";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 28F);
            textBox2.Location = new Point(273, 305);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(232, 53);
            textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 28F);
            textBox1.Location = new Point(273, 209);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 53);
            textBox1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 64F);
            label1.Location = new Point(126, 55);
            label1.Name = "label1";
            label1.Size = new Size(539, 114);
            label1.TabIndex = 9;
            label1.Text = "Регистрация";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(511, 305);
            label4.Name = "label4";
            label4.Size = new Size(282, 45);
            label4.TabIndex = 15;
            label4.Text = "Пароль должен:\r\n- Быть длиннее 8 символов\r\n- Содержать специальные символы: !; @; #; $; %...";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private Label label4;
    }
}