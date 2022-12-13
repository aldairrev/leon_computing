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

namespace LeonComputing_GUI.Business
{
    public partial class BusinessCreate : Form
    {
        BusinessBL businessBL = null;
        public BusinessCreate()
        {
            InitializeComponent();
            CenterToScreen();
            businessBL = new BusinessBL();

            if (!(Common.BusinessEditingId is null))
            {
                BusinessBE business = businessBL.FindById(Common.BusinessEditingId ?? 0);
                idTxt.Text = business.Id.ToString();
                nameTxt.Text = business.Name;
                urlTxt.Text = business.Url;
                ubigeoCodeTxt.Text = business.Ubigeo_code;
                emailTxt.Text = business.Email;
                phoneTxt.Text = business.Phone;
                addressTxt.Text = business.Address;
                codeIdTxt.Text = business.Code_id;
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void flowLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            string url = urlTxt.Text;
            string code_id = codeIdTxt.Text;
            string ubigeo_code = ubigeoCodeTxt.Text;
            string address = addressTxt.Text;
            string email = emailTxt.Text;
            string phone= phoneTxt.Text;

            if (CheckValueFromTextBox(name) && CheckValueFromTextBox(code_id))
            {
                BusinessBE business = new BusinessBE();
                business.Name = name;
                business.Url = url;
                business.Type_id = "RUC";
                business.Code_id = code_id;
                business.Ubigeo_code = ubigeo_code;
                business.Updated_by = CurrentUser.Id;
                business.Updated_at = DateTime.Now;
                business.Address = address;
                business.Email = email;
                business.Phone = phone;

                BusinessBE newBusiness;
                if (Common.BusinessEditingId is null)
                {
                    business.Created_by = CurrentUser.Id;
                    newBusiness = businessBL.Create(business);
                    if (!(newBusiness is null))
                    {
                        MessageBox.Show("Negocio Creado", "El negocio fue creado exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BusinessForm f2 = new BusinessForm();
                        Hide();
                        f2.ShowDialog();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Problema creando", "Hubo un problema creando en el negocio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                } else
                {
                    business.Id = Common.BusinessEditingId ?? 0;
                    newBusiness = businessBL.Update(business);
                    if (!(newBusiness is null))
                    {
                        Common.BusinessEditingId = null;
                        MessageBox.Show("Negocio Actualizado", "El negocio fue actulizado exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BusinessForm f2 = new BusinessForm();
                        Hide();
                        f2.ShowDialog();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Problema actualizando", "Hubo un problema creando en el negocio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            } else
            {
                MessageBox.Show("Falta data requeridos", "No se pudo crear/actualizad la empres", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (value.Length < 3)
            {
                return false;
            }
            return true;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            BusinessForm f2 = new BusinessForm();
            Hide();
            f2.ShowDialog();
            Close();
        }
    }
}
