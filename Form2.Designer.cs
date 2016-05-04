namespace GymProject
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchClientL = new System.Windows.Forms.Label();
            this.searchTextB = new System.Windows.Forms.TextBox();
            this.searchB = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoSocioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeSociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosLosSociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeSociosMensualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeSociosConImpagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impagos = new System.Windows.Forms.GroupBox();
            this.numeroMorososL = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.morosoPB1 = new System.Windows.Forms.PictureBox();
            this.morosoPB3 = new System.Windows.Forms.PictureBox();
            this.morosoPB4 = new System.Windows.Forms.PictureBox();
            this.morosoPB2 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.impagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.morosoPB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.morosoPB3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.morosoPB4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.morosoPB2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(76, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // searchClientL
            // 
            this.searchClientL.AutoSize = true;
            this.searchClientL.Location = new System.Drawing.Point(53, 272);
            this.searchClientL.Name = "searchClientL";
            this.searchClientL.Size = new System.Drawing.Size(101, 13);
            this.searchClientL.TabIndex = 3;
            this.searchClientL.Text = "Busqueda de socio:";
            // 
            // searchTextB
            // 
            this.searchTextB.Location = new System.Drawing.Point(56, 288);
            this.searchTextB.Name = "searchTextB";
            this.searchTextB.Size = new System.Drawing.Size(189, 20);
            this.searchTextB.TabIndex = 4;
            // 
            // searchB
            // 
            this.searchB.Image = ((System.Drawing.Image)(resources.GetObject("searchB.Image")));
            this.searchB.Location = new System.Drawing.Point(257, 285);
            this.searchB.Name = "searchB";
            this.searchB.Size = new System.Drawing.Size(25, 25);
            this.searchB.TabIndex = 5;
            this.searchB.UseVisualStyleBackColor = true;
            this.searchB.Click += new System.EventHandler(this.searchB_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoSocioToolStripMenuItem,
            this.listaDeSociosToolStripMenuItem,
            this.impagosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(658, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoSocioToolStripMenuItem
            // 
            this.nuevoSocioToolStripMenuItem.Name = "nuevoSocioToolStripMenuItem";
            this.nuevoSocioToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.nuevoSocioToolStripMenuItem.Text = "Nuevo socio";
            this.nuevoSocioToolStripMenuItem.Click += new System.EventHandler(this.nuevoSocioToolStripMenuItem_Click);
            // 
            // listaDeSociosToolStripMenuItem
            // 
            this.listaDeSociosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todosLosSociosToolStripMenuItem,
            this.listaDeSociosMensualToolStripMenuItem});
            this.listaDeSociosToolStripMenuItem.Name = "listaDeSociosToolStripMenuItem";
            this.listaDeSociosToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.listaDeSociosToolStripMenuItem.Text = "Lista de socios";
            // 
            // todosLosSociosToolStripMenuItem
            // 
            this.todosLosSociosToolStripMenuItem.Name = "todosLosSociosToolStripMenuItem";
            this.todosLosSociosToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.todosLosSociosToolStripMenuItem.Text = "Todos los socios";
            this.todosLosSociosToolStripMenuItem.Click += new System.EventHandler(this.todosLosSociosToolStripMenuItem_Click);
            // 
            // listaDeSociosMensualToolStripMenuItem
            // 
            this.listaDeSociosMensualToolStripMenuItem.Name = "listaDeSociosMensualToolStripMenuItem";
            this.listaDeSociosMensualToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.listaDeSociosMensualToolStripMenuItem.Text = "Lista de socios mensual";
            this.listaDeSociosMensualToolStripMenuItem.Click += new System.EventHandler(this.listaDeSociosMensualToolStripMenuItem_Click);
            // 
            // impagosToolStripMenuItem
            // 
            this.impagosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeSociosConImpagosToolStripMenuItem});
            this.impagosToolStripMenuItem.Name = "impagosToolStripMenuItem";
            this.impagosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.impagosToolStripMenuItem.Text = "Impagos";
            // 
            // listaDeSociosConImpagosToolStripMenuItem
            // 
            this.listaDeSociosConImpagosToolStripMenuItem.Name = "listaDeSociosConImpagosToolStripMenuItem";
            this.listaDeSociosConImpagosToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.listaDeSociosConImpagosToolStripMenuItem.Text = "Lista de socios con impagos";
            this.listaDeSociosConImpagosToolStripMenuItem.Click += new System.EventHandler(this.listaDeSociosConImpagosToolStripMenuItem_Click);
            // 
            // impagos
            // 
            this.impagos.Controls.Add(this.textBox3);
            this.impagos.Controls.Add(this.textBox4);
            this.impagos.Controls.Add(this.textBox5);
            this.impagos.Controls.Add(this.morosoPB2);
            this.impagos.Controls.Add(this.textBox2);
            this.impagos.Controls.Add(this.morosoPB4);
            this.impagos.Controls.Add(this.morosoPB3);
            this.impagos.Controls.Add(this.morosoPB1);
            this.impagos.Location = new System.Drawing.Point(313, 41);
            this.impagos.Name = "impagos";
            this.impagos.Size = new System.Drawing.Size(317, 312);
            this.impagos.TabIndex = 18;
            this.impagos.TabStop = false;
            this.impagos.Text = "Impagos";
            // 
            // numeroMorososL
            // 
            this.numeroMorososL.AutoSize = true;
            this.numeroMorososL.Location = new System.Drawing.Point(414, 362);
            this.numeroMorososL.Name = "numeroMorososL";
            this.numeroMorososL.Size = new System.Drawing.Size(128, 13);
            this.numeroMorososL.TabIndex = 19;
            this.numeroMorososL.Text = "nº de socios con impagos";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(376, 359);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(32, 20);
            this.textBox1.TabIndex = 21;
            this.textBox1.Text = "0";
            // 
            // morosoPB1
            // 
            this.morosoPB1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.morosoPB1.Image = ((System.Drawing.Image)(resources.GetObject("morosoPB1.Image")));
            this.morosoPB1.Location = new System.Drawing.Point(20, 28);
            this.morosoPB1.Name = "morosoPB1";
            this.morosoPB1.Size = new System.Drawing.Size(130, 98);
            this.morosoPB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.morosoPB1.TabIndex = 8;
            this.morosoPB1.TabStop = false;
            // 
            // morosoPB3
            // 
            this.morosoPB3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.morosoPB3.Image = ((System.Drawing.Image)(resources.GetObject("morosoPB3.Image")));
            this.morosoPB3.Location = new System.Drawing.Point(20, 169);
            this.morosoPB3.Name = "morosoPB3";
            this.morosoPB3.Size = new System.Drawing.Size(130, 98);
            this.morosoPB3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.morosoPB3.TabIndex = 10;
            this.morosoPB3.TabStop = false;
            // 
            // morosoPB4
            // 
            this.morosoPB4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.morosoPB4.Image = ((System.Drawing.Image)(resources.GetObject("morosoPB4.Image")));
            this.morosoPB4.Location = new System.Drawing.Point(166, 169);
            this.morosoPB4.Name = "morosoPB4";
            this.morosoPB4.Size = new System.Drawing.Size(130, 98);
            this.morosoPB4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.morosoPB4.TabIndex = 12;
            this.morosoPB4.TabStop = false;
            // 
            // morosoPB2
            // 
            this.morosoPB2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.morosoPB2.Image = ((System.Drawing.Image)(resources.GetObject("morosoPB2.Image")));
            this.morosoPB2.Location = new System.Drawing.Point(166, 28);
            this.morosoPB2.Name = "morosoPB2";
            this.morosoPB2.Size = new System.Drawing.Size(130, 98);
            this.morosoPB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.morosoPB2.TabIndex = 13;
            this.morosoPB2.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(20, 132);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(130, 20);
            this.textBox2.TabIndex = 22;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(166, 132);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(130, 20);
            this.textBox3.TabIndex = 23;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(20, 273);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(128, 20);
            this.textBox4.TabIndex = 24;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(166, 273);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(130, 20);
            this.textBox5.TabIndex = 25;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 394);
            this.Controls.Add(this.impagos);
            this.Controls.Add(this.searchB);
            this.Controls.Add(this.searchTextB);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.searchClientL);
            this.Controls.Add(this.numeroMorososL);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inicio";
            this.Text = "Gym SEUL";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.impagos.ResumeLayout(false);
            this.impagos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.morosoPB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.morosoPB3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.morosoPB4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.morosoPB2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label searchClientL;
        private System.Windows.Forms.TextBox searchTextB;
        private System.Windows.Forms.Button searchB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoSocioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeSociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosLosSociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeSociosMensualToolStripMenuItem;
        private System.Windows.Forms.GroupBox impagos;
        private System.Windows.Forms.Label numeroMorososL;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem impagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeSociosConImpagosToolStripMenuItem;
        private System.Windows.Forms.PictureBox morosoPB2;
        private System.Windows.Forms.PictureBox morosoPB4;
        private System.Windows.Forms.PictureBox morosoPB3;
        private System.Windows.Forms.PictureBox morosoPB1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox2;
    }
}