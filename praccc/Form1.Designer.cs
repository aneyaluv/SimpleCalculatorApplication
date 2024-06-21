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
            btnBack = new Button();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightSalmon;
            btnAdd.Font = new Font("Stencil", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ControlLightLight;
            btnAdd.Location = new Point(218, 177);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(81, 43);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 33F);
            label1.ForeColor = Color.LightSalmon;
            label1.Location = new Point(221, 44);
            label1.Name = "label1";
            label1.Size = new Size(289, 52);
            label1.TabIndex = 1;
            label1.Text = "Calculator";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.PapayaWhip;
            textBox1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.DimGray;
            textBox1.Location = new Point(218, 98);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(295, 71);
            textBox1.TabIndex = 2;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.LightSalmon;
            btnMinus.Font = new Font("Stencil", 20.25F);
            btnMinus.ForeColor = SystemColors.ControlLightLight;
            btnMinus.Location = new Point(218, 226);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(81, 43);
            btnMinus.TabIndex = 3;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.LightSalmon;
            btnMultiply.Font = new Font("Stencil", 20.25F);
            btnMultiply.ForeColor = SystemColors.ControlLightLight;
            btnMultiply.Location = new Point(218, 275);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(81, 43);
            btnMultiply.TabIndex = 4;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.LightSalmon;
            btnDivide.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDivide.ForeColor = SystemColors.ControlLightLight;
            btnDivide.Location = new Point(218, 324);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(81, 43);
            btnDivide.TabIndex = 5;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // num9
            // 
            num9.BackColor = Color.Snow;
            num9.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            num9.ForeColor = Color.DimGray;
            num9.Location = new Point(305, 177);
            num9.Name = "num9";
            num9.Size = new Size(64, 43);
            num9.TabIndex = 6;
            num9.Text = "9";
            num9.UseVisualStyleBackColor = false;
            num9.Click += num9_Click;
            // 
            // num8
            // 
            num8.BackColor = Color.Snow;
            num8.Font = new Font("Stencil", 18F);
            num8.ForeColor = Color.DimGray;
            num8.Location = new Point(375, 177);
            num8.Name = "num8";
            num8.Size = new Size(64, 43);
            num8.TabIndex = 7;
            num8.Text = "8";
            num8.UseVisualStyleBackColor = false;
            num8.Click += num8_Click;
            // 
            // num7
            // 
            num7.BackColor = Color.Snow;
            num7.Font = new Font("Stencil", 18F);
            num7.ForeColor = Color.DimGray;
            num7.Location = new Point(449, 177);
            num7.Name = "num7";
            num7.Size = new Size(64, 43);
            num7.TabIndex = 8;
            num7.Text = "7";
            num7.UseVisualStyleBackColor = false;
            num7.Click += num7_Click;
            // 
            // num6
            // 
            num6.BackColor = Color.Snow;
            num6.Font = new Font("Stencil", 18F);
            num6.ForeColor = Color.DimGray;
            num6.Location = new Point(305, 226);
            num6.Name = "num6";
            num6.Size = new Size(64, 43);
            num6.TabIndex = 9;
            num6.Text = "6";
            num6.UseVisualStyleBackColor = false;
            num6.Click += num6_Click;
            // 
            // num5
            // 
            num5.BackColor = Color.Snow;
            num5.Font = new Font("Stencil", 18F);
            num5.ForeColor = Color.DimGray;
            num5.Location = new Point(375, 226);
            num5.Name = "num5";
            num5.Size = new Size(64, 43);
            num5.TabIndex = 10;
            num5.Text = "5";
            num5.UseVisualStyleBackColor = false;
            num5.Click += num5_Click;
            // 
            // num4
            // 
            num4.BackColor = Color.Snow;
            num4.Font = new Font("Stencil", 18F);
            num4.ForeColor = Color.DimGray;
            num4.Location = new Point(449, 226);
            num4.Name = "num4";
            num4.Size = new Size(64, 43);
            num4.TabIndex = 11;
            num4.Text = "4";
            num4.UseVisualStyleBackColor = false;
            num4.Click += num4_Click;
            // 
            // num3
            // 
            num3.BackColor = Color.Snow;
            num3.Font = new Font("Stencil", 18F);
            num3.ForeColor = Color.DimGray;
            num3.Location = new Point(305, 275);
            num3.Name = "num3";
            num3.Size = new Size(64, 43);
            num3.TabIndex = 12;
            num3.Text = "3";
            num3.UseVisualStyleBackColor = false;
            num3.Click += num3_Click;
            // 
            // num2
            // 
            num2.BackColor = Color.Snow;
            num2.Font = new Font("Stencil", 18F);
            num2.ForeColor = Color.DimGray;
            num2.Location = new Point(375, 275);
            num2.Name = "num2";
            num2.Size = new Size(64, 43);
            num2.TabIndex = 13;
            num2.Text = "2";
            num2.UseVisualStyleBackColor = false;
            num2.Click += num2_Click;
            // 
            // num1
            // 
            num1.BackColor = Color.Snow;
            num1.Font = new Font("Stencil", 18F);
            num1.ForeColor = Color.DimGray;
            num1.Location = new Point(449, 275);
            num1.Name = "num1";
            num1.Size = new Size(64, 43);
            num1.TabIndex = 14;
            num1.Text = "1";
            num1.UseVisualStyleBackColor = false;
            num1.Click += num1_Click;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.LightSalmon;
            btnEqual.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEqual.ForeColor = SystemColors.ControlLightLight;
            btnEqual.Location = new Point(218, 373);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(151, 43);
            btnEqual.TabIndex = 15;
            btnEqual.Text = "Calculate";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // num0
            // 
            num0.BackColor = Color.Snow;
            num0.Font = new Font("Stencil", 18F);
            num0.ForeColor = Color.DimGray;
            num0.Location = new Point(375, 324);
            num0.Name = "num0";
            num0.Size = new Size(64, 43);
            num0.TabIndex = 16;
            num0.Text = "0";
            num0.UseVisualStyleBackColor = false;
            num0.Click += num0_Click;
            // 
            // btnDot
            // 
            btnDot.BackColor = Color.Snow;
            btnDot.Font = new Font("Stencil", 18F);
            btnDot.ForeColor = Color.DimGray;
            btnDot.Location = new Point(449, 324);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(64, 43);
            btnDot.TabIndex = 17;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += btnDot_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Snow;
            btnClear.Font = new Font("Stencil", 18F);
            btnClear.ForeColor = Color.DimGray;
            btnClear.Location = new Point(305, 324);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(64, 43);
            btnClear.TabIndex = 18;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.LightSalmon;
            btnBack.Font = new Font("Stencil", 12F);
            btnBack.ForeColor = SystemColors.ControlLightLight;
            btnBack.Location = new Point(375, 373);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(138, 43);
            btnBack.TabIndex = 19;
            btnBack.Text = "Backspace";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 442);
            Controls.Add(btnBack);
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
        private Button btnBack;
    }
}
