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

namespace LeonComputing_GUI
{
    public partial class PartnerForm : Form
    {
        private readonly BusinessBL businessBL;
        List<BusinessBE> businesses;
        int rowSelected = -1;
        public PartnerForm()
        {
            InitializeComponent();
            CenterToScreen();
            businessBL = new BusinessBL();
            populateBusinessTable();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void populateBusinessTable()
        {
            businessDtGrdView.Rows.Clear();
            if (!searchTxt.Text.Equals("") && searchTxt.Text.Length > 2)
            {
                businesses = this.businessBL.Search(searchTxt.Text);
            } else
            {
                businesses = this.businessBL.getAll();
            }
            foreach (BusinessBE business in businesses)
            {
                businessDtGrdView.Rows.Add(business.Id, business.Name, business.Url, business.Type_id, business.Code_id, business.Ubigeo_code, business.Address, business.Phone, business.Email);
            }

        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            BusinessCreate f1 = new BusinessCreate();
            Hide();
            f1.ShowDialog();
            Close();
        }

        private void businessDtGrdView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (businesses.Count > e.RowIndex && e.RowIndex + 1 > 0)
            {
                rowSelected = e.RowIndex;
                selectedCellLbl.Text = $"ID seleccionado: {businesses[rowSelected].Id}";
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
            Common.BusinessEditingId = businesses[rowSelected].Id;
            BusinessCreate f1 = new BusinessCreate();
            Hide();
            f1.ShowDialog();
            Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            BusinessBE business = businesses[rowSelected];
            DialogResult dialogResult = MessageBox.Show($"Estas seguro que quieres borrar esta empresa:\n {business.Name} - {business.Code_id}" , "Borrar empresa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool deleted = businessBL.Delete(business.Id);
                if (deleted)
                {
                    MessageBox.Show("Borrado Correctamente", "Empresa Borrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    populateBusinessTable();

                } else
                {
                    MessageBox.Show("No se pudo borrar la empresa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            populateBusinessTable();
        }
    }
}
