using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LeonComputing_BL;
using LeonComputing_BE;

namespace LeonComputing_GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            loginBtn.Enabled = false;
            string username = usernameTxt.Text;
            string password = passwordTxt.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Campos vacios de usuario o contrase�a", "Credenciales vacios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loginBtn.Enabled = true;
                return;
            }

            try
            {
                AuthBL authBL = new AuthBL();
                UserBE userAuth = authBL.attempt(username, password);

                if (!(userAuth is null))
                {
                    CurrentUser.Id= userAuth.Id;
                    CurrentUser.Firstname= userAuth.Firstname;
                    CurrentUser.Middle_name= userAuth.Middle_name;
                    CurrentUser.Lastname = userAuth.Lastname;
                    CurrentUser.Lastname_second= userAuth.Lastname_second;
                    CurrentUser.Username= userAuth.Username;
                    CurrentUser.Birthday = userAuth.Birthday;
                    CurrentUser.Email = userAuth.Email;

                    MessageBox.Show("Hi " + userAuth.Firstname, "Conectado",  MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Dashboard f2 = new Dashboard();
                    Hide();
                    f2.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Las credenciales estan incorrectos", "No se pudo ingresar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                loginBtn.Enabled = true;
            }
        }
    }
}

