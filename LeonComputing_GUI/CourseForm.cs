using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LeonComputing_BE;
using LeonComputing_BL;
using LeonComputing_GUI.Business;
using LeonComputing_GUI.Course;

namespace LeonComputing_GUI
{
    public partial class CourseForm : Form
    {
        private readonly CourseBL courseBL;
        List<CourseBE> courses;
        int rowSelected = -1;
        public CourseForm()
        {
            InitializeComponent();
            CenterToScreen();
            courseBL = new CourseBL();
            populateCourseTable();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void populateCourseTable()
        {
            courseDtGrdView.Rows.Clear();
            if (!searchTxt.Text.Equals("") && searchTxt.Text.Length > 2)
            {
                courses = this.courseBL.Search(searchTxt.Text);
            } else
            {
                courses = this.courseBL.getAll();
            }
            foreach (CourseBE course in courses)
            {
                string level = "";

                if (course.Level == 'E')
                {
                    level = "Basico";
                }
                else if (course.Level == 'N')
                {
                    level = "Intermedio";
                }
                else if (course.Level == 'H')
                {
                    level = "Dificil";
                }
                courseDtGrdView.Rows.Add(course.Id, course.Name, course.Hours_practice, course.Hours_theory, level, course.Description);
            }

        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            CourseCreate f1 = new CourseCreate();
            Hide();
            f1.ShowDialog();
            Close();
        }

        private void courseDtGrdView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (courses.Count > e.RowIndex && e.RowIndex + 1 > 0)
            {
                rowSelected = e.RowIndex;
                selectedCellLbl.Text = $"ID seleccionado: {courses[rowSelected].Id}";
                editBtn.Enabled = true;
                deleteBtn.Enabled = true;
            } else
            {
                rowSelected = -1;
                selectedCellLbl.Text = $"";
                editBtn.Enabled = false;
                deleteBtn.Enabled = false;
            }
            
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            Common.CourseEditingId = courses[rowSelected].Id;
            CourseCreate f1 = new CourseCreate();
            Hide();
            f1.ShowDialog();
            Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            CourseBE course = courses[rowSelected];
            DialogResult dialogResult = MessageBox.Show($"Estas seguro que quieres borrar:\n {course.Name}" , "Borrar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool deleted = courseBL.Delete(course.Id);
                if (deleted)
                {
                    MessageBox.Show("Borrado Correctamente", "Borrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    populateCourseTable();

                } else
                {
                    MessageBox.Show("No se pudo borrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            Console.WriteLine("SEARCH: " + searchTxt.Text);
            populateCourseTable();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Dashboard f1 = new Dashboard();
            Hide();
            f1.ShowDialog();
            Close();
        }
    }
}
