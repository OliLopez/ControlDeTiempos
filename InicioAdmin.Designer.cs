namespace ControlDeTiempos
{
    partial class InicioAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioAdmin));
            this.label2 = new System.Windows.Forms.Label();
            this.picformModi = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picAB = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picBuscar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picformModi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(133, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 34);
            this.label2.TabIndex = 17;
            this.label2.Text = "Modificar \r\ny consultar";
            // 
            // picformModi
            // 
            this.picformModi.BackColor = System.Drawing.Color.DarkGray;
            this.picformModi.Image = global::ControlDeTiempos.Properties.Resources.portafolio;
            this.picformModi.Location = new System.Drawing.Point(136, 35);
            this.picformModi.Name = "picformModi";
            this.picformModi.Size = new System.Drawing.Size(55, 60);
            this.picformModi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picformModi.TabIndex = 16;
            this.picformModi.TabStop = false;
            this.picformModi.Click += new System.EventHandler(this.picformModi_Click);
            this.picformModi.MouseLeave += new System.EventHandler(this.picformModi_MouseLeave);
            this.picformModi.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picformModi_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 34);
            this.label1.TabIndex = 14;
            this.label1.Text = "Altas\r\n y bajas";
            // 
            // picAB
            // 
            this.picAB.BackColor = System.Drawing.Color.DarkGray;
            this.picAB.Image = global::ControlDeTiempos.Properties.Resources.anadir;
            this.picAB.Location = new System.Drawing.Point(34, 35);
            this.picAB.Name = "picAB";
            this.picAB.Size = new System.Drawing.Size(55, 60);
            this.picAB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAB.TabIndex = 15;
            this.picAB.TabStop = false;
            this.picAB.Click += new System.EventHandler(this.picAB_Click);
            this.picAB.MouseLeave += new System.EventHandler(this.picAB_MouseLeave);
            this.picAB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picAB_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(236, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 34);
            this.label3.TabIndex = 19;
            this.label3.Text = "Calcular\r\n horas";
            // 
            // picBuscar
            // 
            this.picBuscar.BackColor = System.Drawing.Color.DarkGray;
            this.picBuscar.Image = global::ControlDeTiempos.Properties.Resources.calculadora;
            this.picBuscar.Location = new System.Drawing.Point(239, 35);
            this.picBuscar.Name = "picBuscar";
            this.picBuscar.Size = new System.Drawing.Size(55, 60);
            this.picBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBuscar.TabIndex = 18;
            this.picBuscar.TabStop = false;
            this.picBuscar.Click += new System.EventHandler(this.picBuscar_Click);
            this.picBuscar.MouseLeave += new System.EventHandler(this.picBuscar_MouseLeave);
            this.picBuscar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBuscar_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.picAB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.picBuscar);
            this.panel1.Controls.Add(this.picformModi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 174);
            this.panel1.TabIndex = 20;
            // 
            // InicioAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImage = global::ControlDeTiempos.Properties.Resources.fondo_azul_oscuro;
            this.ClientSize = new System.Drawing.Size(343, 188);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InicioAdmin";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InicioAdmin_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picformModi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picformModi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picAB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picBuscar;
        private System.Windows.Forms.Panel panel1;
    }
}