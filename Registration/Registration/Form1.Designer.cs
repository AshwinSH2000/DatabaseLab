namespace Registration
{
    partial class Form1
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
            this.srf = new System.Windows.Forms.Label();
            this.regno = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.regno_tb = new System.Windows.Forms.TextBox();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.dob = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Gender = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.branch = new System.Windows.Forms.Label();
            this.branch_box = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.subjects = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // srf
            // 
            this.srf.AutoSize = true;
            this.srf.Location = new System.Drawing.Point(220, 41);
            this.srf.Name = "srf";
            this.srf.Size = new System.Drawing.Size(129, 13);
            this.srf.TabIndex = 0;
            this.srf.Text = "Student Registration Form";
            this.srf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.srf.Click += new System.EventHandler(this.srf_Click);
            // 
            // regno
            // 
            this.regno.AutoSize = true;
            this.regno.Location = new System.Drawing.Point(92, 113);
            this.regno.Name = "regno";
            this.regno.Size = new System.Drawing.Size(106, 13);
            this.regno.TabIndex = 1;
            this.regno.Text = "Registration Number:";
            this.regno.Click += new System.EventHandler(this.regno_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(92, 138);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(38, 13);
            this.name.TabIndex = 2;
            this.name.Text = "Name:";
            // 
            // regno_tb
            // 
            this.regno_tb.AcceptsReturn = true;
            this.regno_tb.Location = new System.Drawing.Point(210, 110);
            this.regno_tb.Name = "regno_tb";
            this.regno_tb.Size = new System.Drawing.Size(100, 20);
            this.regno_tb.TabIndex = 3;
            this.regno_tb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(210, 137);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(100, 20);
            this.name_tb.TabIndex = 4;
            this.name_tb.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // dob
            // 
            this.dob.AutoSize = true;
            this.dob.Location = new System.Drawing.Point(356, 110);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(33, 13);
            this.dob.TabIndex = 5;
            this.dob.Text = "DOB:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(395, 107);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 6;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(92, 174);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(45, 13);
            this.Gender.TabIndex = 7;
            this.Gender.Text = "Gender:";
            this.Gender.Click += new System.EventHandler(this.Gender_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(0, 0);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(223, 172);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(48, 17);
            this.male.TabIndex = 9;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            this.male.CheckedChanged += new System.EventHandler(this.male_CheckedChanged);
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(277, 172);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(59, 17);
            this.female.TabIndex = 10;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // branch
            // 
            this.branch.AutoSize = true;
            this.branch.Location = new System.Drawing.Point(92, 207);
            this.branch.Name = "branch";
            this.branch.Size = new System.Drawing.Size(44, 13);
            this.branch.TabIndex = 11;
            this.branch.Text = "Branch:";
            this.branch.Click += new System.EventHandler(this.branch_Click);
            // 
            // branch_box
            // 
            this.branch_box.FormattingEnabled = true;
            this.branch_box.Items.AddRange(new object[] {
            "CSE",
            "IT",
            "CCE",
            "ECE",
            "EEE"});
            this.branch_box.Location = new System.Drawing.Point(208, 207);
            this.branch_box.Name = "branch_box";
            this.branch_box.Size = new System.Drawing.Size(102, 21);
            this.branch_box.TabIndex = 12;
            this.branch_box.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(208, 247);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 13;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // subjects
            // 
            this.subjects.AutoSize = true;
            this.subjects.Location = new System.Drawing.Point(92, 247);
            this.subjects.Name = "subjects";
            this.subjects.Size = new System.Drawing.Size(51, 13);
            this.subjects.TabIndex = 14;
            this.subjects.Text = "Subjects:";
            this.subjects.Click += new System.EventHandler(this.subjects_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(395, 171);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(162, 171);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "\n";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(684, 436);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.subjects);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.branch_box);
            this.Controls.Add(this.branch);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.regno_tb);
            this.Controls.Add(this.name);
            this.Controls.Add(this.regno);
            this.Controls.Add(this.srf);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label srf;
        private System.Windows.Forms.Label regno;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox regno_tb;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.Label dob;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.Label branch;
        private System.Windows.Forms.ComboBox branch_box;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label subjects;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

