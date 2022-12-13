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
using LeonComputing_GUI.Event;

namespace LeonComputing_GUI
{
    public partial class EventForm : Form
    {
        private readonly EventBL eventBL;
        List<EventBE> events;
        int rowSelected = -1;
        public EventForm()
        {
            InitializeComponent();
            CenterToScreen();
            eventBL = new EventBL();
            populateEventTable();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void populateEventTable()
        {
            eventDtGrdView.Rows.Clear();
            if (!searchTxt.Text.Equals("") && searchTxt.Text.Length > 2)
            {
                events = this.eventBL.Search(searchTxt.Text);
            } else
            {
                events = this.eventBL.getAll();
            }
            foreach (EventBE evt in events)
            {
                eventDtGrdView.Rows.Add(evt.Id, evt.Name, evt.Started_time, evt.Ended_time, evt.Frecuency, evt.Part_day, evt.Budget, evt.Address, evt.Postal_code, evt.Capacity);
            }

        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            EventCreate f1 = new EventCreate();
            Hide();
            f1.ShowDialog();
            Close();
        }

        private void eventDtGrdView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (events.Count > e.RowIndex && e.RowIndex + 1 > 0)
            {
                rowSelected = e.RowIndex;
                selectedCellLbl.Text = $"ID seleccionado: {events[rowSelected].Id}";
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
            Common.EventEditingId = events[rowSelected].Id;
            EventCreate f1 = new EventCreate();
            Hide();
            f1.ShowDialog();
            Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            EventBE evt = events[rowSelected];
            DialogResult dialogResult = MessageBox.Show($"Estas seguro que quieres borrar:\n {evt.Name}" , "Borrar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool deleted = eventBL.Delete(evt.Id);
                if (deleted)
                {
                    MessageBox.Show("Borrado Correctamente", "Borrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    populateEventTable();

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
            populateEventTable();
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
