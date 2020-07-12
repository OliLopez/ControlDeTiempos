﻿namespace ControlDeTiempos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrador));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelarea = new System.Windows.Forms.Label();
            this.labelempleado = new System.Windows.Forms.Label();
            this.labelaño = new System.Windows.Forms.Label();
            this.comboAdminAño = new System.Windows.Forms.ComboBox();
            this.comboAdminArea = new System.Windows.Forms.ComboBox();
            this.btnReporte = new System.Windows.Forms.Button();
            this.labelEmpresa = new System.Windows.Forms.Label();
            this.comboEmpleado = new System.Windows.Forms.ComboBox();
            this.comboAdminEmpresa = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.labelarea);
            this.panel1.Controls.Add(this.labelempleado);
            this.panel1.Controls.Add(this.labelaño);
            this.panel1.Controls.Add(this.comboAdminAño);
            this.panel1.Controls.Add(this.comboAdminArea);
            this.panel1.Controls.Add(this.btnReporte);
            this.panel1.Controls.Add(this.labelEmpresa);
            this.panel1.Controls.Add(this.comboEmpleado);
            this.panel1.Controls.Add(this.comboAdminEmpresa);
            this.panel1.Location = new System.Drawing.Point(10, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 268);
            this.panel1.TabIndex = 1;
            // 
            // labelarea
            // 
            this.labelarea.AutoSize = true;
            this.labelarea.BackColor = System.Drawing.Color.White;
            this.labelarea.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelarea.Location = new System.Drawing.Point(0, 139);
            this.labelarea.Name = "labelarea";
            this.labelarea.Size = new System.Drawing.Size(42, 18);
            this.labelarea.TabIndex = 8;
            this.labelarea.Text = "Area";
            // 
            // labelempleado
            // 
            this.labelempleado.AutoSize = true;
            this.labelempleado.BackColor = System.Drawing.Color.White;
            this.labelempleado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelempleado.Location = new System.Drawing.Point(-2, 93);
            this.labelempleado.Name = "labelempleado";
            this.labelempleado.Size = new System.Drawing.Size(80, 18);
            this.labelempleado.TabIndex = 7;
            this.labelempleado.Text = "Empleado";
            // 
            // labelaño
            // 
            this.labelaño.AutoSize = true;
            this.labelaño.BackColor = System.Drawing.Color.White;
            this.labelaño.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaño.Location = new System.Drawing.Point(2, 49);
            this.labelaño.Name = "labelaño";
            this.labelaño.Size = new System.Drawing.Size(36, 18);
            this.labelaño.TabIndex = 6;
            this.labelaño.Text = "Año";
            // 
            // comboAdminAño
            // 
            this.comboAdminAño.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboAdminAño.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboAdminAño.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAdminAño.FormattingEnabled = true;
            this.comboAdminAño.Location = new System.Drawing.Point(333, 46);
            this.comboAdminAño.Name = "comboAdminAño";
            this.comboAdminAño.Size = new System.Drawing.Size(66, 26);
            this.comboAdminAño.TabIndex = 1;
            this.comboAdminAño.MouseLeave += new System.EventHandler(this.comboAdminAño_MouseLeave);
            this.comboAdminAño.MouseMove += new System.Windows.Forms.MouseEventHandler(this.comboAdminAño_MouseMove);
            // 
            // comboAdminArea
            // 
            this.comboAdminArea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboAdminArea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboAdminArea.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAdminArea.FormattingEnabled = true;
            this.comboAdminArea.Location = new System.Drawing.Point(108, 140);
            this.comboAdminArea.Name = "comboAdminArea";
            this.comboAdminArea.Size = new System.Drawing.Size(291, 22);
            this.comboAdminArea.TabIndex = 3;
            this.comboAdminArea.MouseLeave += new System.EventHandler(this.comboAdminArea_MouseLeave);
            this.comboAdminArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.comboAdminArea_MouseMove);
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporte.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReporte.Location = new System.Drawing.Point(183, 208);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(93, 48);
            this.btnReporte.TabIndex = 4;
            this.btnReporte.Text = "Generar Reporte";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.MouseLeave += new System.EventHandler(this.btnReporte_MouseLeave);
            this.btnReporte.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnReporte_MouseMove);
            // 
            // labelEmpresa
            // 
            this.labelEmpresa.AutoSize = true;
            this.labelEmpresa.BackColor = System.Drawing.Color.White;
            this.labelEmpresa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpresa.Location = new System.Drawing.Point(3, 3);
            this.labelEmpresa.Name = "labelEmpresa";
            this.labelEmpresa.Size = new System.Drawing.Size(72, 18);
            this.labelEmpresa.TabIndex = 5;
            this.labelEmpresa.Text = "Empresa";
            // 
            // comboEmpleado
            // 
            this.comboEmpleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboEmpleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboEmpleado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEmpleado.FormattingEnabled = true;
            this.comboEmpleado.Location = new System.Drawing.Point(278, 93);
            this.comboEmpleado.Name = "comboEmpleado";
            this.comboEmpleado.Size = new System.Drawing.Size(121, 26);
            this.comboEmpleado.TabIndex = 2;
            this.comboEmpleado.MouseLeave += new System.EventHandler(this.comboEmpleado_MouseLeave);
            this.comboEmpleado.MouseMove += new System.Windows.Forms.MouseEventHandler(this.comboEmpleado_MouseMove);
            // 
            // comboAdminEmpresa
            // 
            this.comboAdminEmpresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboAdminEmpresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboAdminEmpresa.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAdminEmpresa.FormattingEnabled = true;
            this.comboAdminEmpresa.Location = new System.Drawing.Point(93, 4);
            this.comboAdminEmpresa.Name = "comboAdminEmpresa";
            this.comboAdminEmpresa.Size = new System.Drawing.Size(306, 22);
            this.comboAdminEmpresa.TabIndex = 0;
            this.comboAdminEmpresa.MouseLeave += new System.EventHandler(this.comboAdminEmpresa_MouseLeave);
            this.comboAdminEmpresa.MouseMove += new System.Windows.Forms.MouseEventHandler(this.comboAdminEmpresa_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.pictureBox1.Image = global::ControlDeTiempos.Properties.Resources.buscar;
            this.pictureBox1.Location = new System.Drawing.Point(425, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(526, 294);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Administrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.Administrador_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelarea;
        private System.Windows.Forms.Label labelempleado;
        private System.Windows.Forms.Label labelaño;
        private System.Windows.Forms.Label labelEmpresa;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.ComboBox comboAdminArea;
        private System.Windows.Forms.ComboBox comboEmpleado;
        private System.Windows.Forms.ComboBox comboAdminAño;
        private System.Windows.Forms.ComboBox comboAdminEmpresa;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}