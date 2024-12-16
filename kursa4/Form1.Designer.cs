namespace kursa4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 100);
            panel1.TabIndex = 0;
            panel1.Paint += DrawingPanel_Paint;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 129);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 36);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(12, 171);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Скобки";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(93, 171);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Дробь";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(318, 129);
            button3.Name = "button3";
            button3.Size = new Size(84, 36);
            button3.TabIndex = 4;
            button3.Text = "Добавить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(408, 129);
            button4.Name = "button4";
            button4.Size = new Size(84, 36);
            button4.TabIndex = 5;
            button4.Text = "Удалить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(12, 200);
            button5.Name = "button5";
            button5.Size = new Size(34, 25);
            button5.TabIndex = 6;
            button5.Text = "(";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(52, 200);
            button6.Name = "button6";
            button6.Size = new Size(32, 25);
            button6.TabIndex = 7;
            button6.Text = ")";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button5_Click;
            // 
            // button7
            // 
            button7.Location = new Point(174, 171);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 8;
            button7.Text = "Сложение";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(12, 231);
            button8.Name = "button8";
            button8.Size = new Size(80, 23);
            button8.TabIndex = 9;
            button8.Text = "Вычитание";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(12, 291);
            button9.Name = "button9";
            button9.Size = new Size(80, 23);
            button9.TabIndex = 10;
            button9.Text = "Умножение";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(255, 171);
            button10.Name = "button10";
            button10.Size = new Size(75, 23);
            button10.TabIndex = 11;
            button10.Text = "Деление";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(26, 260);
            button11.Name = "button11";
            button11.Size = new Size(48, 25);
            button11.TabIndex = 12;
            button11.Text = "-";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button5_Click;
            // 
            // button12
            // 
            button12.Location = new Point(26, 320);
            button12.Name = "button12";
            button12.Size = new Size(48, 25);
            button12.TabIndex = 13;
            button12.Text = "*";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button5_Click;
            // 
            // button13
            // 
            button13.Location = new Point(187, 200);
            button13.Name = "button13";
            button13.Size = new Size(48, 25);
            button13.TabIndex = 14;
            button13.Text = "+";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button5_Click;
            // 
            // button14
            // 
            button14.Location = new Point(266, 200);
            button14.Name = "button14";
            button14.Size = new Size(48, 25);
            button14.TabIndex = 15;
            button14.Text = "/";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button5_Click;
            // 
            // button15
            // 
            button15.Location = new Point(93, 202);
            button15.Name = "button15";
            button15.Size = new Size(75, 23);
            button15.TabIndex = 16;
            button15.Text = "Степень";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.Location = new Point(12, 351);
            button16.Name = "button16";
            button16.Size = new Size(80, 24);
            button16.TabIndex = 17;
            button16.Text = "Функции";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // button17
            // 
            button17.Location = new Point(498, 129);
            button17.Name = "button17";
            button17.Size = new Size(84, 36);
            button17.TabIndex = 18;
            button17.Text = "Удалить все";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // button18
            // 
            button18.Location = new Point(12, 381);
            button18.Name = "button18";
            button18.Size = new Size(80, 23);
            button18.TabIndex = 19;
            button18.Text = "Корень";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button18_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button18);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
    }
}
