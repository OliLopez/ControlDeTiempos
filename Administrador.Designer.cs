namespace ControlDeTiempos
{
    partial class Administrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrador));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblempleado = new System.Windows.Forms.Label();
            this.lblaño = new System.Windows.Forms.Label();
            this.cmbAño = new System.Windows.Forms.ComboBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.btnReporte = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProviderAdmin = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cmbArea);
            this.panel1.Controls.Add(this.lblArea);
            this.panel1.Controls.Add(this.lblempleado);
            this.panel1.Controls.Add(this.lblaño);
            this.panel1.Controls.Add(this.cmbAño);
            this.panel1.Controls.Add(this.lblEmpresa);
            this.panel1.Controls.Add(this.cmbEmpleado);
            this.panel1.Controls.Add(this.cmbEmpresa);
            this.panel1.Location = new System.Drawing.Point(9, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 150);
            this.panel1.TabIndex = 1;
            // 
            // cmbArea
            // 
            this.cmbArea.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Items.AddRange(new object[] {
            "Todos",
            "Auditoria",
            "Contabilidad",
            "Administracion",
            "Trabajo especial",
            "Otros"});
            this.cmbArea.Location = new System.Drawing.Point(264, 12);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(121, 26);
            this.cmbArea.TabIndex = 9;
            this.cmbArea.MouseLeave += new System.EventHandler(this.cmbArea_MouseLeave);
            this.cmbArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cmbArea_MouseMove);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(7, 18);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(38, 17);
            this.lblArea.TabIndex = 8;
            this.lblArea.Text = "Area";
            // 
            // lblempleado
            // 
            this.lblempleado.AutoSize = true;
            this.lblempleado.BackColor = System.Drawing.Color.Transparent;
            this.lblempleado.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempleado.Location = new System.Drawing.Point(4, 111);
            this.lblempleado.Name = "lblempleado";
            this.lblempleado.Size = new System.Drawing.Size(74, 17);
            this.lblempleado.TabIndex = 7;
            this.lblempleado.Text = "Empleado";
            // 
            // lblaño
            // 
            this.lblaño.AutoSize = true;
            this.lblaño.BackColor = System.Drawing.Color.Transparent;
            this.lblaño.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaño.Location = new System.Drawing.Point(5, 79);
            this.lblaño.Name = "lblaño";
            this.lblaño.Size = new System.Drawing.Size(64, 17);
            this.lblaño.TabIndex = 6;
            this.lblaño.Text = "Ejercicio";
            // 
            // cmbAño
            // 
            this.cmbAño.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbAño.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAño.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAño.FormattingEnabled = true;
            this.cmbAño.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cmbAño.Location = new System.Drawing.Point(319, 74);
            this.cmbAño.Name = "cmbAño";
            this.cmbAño.Size = new System.Drawing.Size(66, 26);
            this.cmbAño.TabIndex = 1;
            this.cmbAño.MouseLeave += new System.EventHandler(this.comboAdminAño_MouseLeave);
            this.cmbAño.MouseMove += new System.Windows.Forms.MouseEventHandler(this.comboAdminAño_MouseMove);
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpresa.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.Location = new System.Drawing.Point(5, 48);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(68, 17);
            this.lblEmpresa.TabIndex = 5;
            this.lblEmpresa.Text = "Empresa";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEmpleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEmpleado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Items.AddRange(new object[] {
            "Todos",
            "Contador Julio",
            "Contadora Socorro"});
            this.cmbEmpleado.Location = new System.Drawing.Point(180, 108);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(205, 26);
            this.cmbEmpleado.TabIndex = 2;
            this.cmbEmpleado.MouseLeave += new System.EventHandler(this.comboEmpleado_MouseLeave);
            this.cmbEmpleado.MouseMove += new System.Windows.Forms.MouseEventHandler(this.comboEmpleado_MouseMove);
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEmpresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbEmpresa.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Items.AddRange(new object[] {
            "Todos",
            "ALIANZAS AFECTUOSAS, S.A de C.V",
            "ADMINISTRADORA DE OBRAS Y CONCESIONES, S.A de C.V",
            "ASCENCIO SOULES Y CIA, S.C",
            "CONSTRUCTORA MAKRO, S.A de C.V",
            "CORPORATIVO INTEGRAL DE VIVIENDA, S.A. de C.V.",
            "DISTRIBUIDORA PIPILA, S. de R.L. de C.V.",
            "HOGAR PARA NINIOS NECESITADOS CRISTO POR SU MUNDO, A.C.",
            "MADERAS Y MATERIALES, JR, S.A. de C.V.",
            "MAGNAMAQ, S.A. de C.V.",
            "OPERADORA FARMACEUTICA DE BAJA CALIFORNIA, S. de R.L. de C.V.",
            "PIEDRAS HEADWATERS, S. de R.L",
            "TRITUASFALTOS, S.A. de C.V.",
            "Otros- no auditoria"});
            this.cmbEmpresa.Location = new System.Drawing.Point(79, 45);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(306, 22);
            this.cmbEmpresa.TabIndex = 0;
            this.cmbEmpresa.MouseLeave += new System.EventHandler(this.comboAdminEmpresa_MouseLeave);
            this.cmbEmpresa.MouseMove += new System.Windows.Forms.MouseEventHandler(this.comboAdminEmpresa_MouseMove);
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporte.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReporte.Location = new System.Drawing.Point(191, 168);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(84, 62);
            this.btnReporte.TabIndex = 4;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            this.btnReporte.MouseLeave += new System.EventHandler(this.btnReporte_MouseLeave);
            this.btnReporte.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnReporte_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.pictureBox1.Image = global::ControlDeTiempos.Properties.Resources.buscar;
            this.pictureBox1.Location = new System.Drawing.Point(1, 172);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // errorProviderAdmin
            // 
            this.errorProviderAdmin.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(428, 242);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(448, 285);
            this.MinimumSize = new System.Drawing.Size(448, 285);
            this.Name = "Administrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Administrador_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblempleado;
        private System.Windows.Forms.Label lblaño;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.ComboBox cmbAño;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProviderAdmin;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.Label label1;
    }
}