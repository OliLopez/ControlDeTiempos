﻿namespace ControlDeTiempos
{
    partial class CalculadorHrs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculadorHrs));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblempleado = new System.Windows.Forms.Label();
            this.lblaño = new System.Windows.Forms.Label();
            this.cmbAño = new System.Windows.Forms.ComboBox();
            this.ejercicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlTiemposDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlTiemposDataSet = new ControlDeTiempos.ControlTiemposDataSet();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlTiemposDataSetempleado = new ControlDeTiempos.ControlTiemposDataSetempleado();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.cmbEmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ctDataSetcmEmpre = new ControlDeTiempos.ControlTiemposDataSet1();
            this.picBuscar = new System.Windows.Forms.PictureBox();
            this.errorProviderAdmin = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.ejercicioTableAdapter = new ControlDeTiempos.ControlTiemposDataSetTableAdapters.EjercicioTableAdapter();
            this.empleadoTableAdapter = new ControlDeTiempos.ControlTiemposDataSetempleadoTableAdapters.empleadoTableAdapter();
            this.cmbEmpresaTableAdapter = new ControlDeTiempos.ControlTiemposDataSet1TableAdapters.cmbEmpresaTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ejercicioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlTiemposDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlTiemposDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlTiemposDataSetempleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEmpresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctDataSetcmEmpre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAdmin)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cmbArea);
            this.panel1.Controls.Add(this.lblArea);
            this.panel1.Controls.Add(this.lblempleado);
            this.panel1.Controls.Add(this.lblaño);
            this.panel1.Controls.Add(this.cmbAño);
            this.panel1.Controls.Add(this.lblEmpresa);
            this.panel1.Controls.Add(this.cmbEmpleado);
            this.panel1.Controls.Add(this.cmbEmpresa);
            this.panel1.Location = new System.Drawing.Point(6, 6);
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
            this.cmbAño.DataSource = this.ejercicioBindingSource;
            this.cmbAño.DisplayMember = "Nombre_Ejercicio";
            this.cmbAño.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAño.FormattingEnabled = true;
            this.cmbAño.Location = new System.Drawing.Point(319, 74);
            this.cmbAño.Name = "cmbAño";
            this.cmbAño.Size = new System.Drawing.Size(66, 26);
            this.cmbAño.TabIndex = 1;
            this.cmbAño.MouseLeave += new System.EventHandler(this.comboAdminAño_MouseLeave);
            this.cmbAño.MouseMove += new System.Windows.Forms.MouseEventHandler(this.comboAdminAño_MouseMove);
            // 
            // ejercicioBindingSource
            // 
            this.ejercicioBindingSource.DataMember = "Ejercicio";
            this.ejercicioBindingSource.DataSource = this.controlTiemposDataSetBindingSource;
            // 
            // controlTiemposDataSetBindingSource
            // 
            this.controlTiemposDataSetBindingSource.DataSource = this.controlTiemposDataSet;
            this.controlTiemposDataSetBindingSource.Position = 0;
            // 
            // controlTiemposDataSet
            // 
            this.controlTiemposDataSet.DataSetName = "ControlTiemposDataSet";
            this.controlTiemposDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.cmbEmpleado.DataSource = this.empleadoBindingSource;
            this.cmbEmpleado.DisplayMember = "Nombre";
            this.cmbEmpleado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(180, 108);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(205, 26);
            this.cmbEmpleado.TabIndex = 2;
            this.cmbEmpleado.MouseLeave += new System.EventHandler(this.comboEmpleado_MouseLeave);
            this.cmbEmpleado.MouseMove += new System.Windows.Forms.MouseEventHandler(this.comboEmpleado_MouseMove);
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "empleado";
            this.empleadoBindingSource.DataSource = this.controlTiemposDataSetempleado;
            // 
            // controlTiemposDataSetempleado
            // 
            this.controlTiemposDataSetempleado.DataSetName = "ControlTiemposDataSetempleado";
            this.controlTiemposDataSetempleado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEmpresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEmpresa.DataSource = this.cmbEmpresaBindingSource;
            this.cmbEmpresa.DisplayMember = "Nombre_Empresa";
            this.cmbEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbEmpresa.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(79, 45);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(306, 22);
            this.cmbEmpresa.TabIndex = 0;
            this.cmbEmpresa.MouseLeave += new System.EventHandler(this.comboAdminEmpresa_MouseLeave);
            this.cmbEmpresa.MouseMove += new System.Windows.Forms.MouseEventHandler(this.comboAdminEmpresa_MouseMove);
            // 
            // cmbEmpresaBindingSource
            // 
            this.cmbEmpresaBindingSource.DataMember = "cmbEmpresa";
            this.cmbEmpresaBindingSource.DataSource = this.ctDataSetcmEmpre;
            // 
            // ctDataSetcmEmpre
            // 
            this.ctDataSetcmEmpre.DataSetName = "ControlTiemposDataSet1";
            this.ctDataSetcmEmpre.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // picBuscar
            // 
            this.picBuscar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.picBuscar.Image = global::ControlDeTiempos.Properties.Resources.buscar;
            this.picBuscar.Location = new System.Drawing.Point(432, 85);
            this.picBuscar.Name = "picBuscar";
            this.picBuscar.Size = new System.Drawing.Size(55, 51);
            this.picBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBuscar.TabIndex = 2;
            this.picBuscar.TabStop = false;
            this.picBuscar.Click += new System.EventHandler(this.picBuscar_Click);
            this.picBuscar.MouseLeave += new System.EventHandler(this.picBuscar_MouseLeave);
            this.picBuscar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBuscar_MouseMove);
            // 
            // errorProviderAdmin
            // 
            this.errorProviderAdmin.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(431, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "CALCULAR \r\nHRS";
            // 
            // ejercicioTableAdapter
            // 
            this.ejercicioTableAdapter.ClearBeforeFill = true;
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // cmbEmpresaTableAdapter
            // 
            this.cmbEmpresaTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(8, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 162);
            this.panel2.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.picBuscar);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 156);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // CalculadorHrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(547, 180);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(567, 228);
            this.MinimumSize = new System.Drawing.Size(567, 223);
            this.Name = "CalculadorHrs";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular Horas";
            this.Load += new System.EventHandler(this.Administrador_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ejercicioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlTiemposDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlTiemposDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlTiemposDataSetempleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEmpresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctDataSetcmEmpre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAdmin)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblempleado;
        private System.Windows.Forms.Label lblaño;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.ComboBox cmbAño;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.PictureBox picBuscar;
        private System.Windows.Forms.ErrorProvider errorProviderAdmin;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cmbArea;
        private ControlTiemposDataSet controlTiemposDataSet;
        private System.Windows.Forms.BindingSource controlTiemposDataSetBindingSource;
        private System.Windows.Forms.BindingSource ejercicioBindingSource;
        private ControlTiemposDataSetTableAdapters.EjercicioTableAdapter ejercicioTableAdapter;
        private ControlTiemposDataSetempleado controlTiemposDataSetempleado;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private ControlTiemposDataSetempleadoTableAdapters.empleadoTableAdapter empleadoTableAdapter;
        private ControlTiemposDataSet1 ctDataSetcmEmpre;
        private System.Windows.Forms.BindingSource cmbEmpresaBindingSource;
        private ControlTiemposDataSet1TableAdapters.cmbEmpresaTableAdapter cmbEmpresaTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}