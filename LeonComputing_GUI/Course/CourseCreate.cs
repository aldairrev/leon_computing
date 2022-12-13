using LeonComputing_BE;
using LeonComputing_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeonComputing_GUI.Course
{
    public partial class CourseCreate : Form
    {
        CourseBL courseBL = null;
        public CourseCreate()
        {
            InitializeComponent();
            CenterToScreen();
            courseBL = new CourseBL();

            if (!(Common.CourseEditingId is null))
            {
                CourseBE course = courseBL.FindById(Common.CourseEditingId ?? 0);
                idTxt.Text = course.Id.ToString();
                nameTxt.Text = course.Name;
                hoursTheoryTxt.Text = course.Hours_theory.ToString();
                hoursPracticeTxt.Text = course.Hours_practice.ToString();
                levelTxt.Text = course.Level.ToString();
                descriptionTxt.Text= course.Description;
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            string hours_practice = hoursPracticeTxt.Text;
            string hours_theory = hoursTheoryTxt.Text;
            string level = hoursPracticeTxt.Text;
            string description = descriptionTxt.Text;

            if (CheckValueFromTextBox(name) && CheckValueFromTextBox(hours_practice) && CheckValueFromTextBox(hours_theory) && CheckValueFromTextBox(level))
            {
                CourseBE course = new CourseBE();
                course.Name = name;
                course.Hours_practice = int.Parse(hours_practice);
                course.Hours_theory = int.Parse(hours_theory);
                course.Level = level[0];
                course.Description = description;
                course.Updated_by = CurrentUser.Id;

                CourseBE newCourse;
                if (Common.CourseEditingId is null)
                {
                    course.Created_by = CurrentUser.Id;
                    Console.WriteLine(course.ToString());
                    newCourse = courseBL.Create(course);
                    if (!(newCourse is null))
                    {
                        MessageBox.Show("Creado", "Fue creado exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CourseForm f2 = new CourseForm();
                        Hide();
                        f2.ShowDialog();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Problema creando", "Hubo un problema creando", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                } else
                {
                    course.Id = Common.CourseEditingId ?? 0;
                    newCourse = courseBL.Update(course);
                    if (!(newCourse is null))
                    {
                        Common.CourseEditingId = null;
                        MessageBox.Show("Actualizado", "Fue actualizado exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CourseForm f2 = new CourseForm();
                        Hide();
                        f2.ShowDialog();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Problema actualizando", "Hubo un problema creando", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            } else
            {
                MessageBox.Show("Falta data requeridos", "No se pudo crear/actualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool CheckValueFromTextBox(string value)
        {
            if (value == null)
            {
                return false;
            }
            if (value == "")
            {
                return false;
            }
            return true;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            CourseForm f2 = new CourseForm();
            Hide();
            f2.ShowDialog();
            Close();
        }
    }
}
