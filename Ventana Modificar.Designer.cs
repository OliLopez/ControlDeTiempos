namespace ControlDeTiempos
{
    partial class Ventana_Modificar
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.picEliminar = new System.Windows.Forms.PictureBox();
            this.cmbAñoModificar = new System.Windows.Forms.ComboBox();
            this.cmbModificar = new System.Windows.Forms.ComboBox();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlTiemposDataSetempleado = new ControlDeTiempos.ControlTiemposDataSetempleado();
            this.picVer = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvModificar = new System.Windows.Forms.DataGridView();
            this.empleadoTableAdapter = new ControlDeTiempos.ControlTiemposDataSetempleadoTableAdapters.empleadoTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlTiemposDataSetempleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVer)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.lblNum);
            this.panel3.Controls.Add(this.picEliminar);
            this.panel3.Controls.Add(this.cmbAñoModificar);
            this.panel3.Controls.Add(this.cmbModificar);
            this.panel3.Controls.Add(this.picVer);
            this.panel3.Location = new System.Drawing.Point(6, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(875, 51);
            this.panel3.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(466, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ultimo dato seleccionado:";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(498, 21);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(14, 13);
            this.lblNum.TabIndex = 14;
            this.lblNum.Text = "#";
            // 
            // picEliminar
            // 
            this.picEliminar.Image = global::ControlDeTiempos.Properties.Resources.documento;
            this.picEliminar.Location = new System.Drawing.Point(405, -3);
            this.picEliminar.Name = "picEliminar";
            this.picEliminar.Size = new System.Drawing.Size(55, 51);
            this.picEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEliminar.TabIndex = 13;
            this.picEliminar.TabStop = false;
            this.picEliminar.Click += new System.EventHandler(this.picEliminar_Click);
            this.picEliminar.MouseLeave += new System.EventHandler(this.picEliminar_MouseLeave);
            this.picEliminar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picEliminar_MouseMove);
            // 
            // cmbAñoModificar
            // 
            this.cmbAñoModificar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbAñoModificar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAñoModificar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAñoModificar.FormattingEnabled = true;
            this.cmbAñoModificar.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cmbAñoModificar.Location = new System.Drawing.Point(227, 11);
            this.cmbAñoModificar.Name = "cmbAñoModificar";
            this.cmbAñoModificar.Size = new System.Drawing.Size(66, 26);
            this.cmbAñoModificar.TabIndex = 10;
            // 
            // cmbModificar
            // 
            this.cmbModificar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbModificar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbModificar.DataSource = this.empleadoBindingSource;
            this.cmbModificar.DisplayMember = "Nombre";
            this.cmbModificar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModificar.FormattingEnabled = true;
            this.cmbModificar.Location = new System.Drawing.Point(16, 11);
            this.cmbModificar.Name = "cmbModificar";
            this.cmbModificar.Size = new System.Drawing.Size(205, 26);
            this.cmbModificar.TabIndex = 10;
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
            // picVer
            // 
            this.picVer.Image = global::ControlDeTiempos.Properties.Resources.avance;
            this.picVer.Location = new System.Drawing.Point(313, 0);
            this.picVer.Name = "picVer";
            this.picVer.Size = new System.Drawing.Size(55, 51);
            this.picVer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVer.TabIndex = 11;
            this.picVer.TabStop = false;
            this.picVer.Click += new System.EventHandler(this.picVer_Click_1);
            this.picVer.MouseLeave += new System.EventHandler(this.picVer_MouseLeave);
            this.picVer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picVer_MouseMove);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.dgvModificar);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(878, 577);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // dgvModificar
            // 
            this.dgvModificar.AllowUserToAddRows = false;
            this.dgvModificar.AllowUserToDeleteRows = false;
            this.dgvModificar.AllowUserToOrderColumns = true;
            this.dgvModificar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvModificar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvModificar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvModificar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvModificar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvModificar.ColumnHeadersHeight = 38;
            this.dgvModificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvModificar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvModificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvModificar.EnableHeadersVisualStyles = false;
            this.dgvModificar.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvModificar.Location = new System.Drawing.Point(3, 18);
            this.dgvModificar.Name = "dgvModificar";
            this.dgvModificar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvModificar.Size = new System.Drawing.Size(872, 556);
            this.dgvModificar.TabIndex = 0;
            this.dgvModificar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModificar_CellDoubleClick);
            this.dgvModificar.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModificar_CellValueChanged);
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ver";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Eliminar";
            // 
            // Ventana_Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 674);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox2);
            this.Name = "Ventana_Modificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana_Modificar";
            this.Load += new System.EventHandler(this.Ventana_Modificar_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlTiemposDataSetempleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVer)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbAñoModificar;
        private System.Windows.Forms.ComboBox cmbModificar;
        private System.Windows.Forms.PictureBox picVer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvModificar;
        private ControlTiemposDataSetempleado controlTiemposDataSetempleado;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private ControlTiemposDataSetempleadoTableAdapters.empleadoTableAdapter empleadoTableAdapter;
        private System.Windows.Forms.PictureBox picEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label label4;
    }
}