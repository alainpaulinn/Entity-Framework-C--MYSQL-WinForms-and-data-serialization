using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excellent_International_School_Student_List_EF
{
    public partial class Form1 : Form
    {
        studentTable student = new studentTable();
        alainEntityFrameworkEntities db;
        public bool edittable;
        public Form1()
        {
            InitializeComponent();

            Rectangle r = new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            int d = 20;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            pictureBox1.Region = new Region(gp);

            var bmp = new Bitmap(Properties.Resources.Off80x25);
            pictureBox1.Image = bmp;
            edittable = false;
            savebtn.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            newstudentbtn.Enabled = false;
            button1.Enabled = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (edittable == false) { IsEdittable(false); }
            else { IsEdittable(true); }
        }

        private void IsEdittable(bool edit)
        {
            switch (edit)
            {
                case true:
                    var bmpOff = new Bitmap(Properties.Resources.Off80x25);
                    pictureBox1.Image = bmpOff;
                    edittable = false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                    savebtn.Enabled = false;
                    newstudentbtn.Enabled = false;
                    button1.Enabled = false;
                    break;
                case false:
                    var bmpOn = new Bitmap(Properties.Resources.On80x25);
                    pictureBox1.Image = bmpOn;
                    edittable = true;
                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                    textBox3.Enabled = false;
                    textBox4.Enabled = true;
                    savebtn.Enabled = true;
                    newstudentbtn.Enabled = true;
                    button1.Enabled = true;
                    break;

            }
        }

        private void newstudentbtn_Click(object sender, EventArgs e)
        {
            switch (newstudentbtn.Text)
            {
                case "Enter New Student":
                    studentTableBindingSource.SuspendBinding();
                    textBox1.Text = textBox2.Text = textBox4.Text = null;
                    textBox3.Text =  Convert.ToString(db.studentTables.Max(p => p.id)+1);
                    newstudentbtn.Text = "Confirm New Student";
                    dataGridView1.ClearSelection();
                    break;
                case "Confirm New Student":
                    
                    newstudentbtn.Text = "Enter New Student";

                    student.firstName = textBox1.Text.Trim();
                    student.lastName = textBox2.Text.Trim();
                    student.id = Convert.ToInt32(textBox3.Text.Trim());
                    student.country = textBox4.Text.Trim();
                    using (alainEntityFrameworkEntities dba = new alainEntityFrameworkEntities())
                    {
                        dba.studentTables.Add(student);
                        dba.SaveChanges();
                    }
                    studentTableBindingSource.ResumeBinding();
                    studentTableBindingSource.Add(student);
                    break;
            }
            /*
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = null;
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;

            studentTableBindingSource.SuspendBinding();

            //studentTable studenttable = new studentTable();
            //studenttable.firstName = textBox1.Text.Trim();
            //studenttable.lastName = textBox2.Text.Trim();
            //studenttable.id = Convert.ToInt32(textBox3.Text.Trim());   Auto incremented
            //studenttable.country = textBox4.Text.Trim();
            /*using (alainEntityFrameworkEntities db = new alainEntityFrameworkEntities())
            {
                db.studentTables.Add(studenttable);
                db.SaveChanges();
            }*/
            //MessageBox.Show("successfully added " + studenttable.firstName + " " + studenttable.lastName); 
            //studentTableBindingSource.DataSource = db.studentTables.ToList();

            //using (alainEntityFrameworkEntities dba = new alainEntityFrameworkEntities())
            //{
            //    dba.studentTables.Add(studenttable);
            //    dba.SaveChanges();
            //}  
            /* studentTable newAdd = new studentTable();
            newAdd.firstName = textBox1.Text;
            newAdd.lastName = textBox1.Text;
            newAdd.country = textBox1.Text;
            studentTableBindingSource.Add(newAdd);
            studentTableBindingSource.ResumeBinding(); */
        }

        private void studentListcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            db = new alainEntityFrameworkEntities();
            studentTableBindingSource.DataSource = db.studentTables.ToList();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(studentTableBindingSource.Current != null)
            {
                if(MessageBox.Show($"Are you sure to delete{textBox1.Text} {textBox2.Text}?"," Warning: Deletion", MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
                {
                    db.studentTables.Remove(studentTableBindingSource.Current as studentTable);
                    studentTableBindingSource.RemoveCurrent();
                    //db.SaveChanges();
                }
            }
        }
        /*public addStudent(object obj)
{
db = new alainEntityFrameworkEntities();

}*/
    }
}

