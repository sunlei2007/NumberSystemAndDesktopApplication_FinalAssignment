namespace Calculator
{
    partial class CalculatorFrm
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
            buttonNum9 = new Button();
            buttonNum8 = new Button();
            buttonNum7 = new Button();
            buttonNum4 = new Button();
            buttonNum5 = new Button();
            buttonNum6 = new Button();
            buttonNum1 = new Button();
            buttonNum2 = new Button();
            buttonNum3 = new Button();
            Equal = new Button();
            buttonDecimal = new Button();
            buttonNum0 = new Button();
            Add = new Button();
            Sub = new Button();
            Mul = new Button();
            Divide = new Button();
            result = new Button();
            operationLabel = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonNum9
            // 
            buttonNum9.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNum9.Location = new Point(250, 166);
            buttonNum9.Name = "buttonNum9";
            buttonNum9.Size = new Size(48, 48);
            buttonNum9.TabIndex = 0;
            buttonNum9.Text = "9";
            buttonNum9.UseVisualStyleBackColor = true;
            buttonNum9.Click += Number_Click;
            // 
            // buttonNum8
            // 
            buttonNum8.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNum8.Location = new Point(304, 166);
            buttonNum8.Name = "buttonNum8";
            buttonNum8.Size = new Size(48, 48);
            buttonNum8.TabIndex = 1;
            buttonNum8.Text = "8";
            buttonNum8.UseVisualStyleBackColor = true;
            buttonNum8.Click += Number_Click;
            // 
            // buttonNum7
            // 
            buttonNum7.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNum7.Location = new Point(358, 166);
            buttonNum7.Name = "buttonNum7";
            buttonNum7.Size = new Size(48, 48);
            buttonNum7.TabIndex = 2;
            buttonNum7.Text = "7";
            buttonNum7.UseVisualStyleBackColor = true;
            buttonNum7.Click += Number_Click;
            // 
            // buttonNum4
            // 
            buttonNum4.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNum4.Location = new Point(358, 220);
            buttonNum4.Name = "buttonNum4";
            buttonNum4.Size = new Size(48, 48);
            buttonNum4.TabIndex = 5;
            buttonNum4.Text = "4";
            buttonNum4.UseVisualStyleBackColor = true;
            buttonNum4.Click += Number_Click;
            // 
            // buttonNum5
            // 
            buttonNum5.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNum5.Location = new Point(304, 220);
            buttonNum5.Name = "buttonNum5";
            buttonNum5.Size = new Size(48, 48);
            buttonNum5.TabIndex = 4;
            buttonNum5.Text = "5";
            buttonNum5.UseVisualStyleBackColor = true;
            buttonNum5.Click += Number_Click;
            // 
            // buttonNum6
            // 
            buttonNum6.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNum6.Location = new Point(250, 220);
            buttonNum6.Name = "buttonNum6";
            buttonNum6.Size = new Size(48, 48);
            buttonNum6.TabIndex = 3;
            buttonNum6.Text = "6";
            buttonNum6.UseVisualStyleBackColor = true;
            buttonNum6.Click += Number_Click;
            // 
            // buttonNum1
            // 
            buttonNum1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNum1.Location = new Point(358, 274);
            buttonNum1.Name = "buttonNum1";
            buttonNum1.Size = new Size(48, 48);
            buttonNum1.TabIndex = 8;
            buttonNum1.Text = "1";
            buttonNum1.UseVisualStyleBackColor = true;
            buttonNum1.Click += Number_Click;
            // 
            // buttonNum2
            // 
            buttonNum2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNum2.Location = new Point(304, 274);
            buttonNum2.Name = "buttonNum2";
            buttonNum2.Size = new Size(48, 48);
            buttonNum2.TabIndex = 7;
            buttonNum2.Text = "2";
            buttonNum2.UseVisualStyleBackColor = true;
            buttonNum2.Click += Number_Click;
            // 
            // buttonNum3
            // 
            buttonNum3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNum3.Location = new Point(250, 274);
            buttonNum3.Name = "buttonNum3";
            buttonNum3.Size = new Size(48, 48);
            buttonNum3.TabIndex = 6;
            buttonNum3.Text = "3";
            buttonNum3.UseVisualStyleBackColor = true;
            buttonNum3.Click += Number_Click;
            // 
            // Equal
            // 
            Equal.AccessibleDescription = "Equal";
            Equal.AccessibleName = "Equal";
            Equal.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Equal.Location = new Point(358, 328);
            Equal.Name = "Equal";
            Equal.Size = new Size(48, 48);
            Equal.TabIndex = 11;
            Equal.Text = "=";
            Equal.UseVisualStyleBackColor = true;
            Equal.Click += Equal_Click;
            // 
            // buttonDecimal
            // 
            buttonDecimal.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDecimal.Location = new Point(304, 328);
            buttonDecimal.Name = "buttonDecimal";
            buttonDecimal.Size = new Size(48, 48);
            buttonDecimal.TabIndex = 10;
            buttonDecimal.Text = ".";
            buttonDecimal.UseVisualStyleBackColor = true;
            buttonDecimal.Click += Decimal_Click;
            // 
            // buttonNum0
            // 
            buttonNum0.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNum0.Location = new Point(250, 328);
            buttonNum0.Name = "buttonNum0";
            buttonNum0.Size = new Size(48, 48);
            buttonNum0.TabIndex = 9;
            buttonNum0.Text = "0";
            buttonNum0.UseVisualStyleBackColor = true;
            buttonNum0.Click += Number_Click;
            // 
            // Add
            // 
            Add.AccessibleDescription = "Add";
            Add.AccessibleName = "Add";
            Add.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Add.Location = new Point(412, 166);
            Add.Name = "Add";
            Add.Size = new Size(48, 48);
            Add.TabIndex = 12;
            Add.Text = "+";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Operation_Click;
            // 
            // Sub
            // 
            Sub.AccessibleDescription = "Subtract";
            Sub.AccessibleName = "Subtract";
            Sub.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Sub.Location = new Point(412, 220);
            Sub.Name = "Sub";
            Sub.Size = new Size(48, 48);
            Sub.TabIndex = 13;
            Sub.Text = "-";
            Sub.UseVisualStyleBackColor = true;
            Sub.Click += Operation_Click;
            // 
            // Mul
            // 
            Mul.AccessibleDescription = "Multiply";
            Mul.AccessibleName = "Multiply";
            Mul.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Mul.Location = new Point(412, 274);
            Mul.Name = "Mul";
            Mul.Size = new Size(48, 48);
            Mul.TabIndex = 14;
            Mul.Text = "*";
            Mul.UseVisualStyleBackColor = true;
            Mul.Click += Operation_Click;
            // 
            // Divide
            // 
            Divide.AccessibleDescription = "Divide";
            Divide.AccessibleName = "Divide";
            Divide.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Divide.Location = new Point(412, 328);
            Divide.Name = "Divide";
            Divide.Size = new Size(48, 48);
            Divide.TabIndex = 15;
            Divide.Text = "/";
            Divide.UseVisualStyleBackColor = true;
            Divide.Click += Operation_Click;
            // 
            // result
            // 
            result.BackColor = SystemColors.ControlDarkDark;
            result.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            result.ForeColor = Color.Snow;
            result.ImageAlign = ContentAlignment.BottomLeft;
            result.Location = new Point(252, 88);
            result.Name = "result";
            result.Size = new Size(210, 56);
            result.TabIndex = 16;
            result.TextAlign = ContentAlignment.MiddleRight;
            result.UseVisualStyleBackColor = false;
            // 
            // operationLabel
            // 
            operationLabel.AutoSize = true;
            operationLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            operationLabel.Location = new Point(439, 63);
            operationLabel.Name = "operationLabel";
            operationLabel.Size = new Size(0, 21);
            operationLabel.TabIndex = 17;
            operationLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(246, 25);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(222, 135);
            tabControl1.TabIndex = 18;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(214, 105);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dec";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(214, 105);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Bin";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 26);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(214, 105);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Loc";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // CalculatorFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 450);
            Controls.Add(operationLabel);
            Controls.Add(result);
            Controls.Add(tabControl1);
            Controls.Add(Divide);
            Controls.Add(Mul);
            Controls.Add(Sub);
            Controls.Add(Add);
            Controls.Add(Equal);
            Controls.Add(buttonDecimal);
            Controls.Add(buttonNum0);
            Controls.Add(buttonNum1);
            Controls.Add(buttonNum2);
            Controls.Add(buttonNum3);
            Controls.Add(buttonNum4);
            Controls.Add(buttonNum5);
            Controls.Add(buttonNum6);
            Controls.Add(buttonNum7);
            Controls.Add(buttonNum8);
            Controls.Add(buttonNum9);
            Name = "CalculatorFrm";
            Text = "Calculator";
            Load += CalculatorFrm_Load;
            KeyDown += CalculatorFrm_KeyDown;
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonNum9;
        private Button buttonNum8;
        private Button buttonNum7;
        private Button buttonNum4;
        private Button buttonNum5;
        private Button buttonNum6;
        private Button buttonNum1;
        private Button buttonNum2;
        private Button buttonNum3;
        private Button Equal;
        private Button buttonDecimal;
        private Button buttonNum0;
        private Button Add;
        private Button Sub;
        private Button Mul;
        private Button Divide;
        private Button result;
        private Label operationLabel;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage1;
    }
}