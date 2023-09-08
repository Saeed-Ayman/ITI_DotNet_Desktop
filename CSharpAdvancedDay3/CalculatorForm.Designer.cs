namespace CSharpAdvancedDay3
{
    partial class CalculatorForm
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
            screen_txt = new RichTextBox();
            btn_cls = new Button();
            btn_0 = new Button();
            btn_dot = new Button();
            btn_equal = new Button();
            btn_1 = new Button();
            btn_2 = new Button();
            btn_3 = new Button();
            btn_plus = new Button();
            btn_4 = new Button();
            btn_5 = new Button();
            btn_6 = new Button();
            btn_mins = new Button();
            btn_multi = new Button();
            btn_9 = new Button();
            btn_8 = new Button();
            btn_7 = new Button();
            btn_divide = new Button();
            btn_clear = new Button();
            btn_clear_current = new Button();
            btn_clear_element = new Button();
            SuspendLayout();
            // 
            // screen_txt
            // 
            screen_txt.Location = new Point(12, 12);
            screen_txt.MaxLength = 10;
            screen_txt.Name = "screen_txt";
            screen_txt.ReadOnly = true;
            screen_txt.Size = new Size(218, 103);
            screen_txt.TabIndex = 0;
            screen_txt.Text = "";
            // 
            // btn_cls
            // 
            btn_cls.BackColor = Color.Red;
            btn_cls.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cls.ForeColor = Color.White;
            btn_cls.Location = new Point(13, 342);
            btn_cls.Name = "btn_cls";
            btn_cls.Size = new Size(50, 50);
            btn_cls.TabIndex = 1;
            btn_cls.Text = "X";
            btn_cls.UseVisualStyleBackColor = false;
            btn_cls.Click += Btn_cls_Click;
            // 
            // btn_0
            // 
            btn_0.Location = new Point(69, 342);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(50, 50);
            btn_0.TabIndex = 2;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = true;
            btn_0.Click += Number_click;
            // 
            // btn_dot
            // 
            btn_dot.Location = new Point(125, 342);
            btn_dot.Name = "btn_dot";
            btn_dot.Size = new Size(50, 50);
            btn_dot.TabIndex = 3;
            btn_dot.Text = ".";
            btn_dot.UseVisualStyleBackColor = true;
            btn_dot.Click += Number_click;
            // 
            // btn_equal
            // 
            btn_equal.BackColor = SystemColors.Highlight;
            btn_equal.Location = new Point(181, 342);
            btn_equal.Name = "btn_equal";
            btn_equal.Size = new Size(50, 50);
            btn_equal.TabIndex = 4;
            btn_equal.Text = "=";
            btn_equal.UseVisualStyleBackColor = false;
            btn_equal.Click += Btn_equal_Click;
            // 
            // btn_1
            // 
            btn_1.Location = new Point(13, 289);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(50, 50);
            btn_1.TabIndex = 5;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = true;
            btn_1.Click += Number_click;
            // 
            // btn_2
            // 
            btn_2.Location = new Point(69, 289);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(50, 50);
            btn_2.TabIndex = 6;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = true;
            btn_2.Click += Number_click;
            // 
            // btn_3
            // 
            btn_3.Location = new Point(125, 289);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(50, 50);
            btn_3.TabIndex = 7;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = true;
            btn_3.Click += Number_click;
            // 
            // btn_plus
            // 
            btn_plus.BackColor = SystemColors.ActiveCaption;
            btn_plus.Location = new Point(181, 289);
            btn_plus.Name = "btn_plus";
            btn_plus.Size = new Size(50, 50);
            btn_plus.TabIndex = 8;
            btn_plus.Text = "+";
            btn_plus.UseVisualStyleBackColor = false;
            btn_plus.Click += Btn_plus_Click;
            // 
            // btn_4
            // 
            btn_4.Location = new Point(13, 233);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(50, 50);
            btn_4.TabIndex = 9;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = true;
            btn_4.Click += Number_click;
            // 
            // btn_5
            // 
            btn_5.Location = new Point(69, 233);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(50, 50);
            btn_5.TabIndex = 10;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = true;
            btn_5.Click += Number_click;
            // 
            // btn_6
            // 
            btn_6.Location = new Point(125, 233);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(50, 50);
            btn_6.TabIndex = 11;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = true;
            btn_6.Click += Number_click;
            // 
            // btn_mins
            // 
            btn_mins.BackColor = SystemColors.ActiveCaption;
            btn_mins.Location = new Point(181, 233);
            btn_mins.Name = "btn_mins";
            btn_mins.Size = new Size(50, 50);
            btn_mins.TabIndex = 12;
            btn_mins.Text = "-";
            btn_mins.UseVisualStyleBackColor = false;
            btn_mins.Click += Btn_mins_Click;
            // 
            // btn_multi
            // 
            btn_multi.BackColor = SystemColors.ActiveCaption;
            btn_multi.Location = new Point(181, 177);
            btn_multi.Name = "btn_multi";
            btn_multi.Size = new Size(50, 50);
            btn_multi.TabIndex = 16;
            btn_multi.Text = "*";
            btn_multi.UseVisualStyleBackColor = false;
            btn_multi.Click += Btn_multi_Click;
            // 
            // btn_9
            // 
            btn_9.Location = new Point(125, 177);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(50, 50);
            btn_9.TabIndex = 15;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = true;
            btn_9.Click += Number_click;
            // 
            // btn_8
            // 
            btn_8.Location = new Point(69, 177);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(50, 50);
            btn_8.TabIndex = 14;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = true;
            btn_8.Click += Number_click;
            // 
            // btn_7
            // 
            btn_7.Location = new Point(13, 177);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(50, 50);
            btn_7.TabIndex = 13;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = true;
            btn_7.Click += Number_click;
            // 
            // btn_divide
            // 
            btn_divide.BackColor = SystemColors.ActiveCaption;
            btn_divide.Location = new Point(181, 121);
            btn_divide.Name = "btn_divide";
            btn_divide.Size = new Size(50, 50);
            btn_divide.TabIndex = 17;
            btn_divide.Text = "÷";
            btn_divide.UseVisualStyleBackColor = false;
            btn_divide.Click += Btn_divide_Click;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.Gray;
            btn_clear.Location = new Point(69, 121);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(50, 50);
            btn_clear.TabIndex = 18;
            btn_clear.Text = "C";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += Btn_clear_Click;
            // 
            // btn_clear_current
            // 
            btn_clear_current.BackColor = Color.Gray;
            btn_clear_current.Location = new Point(13, 121);
            btn_clear_current.Name = "btn_clear_current";
            btn_clear_current.Size = new Size(50, 50);
            btn_clear_current.TabIndex = 19;
            btn_clear_current.Text = "CE";
            btn_clear_current.UseVisualStyleBackColor = false;
            btn_clear_current.Click += Btn_clear_current_Click;
            // 
            // btn_clear_element
            // 
            btn_clear_element.BackColor = Color.Gray;
            btn_clear_element.Location = new Point(125, 121);
            btn_clear_element.Name = "btn_clear_element";
            btn_clear_element.Size = new Size(50, 50);
            btn_clear_element.TabIndex = 20;
            btn_clear_element.Text = "<";
            btn_clear_element.UseVisualStyleBackColor = false;
            btn_clear_element.Click += Btn_clear_element_Click;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(243, 403);
            Controls.Add(btn_clear_element);
            Controls.Add(btn_clear_current);
            Controls.Add(btn_clear);
            Controls.Add(btn_divide);
            Controls.Add(btn_multi);
            Controls.Add(btn_9);
            Controls.Add(btn_8);
            Controls.Add(btn_7);
            Controls.Add(btn_mins);
            Controls.Add(btn_6);
            Controls.Add(btn_5);
            Controls.Add(btn_4);
            Controls.Add(btn_plus);
            Controls.Add(btn_3);
            Controls.Add(btn_2);
            Controls.Add(btn_1);
            Controls.Add(btn_equal);
            Controls.Add(btn_dot);
            Controls.Add(btn_0);
            Controls.Add(btn_cls);
            Controls.Add(screen_txt);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "CalculatorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CalculatorForm";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox screen_txt;
        private Button btn_cls;
        private Button btn_0;
        private Button btn_dot;
        private Button btn_equal;
        private Button btn_1;
        private Button btn_2;
        private Button btn_3;
        private Button btn_plus;
        private Button btn_4;
        private Button btn_5;
        private Button btn_6;
        private Button btn_mins;
        private Button btn_multi;
        private Button btn_9;
        private Button btn_8;
        private Button btn_7;
        private Button btn_divide;
        private Button btn_clear;
        private Button btn_clear_current;
        private Button btn_clear_element;
    }
}