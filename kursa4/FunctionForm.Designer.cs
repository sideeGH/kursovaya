namespace kursa4
{
    partial class FunctionForm
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
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton8 = new RadioButton();
            radioButton9 = new RadioButton();
            radioButton10 = new RadioButton();
            radioButton11 = new RadioButton();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(12, 12);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(56, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "log(x)";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(12, 37);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(49, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "ln(x)";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(12, 62);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(54, 19);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "sin(x)";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(12, 87);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(57, 19);
            radioButton5.TabIndex = 4;
            radioButton5.TabStop = true;
            radioButton5.Text = "cos(x)";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(12, 112);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(50, 19);
            radioButton6.TabIndex = 5;
            radioButton6.TabStop = true;
            radioButton6.Text = "tg(x)";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(12, 137);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(56, 19);
            radioButton7.TabIndex = 6;
            radioButton7.TabStop = true;
            radioButton7.Text = "ctg(x)";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(12, 162);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(70, 19);
            radioButton8.TabIndex = 7;
            radioButton8.TabStop = true;
            radioButton8.Text = "arcsin(x)";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.Location = new Point(12, 187);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(73, 19);
            radioButton9.TabIndex = 8;
            radioButton9.TabStop = true;
            radioButton9.Text = "arccos(x)";
            radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            radioButton10.AutoSize = true;
            radioButton10.Location = new Point(12, 212);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(66, 19);
            radioButton10.TabIndex = 9;
            radioButton10.TabStop = true;
            radioButton10.Text = "arctg(x)";
            radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            radioButton11.AutoSize = true;
            radioButton11.Location = new Point(12, 237);
            radioButton11.Name = "radioButton11";
            radioButton11.Size = new Size(72, 19);
            radioButton11.TabIndex = 10;
            radioButton11.TabStop = true;
            radioButton11.Text = "arcctg(x)";
            radioButton11.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(132, 73);
            button1.Name = "button1";
            button1.Size = new Size(80, 34);
            button1.TabIndex = 11;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(114, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 23);
            textBox1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 24);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 14;
            label1.Text = "Значение";
            // 
            // FunctionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 288);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(radioButton11);
            Controls.Add(radioButton10);
            Controls.Add(radioButton9);
            Controls.Add(radioButton8);
            Controls.Add(radioButton7);
            Controls.Add(radioButton6);
            Controls.Add(radioButton5);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Name = "FunctionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FunctionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private RadioButton radioButton9;
        private RadioButton radioButton10;
        private RadioButton radioButton11;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
    }
}