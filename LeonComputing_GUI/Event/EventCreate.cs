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

namespace LeonComputing_GUI.Event
{
    public partial class EventCreate : Form
    {
        EventBL eventBL = null;
        public EventCreate()
        {
            InitializeComponent();
            CenterToScreen();
            eventBL = new EventBL();

            if (!(Common.EventEditingId is null))
            {
                EventBE evt = eventBL.FindById(Common.EventEditingId ?? 0);
                idTxt.Text = evt.Id.ToString();
                nameTxt.Text = evt.Name;
                startedTimeDtTmPicker.Value = evt.Started_time ?? DateTime.Now;
                endedTimeDtTmPicker.Value = evt.Ended_time ?? DateTime.Now;
                frecuencyTxt.Text = evt.Frecuency;
                budgetNumeric.Value = evt.Budget;
                addressTxt.Text = evt.Address;
                postalCodeTxt.Text = evt.Postal_code;
                capacityNumeric.Value = (decimal) evt.Capacity;
                partDayTxt.Text = evt.Part_day + "";
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            DateTime? startedTime = startedTimeDtTmPicker.Value;
            DateTime? endedTime = endedTimeDtTmPicker.Value;
            string frecuency = frecuencyTxt.Text;
            decimal budget = budgetNumeric.Value;
            string address = addressTxt.Text;
            string postal_code = postalCodeTxt.Text;
            int capacity = (int) capacityNumeric.Value;
            string part_day= partDayTxt.Text;

            if (!(startedTime is null) && !(endedTime is null) && CheckValueFromTextBox(frecuency) && part_day != String.Empty && budget > 0 && capacity > 0)
            {
                EventBE evt = new EventBE();
                evt.Name = name;
                evt.Started_time = startedTime;
                evt.Ended_time = endedTime;
                evt.Frecuency = frecuency;
                evt.Budget = budget;
                evt.Address = address;
                evt.Postal_code = postal_code;
                evt.Capacity = capacity;
                evt.Part_day = part_day[0];
                evt.Updated_by = CurrentUser.Id;

                EventBE newEvent;
                if (Common.EventEditingId is null)
                {
                    evt.Created_by = CurrentUser.Id;
                    Console.WriteLine(evt.ToString());
                    newEvent = eventBL.Create(evt);
                    if (!(newEvent is null))
                    {
                        MessageBox.Show("Creado", "Fue creado exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        EventForm f2 = new EventForm();
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
                    evt.Id = Common.EventEditingId ?? 0;
                    newEvent = eventBL.Update(evt);
                    if (!(newEvent is null))
                    {
                        Common.EventEditingId = null;
                        MessageBox.Show("Actualizado", "Fue actualizado exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        EventForm f2 = new EventForm();
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
            EventForm f2 = new EventForm();
            Hide();
            f2.ShowDialog();
            Close();
        }
    }
}
