namespace LeonComputing_GUI
{
    partial class EventForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.searchLbl = new System.Windows.Forms.Label();
            this.eventDtGrdView = new System.Windows.Forms.DataGridView();
            this.createBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.selectedCellLbl = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.event_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.event_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.started_time_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ended_time_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frecuency_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.part_day_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budget_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postal_code_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacity_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.eventDtGrdView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTxt
            // 
            this.searchTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxt.Location = new System.Drawing.Point(12, 32);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(205, 27);
            this.searchTxt.TabIndex = 0;
            this.searchTxt.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl.Location = new System.Drawing.Point(12, 9);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(69, 20);
            this.searchLbl.TabIndex = 1;
            this.searchLbl.Text = "Buscar";
            // 
            // eventDtGrdView
            // 
            this.eventDtGrdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventDtGrdView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.event_id,
            this.event_name,
            this.started_time_column,
            this.ended_time_column,
            this.frecuency_column,
            this.part_day_column,
            this.budget_column,
            this.address_column,
            this.postal_code_column,
            this.capacity_column});
            this.eventDtGrdView.Location = new System.Drawing.Point(12, 65);
            this.eventDtGrdView.Name = "eventDtGrdView";
            this.eventDtGrdView.RowHeadersWidth = 51;
            this.eventDtGrdView.RowTemplate.Height = 24;
            this.eventDtGrdView.Size = new System.Drawing.Size(758, 476);
            this.eventDtGrdView.TabIndex = 2;
            this.eventDtGrdView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventDtGrdView_CellClick);
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(668, 32);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(102, 23);
            this.createBtn.TabIndex = 3;
            this.createBtn.Text = "Crear";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Enabled = false;
            this.editBtn.Location = new System.Drawing.Point(587, 31);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 4;
            this.editBtn.Text = "Editar";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Enabled = false;
            this.deleteBtn.Location = new System.Drawing.Point(506, 31);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Borrar";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // selectedCellLbl
            // 
            this.selectedCellLbl.AutoSize = true;
            this.selectedCellLbl.Location = new System.Drawing.Point(223, 39);
            this.selectedCellLbl.Name = "selectedCellLbl";
            this.selectedCellLbl.Size = new System.Drawing.Size(150, 16);
            this.selectedCellLbl.TabIndex = 6;
            this.selectedCellLbl.Text = "Ningun Id Seleccionado";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(425, 31);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 7;
            this.backBtn.Text = "Volver";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // event_id
            // 
            this.event_id.HeaderText = "Id";
            this.event_id.MinimumWidth = 6;
            this.event_id.Name = "event_id";
            this.event_id.ReadOnly = true;
            this.event_id.Width = 60;
            // 
            // event_name
            // 
            this.event_name.HeaderText = "Nombre";
            this.event_name.MinimumWidth = 6;
            this.event_name.Name = "event_name";
            this.event_name.ReadOnly = true;
            this.event_name.Width = 120;
            // 
            // started_time_column
            // 
            this.started_time_column.HeaderText = "Fecha de Inicio";
            this.started_time_column.MinimumWidth = 6;
            this.started_time_column.Name = "started_time_column";
            this.started_time_column.Width = 80;
            // 
            // ended_time_column
            // 
            this.ended_time_column.HeaderText = "Fecha de Fin";
            this.ended_time_column.MinimumWidth = 6;
            this.ended_time_column.Name = "ended_time_column";
            this.ended_time_column.Width = 80;
            // 
            // frecuency_column
            // 
            this.frecuency_column.HeaderText = "Frecuencia";
            this.frecuency_column.MinimumWidth = 6;
            this.frecuency_column.Name = "frecuency_column";
            this.frecuency_column.Width = 60;
            // 
            // part_day_column
            // 
            this.part_day_column.HeaderText = "Tiempo";
            this.part_day_column.MinimumWidth = 6;
            this.part_day_column.Name = "part_day_column";
            this.part_day_column.Width = 60;
            // 
            // budget_column
            // 
            this.budget_column.HeaderText = "Presupuesto";
            this.budget_column.MinimumWidth = 6;
            this.budget_column.Name = "budget_column";
            this.budget_column.Width = 90;
            // 
            // address_column
            // 
            this.address_column.HeaderText = "Dirección";
            this.address_column.MinimumWidth = 6;
            this.address_column.Name = "address_column";
            this.address_column.Width = 120;
            // 
            // postal_code_column
            // 
            this.postal_code_column.HeaderText = "Código Postal";
            this.postal_code_column.MinimumWidth = 6;
            this.postal_code_column.Name = "postal_code_column";
            this.postal_code_column.Width = 60;
            // 
            // capacity_column
            // 
            this.capacity_column.HeaderText = "Capacidad";
            this.capacity_column.MinimumWidth = 6;
            this.capacity_column.Name = "capacity_column";
            this.capacity_column.Width = 60;
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.selectedCellLbl);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.eventDtGrdView);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.searchTxt);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "EventForm";
            this.Text = "Eventos - Gestor";
            ((System.ComponentModel.ISupportInitialize)(this.eventDtGrdView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.DataGridView eventDtGrdView;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label selectedCellLbl;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn event_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn event_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn started_time_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn ended_time_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn frecuency_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn part_day_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn budget_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn address_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn postal_code_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacity_column;
    }
}