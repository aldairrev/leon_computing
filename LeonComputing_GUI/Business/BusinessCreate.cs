using DocumentFormat.OpenXml.Packaging;
using LeonComputing_BE;
using LeonComputing_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeonComputing_GUI.Business
{
    public partial class BusinessCreate : Form
    {
        BusinessBL businessBL = null;
        UbigeoBL ubigeoBL = null;
        DataTable departamentos = null;
        DataTable provincias = null;
        DataTable distritos = null;

        string departamentoId = null;
        string provinciaId = null;
        string distritoId = null;

        public BusinessCreate()
        {
            InitializeComponent();
            nameTxt.Focus();
            CenterToScreen();
            businessBL = new BusinessBL();
            ubigeoBL = new UbigeoBL();
            departamentos = ubigeoBL.Ubigeo_Departamentos();

            // populate departamentos
            foreach (DataRow row in departamentos.Rows)
            {
                departamentoCmbBox.Items.Add(row["id_departamento"] + " - " + row["departamento"]);
            }

            if (!(Common.BusinessEditingId is null))
            {
                BusinessBE business = businessBL.FindById(Common.BusinessEditingId ?? 0);
                idTxt.Text = business.Id.ToString();
                nameTxt.Text = business.Name;
                urlTxt.Text = business.Url;
                emailTxt.Text = business.Email;
                phoneTxt.Text = business.Phone;
                addressTxt.Text = business.Address;
                codeIdTxt.Text = business.Code_id;
                print(business.Ubigeo_code);
                DataTable ubigeo = ubigeoBL.getUbigeoById(business.Ubigeo_code.ToString());
                if (ubigeo.Rows.Count > 0)
                {
                    departamentoId = ubigeo.Rows[0]["id_departamento"].ToString();
                    departamentoCmbBox.SelectedIndex = departamentoCmbBox.FindString(departamentoId + " - " + ubigeo.Rows[0]["departamento"].ToString());
                    

                    provincias = ubigeoBL.Ubigeo_ProvinciasDepartamento(departamentoId);
                    foreach (DataRow row in provincias.Rows)
                    {
                        provinciaCmbBox.Items.Add(row["id_provincia"]+ " - " + row["provincia"]);
                    }
                    provinciaId = ubigeo.Rows[0]["id_provincia"].ToString();
                    provinciaCmbBox.SelectedIndex = provinciaCmbBox.FindString(provinciaId + " - " + ubigeo.Rows[0]["provincia"].ToString());
                    

                    distritos = ubigeoBL.Ubigeo_DistritosProvinciaDepartamento(departamentoId, provinciaId);
                    foreach (DataRow row in distritos.Rows)
                    {
                        distritoCmbBox.Items.Add(row["id_distrito"] + " - " + row["distrito"]);
                    }
                    distritoId = ubigeo.Rows[0]["id_distrito"].ToString();
                    distritoCmbBox.SelectedIndex = distritoCmbBox.FindString(distritoId + " - " + ubigeo.Rows[0]["distrito"].ToString());
                }
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
            departamentoId = departamentos.Rows[departamentoCmbBox.SelectedIndex]["id_departamento"].ToString();
            provinciaId = provincias.Rows[provinciaCmbBox.SelectedIndex]["id_provincia"].ToString();
            distritoId = distritos.Rows[distritoCmbBox.SelectedIndex]["id_distrito"].ToString();

            string ubigeo_code = departamentoId + provinciaId + distritoId;
            if (departamentoId.Equals("") && provinciaId.Equals("") && distritoId.Equals(""))
            {
                MessageBox.Show("Ubigeo: " + ubigeo_code, "Ubigeo No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!Regex.IsMatch(codeIdTxt.Text, @"^\d+$") || codeIdTxt.Text.Length >= 12 || codeIdTxt.Text.Length <= 10)
            {
                MessageBox.Show("El ruc debe ser de 11 digitos", "RUC Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string name = nameTxt.Text;
            string url = urlTxt.Text;
            string code_id = codeIdTxt.Text;
            
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void departamentoCmbBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            departamentoId = departamentos.Rows[departamentoCmbBox.SelectedIndex]["id_departamento"].ToString();

            provincias = ubigeoBL.Ubigeo_ProvinciasDepartamento(departamentoId);
            provinciaCmbBox.Text = "";
            distritoCmbBox.Text = "";
            provinciaCmbBox.Items.Clear();
            foreach (DataRow row in provincias.Rows)
            {
                provinciaCmbBox.Items.Add(row["id_provincia"] + " - " + row["provincia"]);
            }
        }

        private void provinciaCmbBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            provinciaId = provincias.Rows[provinciaCmbBox.SelectedIndex]["id_provincia"].ToString();
    
            distritos = ubigeoBL.Ubigeo_DistritosProvinciaDepartamento(departamentoId, provinciaId);
            distritoCmbBox.Items.Clear();
            distritoCmbBox.Text = "";
            foreach (DataRow row in distritos.Rows)
            {
                distritoCmbBox.Items.Add(row["id_distrito"] + " - " + row["distrito"]);
            }
        }

        private void distritoCmbBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            distritoId = distritos.Rows[distritoCmbBox.SelectedIndex]["id_distrito"].ToString();
        }
        
        private void print(string text)
        {
            MessageBox.Show(text, "LOG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
