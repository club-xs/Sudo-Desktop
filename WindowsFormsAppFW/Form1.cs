using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppFW
{
    public partial class Form1 : Form
    {
        DataTable data = new DataTable();
        String name;
        String designation;
        String salary;

        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
             name = txtName.Text;
             designation = txtDesignation.Text;
             salary = txtSalary.Text;

            if(!name.Equals("") && !designation.Equals("") && !salary.Equals(""))
            {
                //MessageBox.Show(" Your name is " + name +"\n Designation: " + designation + "\n Salary: " + salary);
                display();
                clear();
            }
            else
            {
                MessageBox.Show("Missing info");
            }
            
        }

        public void display()
        {
            data.Columns.Add(" Name ");
            data.Columns.Add(" Designation ");
            data.Columns.Add(" Salary");

            DataRow dataRow = data.NewRow();
            dataRow[0] = name;
            dataRow[1] = designation;
            dataRow[2] = salary;

            data.Rows.Add(dataRow);
            dataGridView.DataSource = data;
        }

        public void clear()
        {
            txtName.Text = "";
            txtDesignation.Text = "";
            txtSalary.Text = "";
        }
    }
}
