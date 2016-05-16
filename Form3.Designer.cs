namespace GymProject
{
    partial class nuevoSocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nuevoSocio));
            this.bDClientesDataSet = new GymProject.BDClientesDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new GymProject.BDClientesDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new GymProject.BDClientesDataSetTableAdapters.TableAdapterManager();
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
            this.saveClientB = new System.Windows.Forms.Button();
            this.addPictureB = new System.Windows.Forms.Button();
            this.openDialogImagen = new System.Windows.Forms.OpenFileDialog();
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
            ((System.ComponentModel.ISupportInitialize)(this.bDClientesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nº_SocioLabel
            // 
            nº_SocioLabel.AutoSize = true;
            nº_SocioLabel.Location = new System.Drawing.Point(185, 138);
            nº_SocioLabel.Name = "nº_SocioLabel";
            nº_SocioLabel.Size = new System.Drawing.Size(52, 13);
            nº_SocioLabel.TabIndex = 1;
            nº_SocioLabel.Text = "Nº Socio:";
            // 
            // dNILabel
            // 
            dNILabel.AutoSize = true;
            dNILabel.Location = new System.Drawing.Point(29, 164);
            dNILabel.Name = "dNILabel";
            dNILabel.Size = new System.Drawing.Size(29, 13);
            dNILabel.TabIndex = 3;
            dNILabel.Text = "DNI:";
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Location = new System.Drawing.Point(29, 190);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(52, 13);
            apellidosLabel.TabIndex = 5;
            apellidosLabel.Text = "Apellidos:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(29, 216);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 7;
            nombreLabel.Text = "Nombre:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(31, 254);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 11;
            direccionLabel.Text = "Direccion:";
            // 
            // localidadLabel
            // 
            localidadLabel.AutoSize = true;
            localidadLabel.Location = new System.Drawing.Point(31, 280);
            localidadLabel.Name = "localidadLabel";
            localidadLabel.Size = new System.Drawing.Size(56, 13);
            localidadLabel.TabIndex = 13;
            localidadLabel.Text = "Localidad:";
            // 
            // provinciaLabel
            // 
            provinciaLabel.AutoSize = true;
            provinciaLabel.Location = new System.Drawing.Point(31, 306);
            provinciaLabel.Name = "provinciaLabel";
            provinciaLabel.Size = new System.Drawing.Size(54, 13);
            provinciaLabel.TabIndex = 15;
            provinciaLabel.Text = "Provincia:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(319, 283);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 17;
            emailLabel.Text = "Email:";
            // 
            // fecha_de_AltaLabel
            // 
            fecha_de_AltaLabel.AutoSize = true;
            fecha_de_AltaLabel.Location = new System.Drawing.Point(31, 349);
            fecha_de_AltaLabel.Name = "fecha_de_AltaLabel";
            fecha_de_AltaLabel.Size = new System.Drawing.Size(76, 13);
            fecha_de_AltaLabel.TabIndex = 19;
            fecha_de_AltaLabel.Text = "Fecha de Alta:";
            // 
            // fecha_de_BajaLabel
            // 
            fecha_de_BajaLabel.AutoSize = true;
            fecha_de_BajaLabel.Location = new System.Drawing.Point(31, 378);
            fecha_de_BajaLabel.Name = "fecha_de_BajaLabel";
            fecha_de_BajaLabel.Size = new System.Drawing.Size(79, 13);
            fecha_de_BajaLabel.TabIndex = 21;
            fecha_de_BajaLabel.Text = "Fecha de Baja:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(319, 309);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 23;
            telefonoLabel.Text = "Telefono:";
            // 
            // cuotaLabel
            // 
            cuotaLabel.AutoSize = true;
            cuotaLabel.Location = new System.Drawing.Point(468, 348);
            cuotaLabel.Name = "cuotaLabel";
            cuotaLabel.Size = new System.Drawing.Size(38, 13);
            cuotaLabel.TabIndex = 25;
            cuotaLabel.Text = "Cuota:";
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
            // nº_SocioTextBox
            // 
            this.nº_SocioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Nº Socio", true));
            this.nº_SocioTextBox.Location = new System.Drawing.Point(247, 135);
            this.nº_SocioTextBox.Name = "nº_SocioTextBox";
            this.nº_SocioTextBox.Size = new System.Drawing.Size(55, 20);
            this.nº_SocioTextBox.TabIndex = 2;
            // 
            // dNITextBox
            // 
            this.dNITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "DNI", true));
            this.dNITextBox.Location = new System.Drawing.Point(91, 161);
            this.dNITextBox.Name = "dNITextBox";
            this.dNITextBox.Size = new System.Drawing.Size(211, 20);
            this.dNITextBox.TabIndex = 4;
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Apellidos", true));
            this.apellidosTextBox.Location = new System.Drawing.Point(91, 187);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(211, 20);
            this.apellidosTextBox.TabIndex = 6;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(91, 213);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(211, 20);
            this.nombreTextBox.TabIndex = 8;
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.tableBindingSource, "Foto", true));
            this.fotoPictureBox.Location = new System.Drawing.Point(330, 33);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(262, 197);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fotoPictureBox.TabIndex = 10;
            this.fotoPictureBox.TabStop = false;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(93, 251);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(211, 20);
            this.direccionTextBox.TabIndex = 12;
            // 
            // localidadTextBox
            // 
            this.localidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Localidad", true));
            this.localidadTextBox.Location = new System.Drawing.Point(93, 277);
            this.localidadTextBox.Name = "localidadTextBox";
            this.localidadTextBox.Size = new System.Drawing.Size(211, 20);
            this.localidadTextBox.TabIndex = 14;
            // 
            // provinciaTextBox
            // 
            this.provinciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Provincia", true));
            this.provinciaTextBox.Location = new System.Drawing.Point(93, 303);
            this.provinciaTextBox.Name = "provinciaTextBox";
            this.provinciaTextBox.Size = new System.Drawing.Size(211, 20);
            this.provinciaTextBox.TabIndex = 16;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(381, 280);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(211, 20);
            this.emailTextBox.TabIndex = 18;
            // 
            // fecha_de_AltaDateTimePicker
            // 
            this.fecha_de_AltaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tableBindingSource, "Fecha de Alta", true));
            this.fecha_de_AltaDateTimePicker.Location = new System.Drawing.Point(116, 345);
            this.fecha_de_AltaDateTimePicker.Name = "fecha_de_AltaDateTimePicker";
            this.fecha_de_AltaDateTimePicker.Size = new System.Drawing.Size(211, 20);
            this.fecha_de_AltaDateTimePicker.TabIndex = 20;
            // 
            // fecha_de_BajaDateTimePicker
            // 
            this.fecha_de_BajaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tableBindingSource, "Fecha de Baja", true));
            this.fecha_de_BajaDateTimePicker.Location = new System.Drawing.Point(116, 374);
            this.fecha_de_BajaDateTimePicker.Name = "fecha_de_BajaDateTimePicker";
            this.fecha_de_BajaDateTimePicker.Size = new System.Drawing.Size(211, 20);
            this.fecha_de_BajaDateTimePicker.TabIndex = 22;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(381, 306);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(211, 20);
            this.telefonoTextBox.TabIndex = 24;
            // 
            // cuotaTextBox
            // 
            this.cuotaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Cuota", true));
            this.cuotaTextBox.Location = new System.Drawing.Point(521, 345);
            this.cuotaTextBox.Name = "cuotaTextBox";
            this.cuotaTextBox.Size = new System.Drawing.Size(71, 20);
            this.cuotaTextBox.TabIndex = 26;
            // 
            // saveClientB
            // 
            this.saveClientB.Location = new System.Drawing.Point(482, 389);
            this.saveClientB.Name = "saveClientB";
            this.saveClientB.Size = new System.Drawing.Size(110, 36);
            this.saveClientB.TabIndex = 27;
            this.saveClientB.Text = "Guardar";
            this.saveClientB.UseVisualStyleBackColor = true;
            // 
            // addPictureB
            // 
            this.addPictureB.Location = new System.Drawing.Point(457, 236);
            this.addPictureB.Name = "addPictureB";
            this.addPictureB.Size = new System.Drawing.Size(135, 31);
            this.addPictureB.TabIndex = 28;
            this.addPictureB.Text = "Añadir Imagen";
            this.addPictureB.UseVisualStyleBackColor = true;
            this.addPictureB.Click += new System.EventHandler(this.addPictureB_Click);
            // 
            // openDialogImagen
            // 
            this.openDialogImagen.FileName = "Añadir Imagen";
            // 
            // nuevoSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 450);
            this.Controls.Add(this.addPictureB);
            this.Controls.Add(this.saveClientB);
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
            this.Name = "nuevoSocio";
            this.Text = "Nuevo socio";
            this.Load += new System.EventHandler(this.nuevoSocio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDClientesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDClientesDataSet bDClientesDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private BDClientesDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private BDClientesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.Button saveClientB;
        private System.Windows.Forms.Button addPictureB;
        private System.Windows.Forms.OpenFileDialog openDialogImagen;
    }
}