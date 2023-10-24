using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void LoadStudents()
        {
            Student student1 = new Student()
            {
                Number = 12,
                Name = "Ali",
                Surname = "Veli",
                Point = 80
            };
            lbxStudents.Items.Add(student1);

            Student student2 = new Student()
            {
                Number = 26,
                Name = "Cem",
                Surname = "Ayaz",
                Point = 60
            };
            lbxStudents.Items.Add(student2);
            
            Student student3 = new Student()
            {
                Number = 55,
                Name = "Eda",
                Surname = "Erdem",
                Point = 50
            };
            lbxStudents.Items.Add(student3);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Student selected = lbxStudents.SelectedItem as Student;
            int index;
            if (selected == null)
            {
                //insert
                index = lbxStudents.Items.Count;
                selected =new Student();
                
            }
            else
            {
                //update
                index = lbxStudents.Items.IndexOf(selected);
                //lbxStudents.Items.Remove(selected);
                lbxStudents.Items.RemoveAt(index);
            }
            selected.Name = txtName.Text;
            selected.Surname = txtSurname.Text;
            selected.Number = int.Parse(txtNumber.Text);
            selected.Point = int.Parse(txtPoint.Text);

            MessageBox.Show("İşlem Tamam!");
            lbxStudents.Items.Insert(index, selected);
            ClearControls();
            
        }

        private void ClearControls()
        {
            lbxStudents.SelectedItem = null;
            btnSave.Text = "SAVE";
            btnDelete.Visible = false;

            //txtName.Text = txtNumber.Text = txtPoint.Text = txtSurname.Text = string.Empty;

            foreach (Control item in panel1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
            }
        }

        private void lbxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student selected = lbxStudents.SelectedItem as Student;
            if (selected == null) return;
            
            DisplayStudent(selected);
            btnSave.Text = "UPDATE";
            btnDelete.Visible = true;
        }

        private void DisplayStudent(Student selected)
        {
            txtName.Text = selected.Name;
            txtSurname.Text = selected.Surname;
            txtNumber.Text = selected.Number.ToString();
            txtPoint.Text = selected.Point.ToString();
        }

        
    }
}
