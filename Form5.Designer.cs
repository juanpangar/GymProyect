namespace GymProject
{
    partial class listasSociosMensual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listasSociosMensual));
            this.bDClientesDataSet = new GymProject.BDClientesDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nºSocioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new GymProject.BDClientesDataSetTableAdapters.TableTableAdapter();
            this.pdfGenerateB = new System.Windows.Forms.Button();
            this.monthSelP = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDClientesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bDClientesDataSet
            // 
            this.bDClientesDataSet.DataSetName = "BDClientesDataSet";
            this.bDClientesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nºSocioDataGridViewTextBoxColumn,
            this.dNIDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.cuotaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(44, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(545, 254);
            this.dataGridView1.TabIndex = 0;
            // 
            // nºSocioDataGridViewTextBoxColumn
            // 
            this.nºSocioDataGridViewTextBoxColumn.DataPropertyName = "Nº Socio";
            this.nºSocioDataGridViewTextBoxColumn.HeaderText = "Nº Socio";
            this.nºSocioDataGridViewTextBoxColumn.Name = "nºSocioDataGridViewTextBoxColumn";
            this.nºSocioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dNIDataGridViewTextBoxColumn
            // 
            this.dNIDataGridViewTextBoxColumn.DataPropertyName = "DNI";
            this.dNIDataGridViewTextBoxColumn.HeaderText = "DNI";
            this.dNIDataGridViewTextBoxColumn.Name = "dNIDataGridViewTextBoxColumn";
            this.dNIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            this.apellidosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cuotaDataGridViewTextBoxColumn
            // 
            this.cuotaDataGridViewTextBoxColumn.DataPropertyName = "Cuota";
            this.cuotaDataGridViewTextBoxColumn.HeaderText = "Cuota";
            this.cuotaDataGridViewTextBoxColumn.Name = "cuotaDataGridViewTextBoxColumn";
            this.cuotaDataGridViewTextBoxColumn.ReadOnly = true;
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
            // pdfGenerateB
            // 
            this.pdfGenerateB.Location = new System.Drawing.Point(458, 365);
            this.pdfGenerateB.Name = "pdfGenerateB";
            this.pdfGenerateB.Size = new System.Drawing.Size(131, 29);
            this.pdfGenerateB.TabIndex = 1;
            this.pdfGenerateB.Text = "Generar PDF";
            this.pdfGenerateB.UseVisualStyleBackColor = true;
            this.pdfGenerateB.Click += new System.EventHandler(this.pdfGenerateB_Click);
            // 
            // monthSelP
            // 
            this.monthSelP.CustomFormat = "MMMM  yyyy";
            this.monthSelP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.monthSelP.Location = new System.Drawing.Point(467, 42);
            this.monthSelP.MaxDate = new System.DateTime(9998, 12, 1, 0, 0, 0, 0);
            this.monthSelP.Name = "monthSelP";
            this.monthSelP.Size = new System.Drawing.Size(122, 20);
            this.monthSelP.TabIndex = 2;
            this.monthSelP.Value = new System.DateTime(2016, 5, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione mes: ";
            // 
            // listasSociosMensual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 414);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthSelP);
            this.Controls.Add(this.pdfGenerateB);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "listasSociosMensual";
            this.Text = "Lista de socios mensual";
            this.Load += new System.EventHandler(this.listasSociosMensual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDClientesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDClientesDataSet bDClientesDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private BDClientesDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nºSocioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button pdfGenerateB;
        private System.Windows.Forms.DateTimePicker monthSelP;
        private System.Windows.Forms.Label label1;
    }
}