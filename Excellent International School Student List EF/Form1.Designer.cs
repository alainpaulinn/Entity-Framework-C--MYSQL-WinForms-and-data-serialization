namespace Excellent_International_School_Student_List_EF
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.countrylbl = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.idlbl = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.surnamelbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.namelbl = new System.Windows.Forms.Label();
            this.controllbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.newstudentbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentTableBindingSource, "country", true));
            this.textBox4.Location = new System.Drawing.Point(583, 111);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(311, 20);
            this.textBox4.TabIndex = 55;
            // 
            // countrylbl
            // 
            this.countrylbl.AutoSize = true;
            this.countrylbl.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.countrylbl.Location = new System.Drawing.Point(526, 114);
            this.countrylbl.Name = "countrylbl";
            this.countrylbl.Size = new System.Drawing.Size(43, 13);
            this.countrylbl.TabIndex = 54;
            this.countrylbl.Text = "Country";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentTableBindingSource, "id", true));
            this.textBox3.Location = new System.Drawing.Point(583, 85);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(311, 20);
            this.textBox3.TabIndex = 53;
            // 
            // idlbl
            // 
            this.idlbl.AutoSize = true;
            this.idlbl.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.idlbl.Location = new System.Drawing.Point(538, 88);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(18, 13);
            this.idlbl.TabIndex = 52;
            this.idlbl.Text = "ID";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentTableBindingSource, "lastName", true));
            this.textBox2.Location = new System.Drawing.Point(583, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(311, 20);
            this.textBox2.TabIndex = 51;
            // 
            // surnamelbl
            // 
            this.surnamelbl.AutoSize = true;
            this.surnamelbl.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.surnamelbl.Location = new System.Drawing.Point(518, 62);
            this.surnamelbl.Name = "surnamelbl";
            this.surnamelbl.Size = new System.Drawing.Size(58, 13);
            this.surnamelbl.TabIndex = 50;
            this.surnamelbl.Text = "Last Name";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentTableBindingSource, "firstName", true));
            this.textBox1.Location = new System.Drawing.Point(583, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(311, 20);
            this.textBox1.TabIndex = 49;
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.namelbl.Location = new System.Drawing.Point(519, 36);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(57, 13);
            this.namelbl.TabIndex = 48;
            this.namelbl.Text = "First Name";
            // 
            // controllbl
            // 
            this.controllbl.AutoSize = true;
            this.controllbl.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.controllbl.Location = new System.Drawing.Point(12, 9);
            this.controllbl.Name = "controllbl";
            this.controllbl.Size = new System.Drawing.Size(308, 13);
            this.controllbl.TabIndex = 46;
            this.controllbl.Text = "Welcome to Excellence International School StudentList Control";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(847, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 24);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(786, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Edit Mode";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(741, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "Delete Student";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.savebtn.Location = new System.Drawing.Point(584, 183);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(151, 23);
            this.savebtn.TabIndex = 40;
            this.savebtn.Text = "Save All Changes";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // newstudentbtn
            // 
            this.newstudentbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.newstudentbtn.Location = new System.Drawing.Point(584, 221);
            this.newstudentbtn.Name = "newstudentbtn";
            this.newstudentbtn.Size = new System.Drawing.Size(310, 23);
            this.newstudentbtn.TabIndex = 39;
            this.newstudentbtn.Text = "Enter New Student";
            this.newstudentbtn.UseVisualStyleBackColor = false;
            this.newstudentbtn.Click += new System.EventHandler(this.newstudentbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fullName,
            this.countryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(496, 230);
            this.dataGridView1.TabIndex = 57;
            // 
            // fullName
            // 
            this.fullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fullName.DataPropertyName = "fullName";
            this.fullName.HeaderText = "Full Name";
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // studentTableBindingSource
            // 
            this.studentTableBindingSource.DataSource = typeof(Excellent_International_School_Student_List_EF.studentTable);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(914, 262);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.countrylbl);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.idlbl);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.surnamelbl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.controllbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.newstudentbtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(930, 301);
            this.MinimumSize = new System.Drawing.Size(930, 301);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label countrylbl;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label idlbl;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label surnamelbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label controllbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button newstudentbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource studentTableBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
    }
}

