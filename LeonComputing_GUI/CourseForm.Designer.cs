namespace LeonComputing_GUI
{
    partial class CourseForm
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
            this.courseDtGrdView = new System.Windows.Forms.DataGridView();
            this.course_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course_hours_practice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course_hours_theory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course_level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.selectedCellLbl = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.courseDtGrdView)).BeginInit();
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
            // courseDtGrdView
            // 
            this.courseDtGrdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseDtGrdView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.course_id,
            this.course_name,
            this.course_hours_practice,
            this.course_hours_theory,
            this.course_level,
            this.course_description});
            this.courseDtGrdView.Location = new System.Drawing.Point(12, 65);
            this.courseDtGrdView.Name = "courseDtGrdView";
            this.courseDtGrdView.RowHeadersWidth = 51;
            this.courseDtGrdView.RowTemplate.Height = 24;
            this.courseDtGrdView.Size = new System.Drawing.Size(758, 476);
            this.courseDtGrdView.TabIndex = 2;
            this.courseDtGrdView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.courseDtGrdView_CellClick);
            // 
            // course_id
            // 
            this.course_id.HeaderText = "Id";
            this.course_id.MinimumWidth = 6;
            this.course_id.Name = "course_id";
            this.course_id.ReadOnly = true;
            this.course_id.Width = 125;
            // 
            // course_name
            // 
            this.course_name.HeaderText = "Nombre";
            this.course_name.MinimumWidth = 6;
            this.course_name.Name = "course_name";
            this.course_name.ReadOnly = true;
            this.course_name.Width = 125;
            // 
            // course_hours_practice
            // 
            this.course_hours_practice.HeaderText = "Horas de Práctica";
            this.course_hours_practice.MinimumWidth = 6;
            this.course_hours_practice.Name = "course_hours_practice";
            this.course_hours_practice.ReadOnly = true;
            this.course_hours_practice.Width = 125;
            // 
            // course_hours_theory
            // 
            this.course_hours_theory.HeaderText = "Horas teoría";
            this.course_hours_theory.MinimumWidth = 6;
            this.course_hours_theory.Name = "course_hours_theory";
            this.course_hours_theory.ReadOnly = true;
            this.course_hours_theory.Width = 125;
            // 
            // course_level
            // 
            this.course_level.HeaderText = "Nivel";
            this.course_level.MinimumWidth = 6;
            this.course_level.Name = "course_level";
            this.course_level.ReadOnly = true;
            this.course_level.Width = 125;
            // 
            // course_description
            // 
            this.course_description.HeaderText = "Descripción";
            this.course_description.MinimumWidth = 6;
            this.course_description.Name = "course_description";
            this.course_description.ReadOnly = true;
            this.course_description.Width = 125;
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
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.selectedCellLbl);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.courseDtGrdView);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.searchTxt);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "CourseForm";
            this.Text = "Cursos - Gestor";
            ((System.ComponentModel.ISupportInitialize)(this.courseDtGrdView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.DataGridView courseDtGrdView;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label selectedCellLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn course_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn course_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn course_hours_practice;
        private System.Windows.Forms.DataGridViewTextBoxColumn course_hours_theory;
        private System.Windows.Forms.DataGridViewTextBoxColumn course_level;
        private System.Windows.Forms.DataGridViewTextBoxColumn course_description;
        private System.Windows.Forms.Button backBtn;
    }
}