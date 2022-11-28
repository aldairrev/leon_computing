using LeonComputing_BE;
using LeonComputing_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using Spire.Xls;

namespace LeonComputing_GUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            SetupComponent();
        }

        private void SetupComponent()
        {
            welcomeLbl.Text =
                "Bienvenido " + CurrentUser.Username + "!";
        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateExcelBusinesses();
        }

        private void CreateExcelBusinesses()
        {
            BusinessBL businessBL = new BusinessBL();
            List<BusinessBE> businesses = businessBL.getAll();

            var workbook = new XLWorkbook();
            var ws = workbook.Worksheets.Add("Empresas");

            int i = 1;
            foreach (var business in businesses)
            {
                ws.Cell(i, 1).Value = business.Id;
                ws.Cell(i, 2).Value = business.Name;
                ws.Cell(i, 3).Value = business.Email;
                ws.Cell(i, 4).Value = business.Code_id;
                ws.Cell(i, 5).Value = business.Created_at;
                i++;
            }

            string prefix_time = DateTime.Now.Year.ToString() +
                "_" + DateTime.Now.Month.ToString() +
                "_" + DateTime.Now.Day.ToString();

            using (
                    SaveFileDialog sfd = new SaveFileDialog() {
                        FileName= prefix_time + "_empresas",
                        Filter = "Excel Worbook|*.xlsx"
                    }
                )
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(sfd.FileName);
                }
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CurrentUser.Firstname = null;
            CurrentUser.Middle_name = null;
            CurrentUser.Lastname = null;
            CurrentUser.Lastname_second = null;
            CurrentUser.Username = null;
            CurrentUser.Birthday = null;
            CurrentUser.Email = null;
            Login f1 = new Login();
            Hide();
            f1.ShowDialog();
            Close();
        }

        private void businessesBtn_Click(object sender, EventArgs e)
        {
            BusinessForm f1 = new BusinessForm();
            Hide();
            f1.ShowDialog();
            Close();
        }

        private void coursesBtn_Click(object sender, EventArgs e)
        {
            CourseForm f1 = new CourseForm();
            Hide();
            f1.ShowDialog();
            Close();
        }
    }
}
