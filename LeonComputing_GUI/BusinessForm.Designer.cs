namespace LeonComputing_GUI
{
    partial class BusinessForm
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
            this.businessDtGrdView = new System.Windows.Forms.DataGridView();
            this.business_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.business_url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.business_type_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.business_code_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.business_ubigeo_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.business_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.business_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.business_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.selectedCellLbl = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.businessDtGrdView)).BeginInit();
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
            // businessDtGrdView
            // 
            this.businessDtGrdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.businessDtGrdView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.business_id,
            this.columnName,
            this.business_url,
            this.business_type_id,
            this.business_code_id,
            this.business_ubigeo_code,
            this.business_address,
            this.business_phone,
            this.business_email});
            this.businessDtGrdView.Location = new System.Drawing.Point(12, 65);
            this.businessDtGrdView.Name = "businessDtGrdView";
            this.businessDtGrdView.RowHeadersWidth = 51;
            this.businessDtGrdView.RowTemplate.Height = 24;
            this.businessDtGrdView.Size = new System.Drawing.Size(758, 476);
            this.businessDtGrdView.TabIndex = 2;
            this.businessDtGrdView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.businessDtGrdView_CellClick);
            // 
            // business_id
            // 
            this.business_id.HeaderText = "Id";
            this.business_id.MinimumWidth = 6;
            this.business_id.Name = "business_id";
            this.business_id.ReadOnly = true;
            this.business_id.Width = 125;
            // 
            // columnName
            // 
            this.columnName.HeaderText = "Nombre";
            this.columnName.MinimumWidth = 6;
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            this.columnName.Width = 125;
            // 
            // business_url
            // 
            this.business_url.HeaderText = "URL";
            this.business_url.MinimumWidth = 6;
            this.business_url.Name = "business_url";
            this.business_url.ReadOnly = true;
            this.business_url.Width = 125;
            // 
            // business_type_id
            // 
            this.business_type_id.HeaderText = "Tipo Documento";
            this.business_type_id.MinimumWidth = 6;
            this.business_type_id.Name = "business_type_id";
            this.business_type_id.ReadOnly = true;
            this.business_type_id.Width = 125;
            // 
            // business_code_id
            // 
            this.business_code_id.HeaderText = "Numero Documento";
            this.business_code_id.MinimumWidth = 6;
            this.business_code_id.Name = "business_code_id";
            this.business_code_id.ReadOnly = true;
            this.business_code_id.Width = 125;
            // 
            // business_ubigeo_code
            // 
            this.business_ubigeo_code.HeaderText = "Codigo Ubigeo";
            this.business_ubigeo_code.MinimumWidth = 6;
            this.business_ubigeo_code.Name = "business_ubigeo_code";
            this.business_ubigeo_code.ReadOnly = true;
            this.business_ubigeo_code.Width = 125;
            // 
            // business_address
            // 
            this.business_address.HeaderText = "Dirección";
            this.business_address.MinimumWidth = 6;
            this.business_address.Name = "business_address";
            this.business_address.ReadOnly = true;
            this.business_address.Width = 125;
            // 
            // business_phone
            // 
            this.business_phone.HeaderText = "Telefono";
            this.business_phone.MinimumWidth = 6;
            this.business_phone.Name = "business_phone";
            this.business_phone.ReadOnly = true;
            this.business_phone.Width = 125;
            // 
            // business_email
            // 
            this.business_email.HeaderText = "Correo";
            this.business_email.MinimumWidth = 6;
            this.business_email.Name = "business_email";
            this.business_email.ReadOnly = true;
            this.business_email.Width = 125;
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
            // BusinessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.selectedCellLbl);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.businessDtGrdView);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.searchTxt);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "BusinessForm";
            this.Text = "Empresas - Gestor";
            ((System.ComponentModel.ISupportInitialize)(this.businessDtGrdView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.DataGridView businessDtGrdView;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label selectedCellLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn business_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn business_url;
        private System.Windows.Forms.DataGridViewTextBoxColumn business_type_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn business_code_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn business_ubigeo_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn business_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn business_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn business_email;
        private System.Windows.Forms.Button backBtn;
    }
}