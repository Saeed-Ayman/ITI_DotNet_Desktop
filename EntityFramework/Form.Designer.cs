namespace EntityFramework
{
    partial class Form
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
            dataGridView = new DataGridView();
            searchLable = new Label();
            searchTb = new TextBox();
            panel1 = new Panel();
            fnameTb = new TextBox();
            fnameLabel = new Label();
            lnameTb = new TextBox();
            lnameLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            birthdatePic = new DateTimePicker();
            comboBox1 = new ComboBox();
            insertBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 12);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(504, 504);
            dataGridView.TabIndex = 0;
            // 
            // searchLable
            // 
            searchLable.AutoSize = true;
            searchLable.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            searchLable.ForeColor = Color.White;
            searchLable.Location = new Point(568, 27);
            searchLable.Margin = new Padding(0);
            searchLable.Name = "searchLable";
            searchLable.Size = new Size(80, 29);
            searchLable.TabIndex = 1;
            searchLable.Text = "Search";
            // 
            // searchTb
            // 
            searchTb.Location = new Point(568, 61);
            searchTb.Name = "searchTb";
            searchTb.Size = new Size(305, 27);
            searchTb.TabIndex = 2;
            searchTb.TextChanged += SearchTb_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(570, 109);
            panel1.Name = "panel1";
            panel1.Size = new Size(303, 1);
            panel1.TabIndex = 3;
            // 
            // fnameTb
            // 
            fnameTb.Location = new Point(568, 161);
            fnameTb.Name = "fnameTb";
            fnameTb.Size = new Size(305, 27);
            fnameTb.TabIndex = 5;
            // 
            // fnameLabel
            // 
            fnameLabel.AutoSize = true;
            fnameLabel.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            fnameLabel.ForeColor = Color.White;
            fnameLabel.Location = new Point(567, 128);
            fnameLabel.Name = "fnameLabel";
            fnameLabel.Size = new Size(122, 29);
            fnameLabel.TabIndex = 4;
            fnameLabel.Text = "First Name";
            // 
            // lnameTb
            // 
            lnameTb.Location = new Point(568, 239);
            lnameTb.Name = "lnameTb";
            lnameTb.Size = new Size(305, 27);
            lnameTb.TabIndex = 7;
            // 
            // lnameLabel
            // 
            lnameLabel.AutoSize = true;
            lnameLabel.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lnameLabel.ForeColor = Color.White;
            lnameLabel.Location = new Point(566, 206);
            lnameLabel.Name = "lnameLabel";
            lnameLabel.Size = new Size(118, 29);
            lnameLabel.TabIndex = 6;
            lnameLabel.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(567, 284);
            label2.Name = "label2";
            label2.Size = new Size(107, 29);
            label2.TabIndex = 8;
            label2.Text = "Birthdate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(567, 366);
            label3.Name = "label3";
            label3.Size = new Size(135, 29);
            label3.TabIndex = 10;
            label3.Text = "Department";
            // 
            // birthdatePic
            // 
            birthdatePic.DropDownAlign = LeftRightAlignment.Right;
            birthdatePic.Location = new Point(568, 317);
            birthdatePic.MaxDate = new DateTime(2023, 9, 10, 0, 0, 0, 0);
            birthdatePic.Name = "birthdatePic";
            birthdatePic.Size = new Size(305, 27);
            birthdatePic.TabIndex = 12;
            birthdatePic.Value = new DateTime(2023, 9, 10, 0, 0, 0, 0);
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(568, 399);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(305, 27);
            comboBox1.TabIndex = 13;
            // 
            // insertBtn
            // 
            insertBtn.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            insertBtn.Location = new Point(568, 464);
            insertBtn.Name = "insertBtn";
            insertBtn.Size = new Size(305, 36);
            insertBtn.TabIndex = 14;
            insertBtn.Text = "Insert";
            insertBtn.UseVisualStyleBackColor = true;
            insertBtn.Click += InsertBtn_Click;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(914, 528);
            Controls.Add(insertBtn);
            Controls.Add(comboBox1);
            Controls.Add(birthdatePic);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lnameTb);
            Controls.Add(lnameLabel);
            Controls.Add(fnameTb);
            Controls.Add(fnameLabel);
            Controls.Add(panel1);
            Controls.Add(searchTb);
            Controls.Add(searchLable);
            Controls.Add(dataGridView);
            Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form";
            Load += Form_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Label searchLable;
        private TextBox searchTb;
        private Panel panel1;
        private TextBox fnameTb;
        private Label fnameLabel;
        private TextBox lnameTb;
        private Label lnameLabel;
        private Label label2;
        private Label label3;
        private DateTimePicker birthdatePic;
        private ComboBox comboBox1;
        private Button insertBtn;
    }
}