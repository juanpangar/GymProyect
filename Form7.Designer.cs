namespace GymProject
{
    partial class Cliente
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nº_SocioLabel;
            System.Windows.Forms.Label dNILabel;
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label localidadLabel;
            System.Windows.Forms.Label provinciaLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label fecha_de_AltaLabel;
            System.Windows.Forms.Label fecha_de_BajaLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label cuotaLabel;
            System.Windows.Forms.Label deudaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.nº_SocioTextBox = new System.Windows.Forms.TextBox();
            this.dNITextBox = new System.Windows.Forms.TextBox();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.localidadTextBox = new System.Windows.Forms.TextBox();
            this.provinciaTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.fecha_de_AltaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fecha_de_BajaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.cuotaTextBox = new System.Windows.Forms.TextBox();
            this.bDClientesDataSet = new GymProject.BDClientesDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new GymProject.BDClientesDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new GymProject.BDClientesDataSetTableAdapters.TableAdapterManager();
            this.deudaTextBox = new System.Windows.Forms.TextBox();
            nº_SocioLabel = new System.Windows.Forms.Label();
            dNILabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            localidadLabel = new System.Windows.Forms.Label();
            provinciaLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            fecha_de_AltaLabel = new System.Windows.Forms.Label();
            fecha_de_BajaLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            cuotaLabel = new System.Windows.Forms.Label();
            deudaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDClientesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nº_SocioLabel
            // 
            nº_SocioLabel.AutoSize = true;
            nº_SocioLabel.Location = new System.Drawing.Point(186, 150);
            nº_SocioLabel.Name = "nº_SocioLabel";
            nº_SocioLabel.Size = new System.Drawing.Size(52, 13);
            nº_SocioLabel.TabIndex = 27;
            nº_SocioLabel.Text = "Nº Socio:";
            // 
            // nº_SocioTextBox
            // 
            this.nº_SocioTextBox.Location = new System.Drawing.Point(248, 147);
            this.nº_SocioTextBox.Name = "nº_SocioTextBox";
            this.nº_SocioTextBox.ReadOnly = true;
            this.nº_SocioTextBox.Size = new System.Drawing.Size(55, 20);
            this.nº_SocioTextBox.TabIndex = 28;
            // 
            // dNILabel
            // 
            dNILabel.AutoSize = true;
            dNILabel.Location = new System.Drawing.Point(30, 176);
            dNILabel.Name = "dNILabel";
            dNILabel.Size = new System.Drawing.Size(29, 13);
            dNILabel.TabIndex = 29;
            dNILabel.Text = "DNI:";
            // 
            // dNITextBox
            // 
            this.dNITextBox.Location = new System.Drawing.Point(92, 173);
            this.dNITextBox.Name = "dNITextBox";
            this.dNITextBox.ReadOnly = true;
            this.dNITextBox.Size = new System.Drawing.Size(211, 20);
            this.dNITextBox.TabIndex = 30;
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Location = new System.Drawing.Point(30, 202);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(52, 13);
            apellidosLabel.TabIndex = 31;
            apellidosLabel.Text = "Apellidos:";
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.Location = new System.Drawing.Point(92, 199);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.ReadOnly = true;
            this.apellidosTextBox.Size = new System.Drawing.Size(211, 20);
            this.apellidosTextBox.TabIndex = 32;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(30, 228);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 33;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(92, 225);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.ReadOnly = true;
            this.nombreTextBox.Size = new System.Drawing.Size(211, 20);
            this.nombreTextBox.TabIndex = 34;
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fotoPictureBox.Location = new System.Drawing.Point(331, 45);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(262, 197);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fotoPictureBox.TabIndex = 35;
            this.fotoPictureBox.TabStop = false;
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(32, 266);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 36;
            direccionLabel.Text = "Direccion:";
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.Location = new System.Drawing.Point(94, 263);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.ReadOnly = true;
            this.direccionTextBox.Size = new System.Drawing.Size(211, 20);
            this.direccionTextBox.TabIndex = 37;
            // 
            // localidadLabel
            // 
            localidadLabel.AutoSize = true;
            localidadLabel.Location = new System.Drawing.Point(32, 292);
            localidadLabel.Name = "localidadLabel";
            localidadLabel.Size = new System.Drawing.Size(56, 13);
            localidadLabel.TabIndex = 38;
            localidadLabel.Text = "Localidad:";
            // 
            // localidadTextBox
            // 
            this.localidadTextBox.Location = new System.Drawing.Point(94, 289);
            this.localidadTextBox.Name = "localidadTextBox";
            this.localidadTextBox.ReadOnly = true;
            this.localidadTextBox.Size = new System.Drawing.Size(211, 20);
            this.localidadTextBox.TabIndex = 39;
            // 
            // provinciaLabel
            // 
            provinciaLabel.AutoSize = true;
            provinciaLabel.Location = new System.Drawing.Point(32, 318);
            provinciaLabel.Name = "provinciaLabel";
            provinciaLabel.Size = new System.Drawing.Size(54, 13);
            provinciaLabel.TabIndex = 40;
            provinciaLabel.Text = "Provincia:";
            // 
            // provinciaTextBox
            // 
            this.provinciaTextBox.Location = new System.Drawing.Point(94, 315);
            this.provinciaTextBox.Name = "provinciaTextBox";
            this.provinciaTextBox.ReadOnly = true;
            this.provinciaTextBox.Size = new System.Drawing.Size(211, 20);
            this.provinciaTextBox.TabIndex = 41;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(320, 295);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 42;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(382, 292);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(211, 20);
            this.emailTextBox.TabIndex = 43;
            // 
            // fecha_de_AltaLabel
            // 
            fecha_de_AltaLabel.AutoSize = true;
            fecha_de_AltaLabel.Location = new System.Drawing.Point(32, 361);
            fecha_de_AltaLabel.Name = "fecha_de_AltaLabel";
            fecha_de_AltaLabel.Size = new System.Drawing.Size(76, 13);
            fecha_de_AltaLabel.TabIndex = 44;
            fecha_de_AltaLabel.Text = "Fecha de Alta:";
            // 
            // fecha_de_AltaDateTimePicker
            // 
            this.fecha_de_AltaDateTimePicker.Enabled = false;
            this.fecha_de_AltaDateTimePicker.Location = new System.Drawing.Point(117, 357);
            this.fecha_de_AltaDateTimePicker.Name = "fecha_de_AltaDateTimePicker";
            this.fecha_de_AltaDateTimePicker.Size = new System.Drawing.Size(211, 20);
            this.fecha_de_AltaDateTimePicker.TabIndex = 45;
            // 
            // fecha_de_BajaLabel
            // 
            fecha_de_BajaLabel.AutoSize = true;
            fecha_de_BajaLabel.Location = new System.Drawing.Point(32, 390);
            fecha_de_BajaLabel.Name = "fecha_de_BajaLabel";
            fecha_de_BajaLabel.Size = new System.Drawing.Size(79, 13);
            fecha_de_BajaLabel.TabIndex = 46;
            fecha_de_BajaLabel.Text = "Fecha de Baja:";
            // 
            // fecha_de_BajaDateTimePicker
            // 
            this.fecha_de_BajaDateTimePicker.Enabled = false;
            this.fecha_de_BajaDateTimePicker.Location = new System.Drawing.Point(117, 386);
            this.fecha_de_BajaDateTimePicker.Name = "fecha_de_BajaDateTimePicker";
            this.fecha_de_BajaDateTimePicker.Size = new System.Drawing.Size(211, 20);
            this.fecha_de_BajaDateTimePicker.TabIndex = 47;
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(320, 321);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 48;
            telefonoLabel.Text = "Telefono:";
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.Location = new System.Drawing.Point(382, 318);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.ReadOnly = true;
            this.telefonoTextBox.Size = new System.Drawing.Size(211, 20);
            this.telefonoTextBox.TabIndex = 49;
            // 
            // cuotaLabel
            // 
            cuotaLabel.AutoSize = true;
            cuotaLabel.Location = new System.Drawing.Point(465, 361);
            cuotaLabel.Name = "cuotaLabel";
            cuotaLabel.Size = new System.Drawing.Size(38, 13);
            cuotaLabel.TabIndex = 50;
            cuotaLabel.Text = "Cuota:";
            // 
            // cuotaTextBox
            // 
            this.cuotaTextBox.Location = new System.Drawing.Point(522, 357);
            this.cuotaTextBox.Name = "cuotaTextBox";
            this.cuotaTextBox.ReadOnly = true;
            this.cuotaTextBox.Size = new System.Drawing.Size(71, 20);
            this.cuotaTextBox.TabIndex = 51;
            // 
            // bDClientesDataSet
            // 
            this.bDClientesDataSet.DataSetName = "BDClientesDataSet";
            this.bDClientesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.bDClientesDataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = GymProject.BDClientesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // deudaLabel
            // 
            deudaLabel.AutoSize = true;
            deudaLabel.Location = new System.Drawing.Point(465, 393);
            deudaLabel.Name = "deudaLabel";
            deudaLabel.Size = new System.Drawing.Size(42, 13);
            deudaLabel.TabIndex = 52;
            deudaLabel.Text = "Deuda:";
            // 
            // deudaTextBox
            // 
            this.deudaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Deuda", true));
            this.deudaTextBox.Location = new System.Drawing.Point(522, 390);
            this.deudaTextBox.Name = "deudaTextBox";
            this.deudaTextBox.ReadOnly = true;
            this.deudaTextBox.Size = new System.Drawing.Size(71, 20);
            this.deudaTextBox.TabIndex = 53;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 450);
            this.Controls.Add(deudaLabel);
            this.Controls.Add(this.deudaTextBox);
            this.Controls.Add(nº_SocioLabel);
            this.Controls.Add(this.nº_SocioTextBox);
            this.Controls.Add(dNILabel);
            this.Controls.Add(this.dNITextBox);
            this.Controls.Add(apellidosLabel);
            this.Controls.Add(this.apellidosTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(localidadLabel);
            this.Controls.Add(this.localidadTextBox);
            this.Controls.Add(provinciaLabel);
            this.Controls.Add(this.provinciaTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(fecha_de_AltaLabel);
            this.Controls.Add(this.fecha_de_AltaDateTimePicker);
            this.Controls.Add(fecha_de_BajaLabel);
            this.Controls.Add(this.fecha_de_BajaDateTimePicker);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(cuotaLabel);
            this.Controls.Add(this.cuotaTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Cliente";
            this.Text = "Socio";
            this.Load += new System.EventHandler(this.Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDClientesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nº_SocioTextBox;
        private System.Windows.Forms.TextBox dNITextBox;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox localidadTextBox;
        private System.Windows.Forms.TextBox provinciaTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.DateTimePicker fecha_de_AltaDateTimePicker;
        private System.Windows.Forms.DateTimePicker fecha_de_BajaDateTimePicker;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox cuotaTextBox;
        private BDClientesDataSet bDClientesDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private BDClientesDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private BDClientesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox deudaTextBox;
    }
}