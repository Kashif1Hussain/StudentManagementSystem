using StudentManagmentSystem.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagmentSystem
{
    public partial class Form1 : Form
    {
        StudentManager studentManager = new StudentManager();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Student std = studentManager.Search(txtRollNumber.Text);
            if(std == null)
            {
                MessageBox.Show("Not Found");
            }
            else
            {
                MessageBox.Show("Student Found");
                txtFirstName.Text = std.FirstName;
                txtLastName.Text = std.LastName;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            studentManager.Add(txtRollNumber.Text, txtFirstName.Text, txtLastName.Text);
            MessageBox.Show("Record added");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void LoadStudents()
        {
            BindingSource data = new BindingSource();
            data.DataSource = studentManager.GetAllStudent(); ;
            dgvStudents.DataSource = data;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            studentManager.Delete(txtRollNumber.Text);
            MessageBox.Show("Student Delete");
            LoadStudents();
        }
    }
}
