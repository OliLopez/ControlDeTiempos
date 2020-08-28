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
            this.ejercicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlTiemposDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlTiemposDataSet = new ControlDeTiempos.ControlTiemposDataSet();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlTiemposDataSetempleado = new ControlDeTiempos.ControlTiemposDataSetempleado();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.picBuscar = new System.Windows.Forms.PictureBox();
            this.errorProviderAdmin = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picAB = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picformModi = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ejercicioTableAdapter = new ControlDeTiempos.ControlTiemposDataSetTableAdapters.EjercicioTableAdapter();
            this.empleadoTableAdapter = new ControlDeTiempos.ControlTiemposDataSetempleadoTableAdapters.empleadoTableAdapter();
            this.ctDataSetcmEmpre = new ControlDeTiempos.ControlTiemposDataSet1();
            this.cmbEmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbEmpresaTableAdapter = new ControlDeTiempos.ControlTiemposDataSet1TableAdapters.cmbEmpresaTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ejercicioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlTiemposDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlTiemposDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlTiemposDataSetempleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAdmin)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picformModi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctDataSetcmEmpre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEmpresaBindingSource)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(23, 34);
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
            // picBuscar
            // 
            this.picBuscar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.picBuscar.Image = global::ControlDeTiempos.Properties.Resources.buscar;
            this.picBuscar.Location = new System.Drawing.Point(440, 81);
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.picBuscar);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 214);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONSULTAR HRS";
            // 
            // picAB
            // 
            this.picAB.Image = global::ControlDeTiempos.Properties.Resources.anadir;
            this.picAB.Location = new System.Drawing.Point(117, 282);
            this.picAB.Name = "picAB";
            this.picAB.Size = new System.Drawing.Size(55, 51);
            this.picAB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAB.TabIndex = 2;
            this.picAB.TabStop = false;
            this.picAB.Click += new System.EventHandler(this.picAB_Click);
            this.picAB.MouseLeave += new System.EventHandler(this.picAB_MouseLeave);
            this.picAB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picAB_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ALTAS Y BAJAS";
            // 
            // picformModi
            // 
            this.picformModi.Image = global::ControlDeTiempos.Properties.Resources.portafolio;
            this.picformModi.Location = new System.Drawing.Point(353, 284);
            this.picformModi.Name = "picformModi";
            this.picformModi.Size = new System.Drawing.Size(55, 51);
            this.picformModi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picformModi.TabIndex = 12;
            this.picformModi.TabStop = false;
            this.picformModi.Click += new System.EventHandler(this.picformModi_Click);
            this.picformModi.MouseLeave += new System.EventHandler(this.picformModi_MouseLeave);
            this.picformModi.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picformModi_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "MODIFICAR";
            // 
            // ejercicioTableAdapter
            // 
            this.ejercicioTableAdapter.ClearBeforeFill = true;
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // ctDataSetcmEmpre
            // 
            this.ctDataSetcmEmpre.DataSetName = "ControlTiemposDataSet1";
            this.ctDataSetcmEmpre.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbEmpresaBindingSource
            // 
            this.cmbEmpresaBindingSource.DataMember = "cmbEmpresa";
            this.cmbEmpresaBindingSource.DataSource = this.ctDataSetcmEmpre;
            // 
            // cmbEmpresaTableAdapter
            // 
            this.cmbEmpresaTableAdapter.ClearBeforeFill = true;
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(508, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picformModi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picAB);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Administrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Administrador_FormClosed);
            this.Load += new System.EventHandler(this.Administrador_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ejercicioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlTiemposDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlTiemposDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlTiemposDataSetempleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAdmin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picformModi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctDataSetcmEmpre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEmpresaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picAB;
        private System.Windows.Forms.PictureBox picformModi;
        private System.Windows.Forms.Label label2;
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
    }
}