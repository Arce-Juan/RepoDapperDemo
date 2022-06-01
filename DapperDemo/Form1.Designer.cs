namespace DapperDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridCustomer = new System.Windows.Forms.DataGridView();
            this.BtnGetAllCustomers = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.BtnGetCustomer = new System.Windows.Forms.Button();
            this.BtnGetById = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.txtIdCustomer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimeDateBirth = new System.Windows.Forms.DateTimePicker();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomer)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridCustomer
            // 
            this.dataGridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomer.Location = new System.Drawing.Point(12, 96);
            this.dataGridCustomer.Name = "dataGridCustomer";
            this.dataGridCustomer.RowTemplate.Height = 25;
            this.dataGridCustomer.Size = new System.Drawing.Size(776, 254);
            this.dataGridCustomer.TabIndex = 0;
            this.dataGridCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCustomer_CellContentClick);
            // 
            // BtnGetAllCustomers
            // 
            this.BtnGetAllCustomers.Location = new System.Drawing.Point(596, 56);
            this.BtnGetAllCustomers.Name = "BtnGetAllCustomers";
            this.BtnGetAllCustomers.Size = new System.Drawing.Size(100, 23);
            this.BtnGetAllCustomers.TabIndex = 1;
            this.BtnGetAllCustomers.Text = "Otener Todos";
            this.BtnGetAllCustomers.UseVisualStyleBackColor = true;
            this.BtnGetAllCustomers.Click += new System.EventHandler(this.BtnGetAllCustomers_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(12, 57);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(442, 23);
            this.txtFilter.TabIndex = 3;
            // 
            // BtnGetCustomer
            // 
            this.BtnGetCustomer.Location = new System.Drawing.Point(453, 56);
            this.BtnGetCustomer.Name = "BtnGetCustomer";
            this.BtnGetCustomer.Size = new System.Drawing.Size(137, 24);
            this.BtnGetCustomer.TabIndex = 4;
            this.BtnGetCustomer.Text = "Buscar Por Apellido";
            this.BtnGetCustomer.UseVisualStyleBackColor = true;
            this.BtnGetCustomer.Click += new System.EventHandler(this.BtnGetCustomer_Click);
            // 
            // BtnGetById
            // 
            this.BtnGetById.Location = new System.Drawing.Point(453, 27);
            this.BtnGetById.Name = "BtnGetById";
            this.BtnGetById.Size = new System.Drawing.Size(137, 24);
            this.BtnGetById.TabIndex = 6;
            this.BtnGetById.Text = "Buscar Por Id";
            this.BtnGetById.UseVisualStyleBackColor = true;
            this.BtnGetById.Click += new System.EventHandler(this.BtnGetById_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 28);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(442, 23);
            this.txtId.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Apellido";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(138, 68);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(150, 23);
            this.txtLastname.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(138, 97);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 23);
            this.txtName.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(138, 126);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(150, 23);
            this.txtAddress.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fecha Nacimiento";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(138, 184);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(150, 23);
            this.txtCountry.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ciudad";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnDelete);
            this.panel1.Controls.Add(this.BtnUpdate);
            this.panel1.Controls.Add(this.txtIdCustomer);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dateTimeDateBirth);
            this.panel1.Controls.Add(this.BtnAdd);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtLastname);
            this.panel1.Controls.Add(this.txtCountry);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Location = new System.Drawing.Point(12, 369);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 273);
            this.panel1.TabIndex = 17;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(127, 223);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(87, 30);
            this.BtnUpdate.TabIndex = 21;
            this.BtnUpdate.Text = "Actualizar";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // txtIdCustomer
            // 
            this.txtIdCustomer.Location = new System.Drawing.Point(138, 39);
            this.txtIdCustomer.Name = "txtIdCustomer";
            this.txtIdCustomer.ReadOnly = true;
            this.txtIdCustomer.Size = new System.Drawing.Size(150, 23);
            this.txtIdCustomer.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "ID";
            // 
            // dateTimeDateBirth
            // 
            this.dateTimeDateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDateBirth.Location = new System.Drawing.Point(138, 155);
            this.dateTimeDateBirth.Name = "dateTimeDateBirth";
            this.dateTimeDateBirth.Size = new System.Drawing.Size(150, 23);
            this.dateTimeDateBirth.TabIndex = 18;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(14, 223);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(87, 30);
            this.BtnAdd.TabIndex = 18;
            this.BtnAdd.Text = "Agregar";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "AGREGAR CLIENTE";
            // 
            // BtnSelect
            // 
            this.BtnSelect.Location = new System.Drawing.Point(702, 56);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(86, 23);
            this.BtnSelect.TabIndex = 18;
            this.BtnSelect.Text = "Seleccionar";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(237, 223);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(87, 30);
            this.BtnDelete.TabIndex = 22;
            this.BtnDelete.Text = "Eliminar";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 739);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnGetById);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.BtnGetCustomer);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.BtnGetAllCustomers);
            this.Controls.Add(this.dataGridCustomer);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCustomer;
        private System.Windows.Forms.Button BtnGetAllCustomers;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button BtnGetCustomer;
        private System.Windows.Forms.Button BtnGetById;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimeDateBirth;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.TextBox txtIdCustomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
    }
}
