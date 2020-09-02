namespace ControlDeTiempos
{
    partial class AltaBajaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaBajaForm));
            this.groupb1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picAltas = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.lbConcepto = new System.Windows.Forms.Label();
            this.lblaño = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lbContra = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.picBajas = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbEliminar = new System.Windows.Forms.ComboBox();
            this.errorProviderA = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblLeyendaBaja = new System.Windows.Forms.Label();
            this.groupb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAltas)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBajas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupb1
            // 
            this.groupb1.Controls.Add(this.label2);
            this.groupb1.Controls.Add(this.picAltas);
            this.groupb1.Controls.Add(this.panel1);
            this.groupb1.Controls.Add(this.panel2);
            this.groupb1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupb1.Location = new System.Drawing.Point(27, 18);
            this.groupb1.Name = "groupb1";
            this.groupb1.Size = new System.Drawing.Size(437, 380);
            this.groupb1.TabIndex = 0;
            this.groupb1.TabStop = false;
            this.groupb1.Text = "Registrar usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Agregar:";
            // 
            // picAltas
            // 
            this.picAltas.Image = global::ControlDeTiempos.Properties.Resources.anadir;
            this.picAltas.Location = new System.Drawing.Point(381, 151);
            this.picAltas.Name = "picAltas";
            this.picAltas.Size = new System.Drawing.Size(50, 54);
            this.picAltas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAltas.TabIndex = 2;
            this.picAltas.TabStop = false;
            this.picAltas.Click += new System.EventHandler(this.picAltas_Click);
            this.picAltas.MouseLeave += new System.EventHandler(this.picAltas_MouseLeave);
            this.picAltas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picAltas_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtAño);
            this.panel1.Controls.Add(this.txtEmpresa);
            this.panel1.Controls.Add(this.txtConcepto);
            this.panel1.Controls.Add(this.lbConcepto);
            this.panel1.Controls.Add(this.lblaño);
            this.panel1.Controls.Add(this.lblEmpresa);
            this.panel1.Location = new System.Drawing.Point(6, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 147);
            this.panel1.TabIndex = 2;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(276, 25);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(125, 25);
            this.txtAño.TabIndex = 12;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(97, 62);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(304, 25);
            this.txtEmpresa.TabIndex = 11;
            // 
            // txtConcepto
            // 
            this.txtConcepto.Location = new System.Drawing.Point(97, 98);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(304, 25);
            this.txtConcepto.TabIndex = 10;
            // 
            // lbConcepto
            // 
            this.lbConcepto.AutoSize = true;
            this.lbConcepto.BackColor = System.Drawing.Color.Transparent;
            this.lbConcepto.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConcepto.Location = new System.Drawing.Point(4, 101);
            this.lbConcepto.Name = "lbConcepto";
            this.lbConcepto.Size = new System.Drawing.Size(71, 17);
            this.lbConcepto.TabIndex = 7;
            this.lbConcepto.Text = "Concepto";
            // 
            // lblaño
            // 
            this.lblaño.AutoSize = true;
            this.lblaño.BackColor = System.Drawing.Color.Transparent;
            this.lblaño.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaño.Location = new System.Drawing.Point(8, 22);
            this.lblaño.Name = "lblaño";
            this.lblaño.Size = new System.Drawing.Size(64, 17);
            this.lblaño.TabIndex = 6;
            this.lblaño.Text = "Ejercicio";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpresa.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.Location = new System.Drawing.Point(8, 62);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(68, 17);
            this.lblEmpresa.TabIndex = 5;
            this.lblEmpresa.Text = "Empresa";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtContra);
            this.panel2.Controls.Add(this.txtUsuario);
            this.panel2.Controls.Add(this.lbContra);
            this.panel2.Controls.Add(this.lblEmpleado);
            this.panel2.Location = new System.Drawing.Point(6, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 120);
            this.panel2.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(132, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(201, 25);
            this.txtNombre.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre";
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(132, 77);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(201, 25);
            this.txtContra.TabIndex = 11;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(132, 15);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(201, 25);
            this.txtUsuario.TabIndex = 10;
            // 
            // lbContra
            // 
            this.lbContra.AutoSize = true;
            this.lbContra.BackColor = System.Drawing.Color.Transparent;
            this.lbContra.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContra.Location = new System.Drawing.Point(8, 77);
            this.lbContra.Name = "lbContra";
            this.lbContra.Size = new System.Drawing.Size(84, 17);
            this.lbContra.TabIndex = 9;
            this.lbContra.Text = "Contraseña";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpleado.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(9, 15);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(58, 17);
            this.lblEmpleado.TabIndex = 8;
            this.lblEmpleado.Text = "Usuario";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvResult);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(493, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 310);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados";
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.AllowUserToOrderColumns = true;
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvResult.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResult.ColumnHeadersHeight = 38;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResult.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResult.EnableHeadersVisualStyles = false;
            this.dgvResult.Location = new System.Drawing.Point(3, 21);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvResult.Size = new System.Drawing.Size(399, 286);
            this.dgvResult.TabIndex = 0;
            this.dgvResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResult_CellClick);
            // 
            // picBajas
            // 
            this.picBajas.Image = global::ControlDeTiempos.Properties.Resources.documento;
            this.picBajas.Location = new System.Drawing.Point(717, 11);
            this.picBajas.Name = "picBajas";
            this.picBajas.Size = new System.Drawing.Size(50, 57);
            this.picBajas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBajas.TabIndex = 4;
            this.picBajas.TabStop = false;
            this.picBajas.Click += new System.EventHandler(this.picBajas_Click);
            this.picBajas.MouseLeave += new System.EventHandler(this.picBajas_MouseLeave);
            this.picBajas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBajas_MouseMove);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Controls.Add(this.cmbEliminar);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(493, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 62);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eliminar: ";
            // 
            // cmbEliminar
            // 
            this.cmbEliminar.FormattingEnabled = true;
            this.cmbEliminar.Items.AddRange(new object[] {
            "Empleados",
            "Empresas"});
            this.cmbEliminar.Location = new System.Drawing.Point(18, 24);
            this.cmbEliminar.Name = "cmbEliminar";
            this.cmbEliminar.Size = new System.Drawing.Size(188, 25);
            this.cmbEliminar.TabIndex = 0;
            this.cmbEliminar.SelectedIndexChanged += new System.EventHandler(this.cmbEliminar_SelectedIndexChanged);
            // 
            // errorProviderA
            // 
            this.errorProviderA.ContainerControl = this;
            // 
            // lblLeyendaBaja
            // 
            this.lblLeyendaBaja.AutoSize = true;
            this.lblLeyendaBaja.Location = new System.Drawing.Point(773, 18);
            this.lblLeyendaBaja.Name = "lblLeyendaBaja";
            this.lblLeyendaBaja.Size = new System.Drawing.Size(119, 39);
            this.lblLeyendaBaja.TabIndex = 6;
            this.lblLeyendaBaja.Text = "No se ha seleecionado \r\nningun elemento\r\n para eliminar";
            // 
            // AltaBajaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 431);
            this.Controls.Add(this.lblLeyendaBaja);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picBajas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupb1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AltaBajaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Altas y Bajas";
            this.Load += new System.EventHandler(this.AltaBajaForm_Load);
            this.groupb1.ResumeLayout(false);
            this.groupb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAltas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBajas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupb1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.Label lbConcepto;
        private System.Windows.Forms.Label lblaño;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lbContra;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.PictureBox picAltas;
        private System.Windows.Forms.PictureBox picBajas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbEliminar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProviderA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLeyendaBaja;
    }
}