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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbAñoModificar = new System.Windows.Forms.ComboBox();
            this.cmbModificar = new System.Windows.Forms.ComboBox();
            this.picModificar = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvModificar = new System.Windows.Forms.DataGridView();
            this.controlTiemposDataSetempleado = new ControlDeTiempos.ControlTiemposDataSetempleado();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoTableAdapter = new ControlDeTiempos.ControlTiemposDataSetempleadoTableAdapters.empleadoTableAdapter();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picModificar)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlTiemposDataSetempleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.cmbAñoModificar);
            this.panel3.Controls.Add(this.cmbModificar);
            this.panel3.Controls.Add(this.picModificar);
            this.panel3.Location = new System.Drawing.Point(6, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(392, 51);
            this.panel3.TabIndex = 11;
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
            // picModificar
            // 
            this.picModificar.Image = global::ControlDeTiempos.Properties.Resources.portafolio;
            this.picModificar.Location = new System.Drawing.Point(318, 0);
            this.picModificar.Name = "picModificar";
            this.picModificar.Size = new System.Drawing.Size(55, 51);
            this.picModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picModificar.TabIndex = 11;
            this.picModificar.TabStop = false;
            this.picModificar.Click += new System.EventHandler(this.picModificar_Click_1);
            this.picModificar.MouseLeave += new System.EventHandler(this.picModificar_MouseLeave);
            this.picModificar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picModificar_MouseMove);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.dgvModificar);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1021, 399);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MODIFICAR";
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvModificar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvModificar.ColumnHeadersHeight = 38;
            this.dgvModificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvModificar.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvModificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvModificar.EnableHeadersVisualStyles = false;
            this.dgvModificar.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvModificar.Location = new System.Drawing.Point(3, 21);
            this.dgvModificar.Name = "dgvModificar";
            this.dgvModificar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvModificar.Size = new System.Drawing.Size(1015, 375);
            this.dgvModificar.TabIndex = 0;
            // 
            // controlTiemposDataSetempleado
            // 
            this.controlTiemposDataSetempleado.DataSetName = "ControlTiemposDataSetempleado";
            this.controlTiemposDataSetempleado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "empleado";
            this.empleadoBindingSource.DataSource = this.controlTiemposDataSetempleado;
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // Ventana_Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 469);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox2);
            this.Name = "Ventana_Modificar";
            this.Text = "Ventana_Modificar";
            this.Load += new System.EventHandler(this.Ventana_Modificar_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picModificar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlTiemposDataSetempleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbAñoModificar;
        private System.Windows.Forms.ComboBox cmbModificar;
        private System.Windows.Forms.PictureBox picModificar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvModificar;
        private ControlTiemposDataSetempleado controlTiemposDataSetempleado;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private ControlTiemposDataSetempleadoTableAdapters.empleadoTableAdapter empleadoTableAdapter;
    }
}