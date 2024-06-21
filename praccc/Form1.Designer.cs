namespace praccc
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
            btnAdd = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            btnMinus = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            num9 = new Button();
            num8 = new Button();
            num7 = new Button();
            num6 = new Button();
            num5 = new Button();
            num4 = new Button();
            num3 = new Button();
            num2 = new Button();
            num1 = new Button();
            btnEqual = new Button();
            num0 = new Button();
            btnDot = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(215, 138);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(56, 43);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(336, 25);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Wheat;
            textBox1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.WindowText;
            textBox1.Location = new Point(215, 59);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(287, 71);
            textBox1.TabIndex = 2;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(215, 202);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(56, 43);
            btnMinus.TabIndex = 3;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(215, 265);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(56, 43);
            btnMultiply.TabIndex = 4;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(215, 330);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(56, 43);
            btnDivide.TabIndex = 5;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // num9
            // 
            num9.Location = new Point(302, 138);
            num9.Name = "num9";
            num9.Size = new Size(56, 43);
            num9.TabIndex = 6;
            num9.Text = "9";
            num9.UseVisualStyleBackColor = true;
            num9.Click += num9_Click;
            // 
            // num8
            // 
            num8.Location = new Point(372, 138);
            num8.Name = "num8";
            num8.Size = new Size(56, 43);
            num8.TabIndex = 7;
            num8.Text = "8";
            num8.UseVisualStyleBackColor = true;
            num8.Click += num8_Click;
            // 
            // num7
            // 
            num7.Location = new Point(446, 138);
            num7.Name = "num7";
            num7.Size = new Size(56, 43);
            num7.TabIndex = 8;
            num7.Text = "7";
            num7.UseVisualStyleBackColor = true;
            num7.Click += num7_Click;
            // 
            // num6
            // 
            num6.Location = new Point(302, 202);
            num6.Name = "num6";
            num6.Size = new Size(56, 43);
            num6.TabIndex = 9;
            num6.Text = "6";
            num6.UseVisualStyleBackColor = true;
            num6.Click += num6_Click;
            // 
            // num5
            // 
            num5.Location = new Point(372, 202);
            num5.Name = "num5";
            num5.Size = new Size(56, 43);
            num5.TabIndex = 10;
            num5.Text = "5";
            num5.UseVisualStyleBackColor = true;
            num5.Click += num5_Click;
            // 
            // num4
            // 
            num4.Location = new Point(446, 202);
            num4.Name = "num4";
            num4.Size = new Size(56, 43);
            num4.TabIndex = 11;
            num4.Text = "4";
            num4.UseVisualStyleBackColor = true;
            num4.Click += num4_Click;
            // 
            // num3
            // 
            num3.Location = new Point(302, 265);
            num3.Name = "num3";
            num3.Size = new Size(56, 43);
            num3.TabIndex = 12;
            num3.Text = "3";
            num3.UseVisualStyleBackColor = true;
            num3.Click += num3_Click;
            // 
            // num2
            // 
            num2.Location = new Point(372, 265);
            num2.Name = "num2";
            num2.Size = new Size(56, 43);
            num2.TabIndex = 13;
            num2.Text = "2";
            num2.UseVisualStyleBackColor = true;
            num2.Click += num2_Click;
            // 
            // num1
            // 
            num1.Location = new Point(446, 265);
            num1.Name = "num1";
            num1.Size = new Size(56, 43);
            num1.TabIndex = 14;
            num1.Text = "1";
            num1.UseVisualStyleBackColor = true;
            num1.Click += num1_Click;
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(302, 330);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(56, 43);
            btnEqual.TabIndex = 15;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // num0
            // 
            num0.Location = new Point(372, 330);
            num0.Name = "num0";
            num0.Size = new Size(56, 43);
            num0.TabIndex = 16;
            num0.Text = "0";
            num0.UseVisualStyleBackColor = true;
            num0.Click += num0_Click;
            // 
            // btnDot
            // 
            btnDot.Location = new Point(446, 330);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(56, 43);
            btnDot.TabIndex = 17;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnDot_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(302, 379);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(126, 43);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnDot);
            Controls.Add(num0);
            Controls.Add(btnEqual);
            Controls.Add(num1);
            Controls.Add(num2);
            Controls.Add(num3);
            Controls.Add(num4);
            Controls.Add(num5);
            Controls.Add(num6);
            Controls.Add(num7);
            Controls.Add(num8);
            Controls.Add(num9);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnMinus);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Label label1;
        private TextBox textBox1;
        private Button btnMinus;
        private Button btnMultiply;
        private Button btnDivide;
        private Button num9;
        private Button num8;
        private Button num7;
        private Button num6;
        private Button num5;
        private Button num4;
        private Button num3;
        private Button num2;
        private Button num1;
        private Button btnEqual;
        private Button num0;
        private Button btnDot;
        private Button btnClear;
    }
}
