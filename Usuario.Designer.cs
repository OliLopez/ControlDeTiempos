namespace ControlDeTiempos
{
    partial class Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textHRS = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.picBoxNotaConcepto = new System.Windows.Forms.PictureBox();
            this.btnVerHr = new System.Windows.Forms.Button();
            this.btnCapurarHr = new System.Windows.Forms.Button();
            this.comboArea = new System.Windows.Forms.ComboBox();
            this.comboConcepto = new System.Windows.Forms.ComboBox();
            this.comboAño = new System.Windows.Forms.ComboBox();
            this.comboEmpresa = new System.Windows.Forms.ComboBox();
            this.lbBienvenido = new System.Windows.Forms.Label();
            this.errorProviderUsuario = new System.Windows.Forms.ErrorProvider(this.components);
            this.picError = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNotaConcepto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picError)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textHRS);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.picBoxNotaConcepto);
            this.panel1.Controls.Add(this.btnVerHr);
            this.panel1.Controls.Add(this.btnCapurarHr);
            this.panel1.Controls.Add(this.comboArea);
            this.panel1.Controls.Add(this.comboConcepto);
            this.panel1.Controls.Add(this.comboAño);
            this.panel1.Controls.Add(this.comboEmpresa);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(9, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 287);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Area";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "HRS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Concepto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ejercicio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Empresa";
            // 
            // textHRS
            // 
            this.textHRS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            this.textHRS.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHRS.ForeColor = System.Drawing.SystemColors.Control;
            this.textHRS.Location = new System.Drawing.Point(297, 163);
            this.textHRS.Name = "textHRS";
            this.textHRS.Size = new System.Drawing.Size(66, 26);
            this.textHRS.TabIndex = 8;
            this.textHRS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textHRS.Click += new System.EventHandler(this.textHRS_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.DarkGray;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(1, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(279, 26);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // picBoxNotaConcepto
            // 
            this.picBoxNotaConcepto.BackColor = System.Drawing.Color.DodgerBlue;
            this.picBoxNotaConcepto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxNotaConcepto.Image = global::ControlDeTiempos.Properties.Resources.lupa;
            this.picBoxNotaConcepto.Location = new System.Drawing.Point(369, 137);
            this.picBoxNotaConcepto.Name = "picBoxNotaConcepto";
            this.picBoxNotaConcepto.Size = new System.Drawing.Size(42, 21);
            this.picBoxNotaConcepto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxNotaConcepto.TabIndex = 6;
            this.picBoxNotaConcepto.TabStop = false;
            this.picBoxNotaConcepto.MouseLeave += new System.EventHandler(this.picBoxNotaConcepto_MouseLeave);
            this.picBoxNotaConcepto.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBoxNotaConcepto_MouseMove);
            // 
            // btnVerHr
            // 
            this.btnVerHr.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVerHr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerHr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerHr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVerHr.Location = new System.Drawing.Point(271, 232);
            this.btnVerHr.Name = "btnVerHr";
            this.btnVerHr.Size = new System.Drawing.Size(92, 54);
            this.btnVerHr.TabIndex = 5;
            this.btnVerHr.Text = "Visualizar horas";
            this.btnVerHr.UseVisualStyleBackColor = false;
            this.btnVerHr.MouseLeave += new System.EventHandler(this.btnVerHr_MouseLeave);
            this.btnVerHr.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnVerHr_MouseMove);
            // 
            // btnCapurarHr
            // 
            this.btnCapurarHr.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCapurarHr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapurarHr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapurarHr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCapurarHr.Location = new System.Drawing.Point(107, 232);
            this.btnCapurarHr.Name = "btnCapurarHr";
            this.btnCapurarHr.Size = new System.Drawing.Size(86, 54);
            this.btnCapurarHr.TabIndex = 4;
            this.btnCapurarHr.Text = "Capturar hora";
            this.btnCapurarHr.UseVisualStyleBackColor = false;
            this.btnCapurarHr.Click += new System.EventHandler(this.btnCapurarHr_Click);
            this.btnCapurarHr.MouseLeave += new System.EventHandler(this.btnCapurarHr_MouseLeave);
            this.btnCapurarHr.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCapurarHr_MouseMove);
            // 
            // comboArea
            // 
            this.comboArea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboArea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            this.comboArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboArea.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboArea.ForeColor = System.Drawing.SystemColors.Control;
            this.comboArea.FormattingEnabled = true;
            this.comboArea.Location = new System.Drawing.Point(72, 106);
            this.comboArea.Name = "comboArea";
            this.comboArea.Size = new System.Drawing.Size(291, 22);
            this.comboArea.TabIndex = 3;
            this.comboArea.SelectedIndexChanged += new System.EventHandler(this.comboArea_SelectedIndexChanged);
            // 
            // comboConcepto
            // 
            this.comboConcepto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboConcepto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboConcepto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            this.comboConcepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboConcepto.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboConcepto.ForeColor = System.Drawing.SystemColors.Window;
            this.comboConcepto.FormattingEnabled = true;
            this.comboConcepto.Location = new System.Drawing.Point(156, 135);
            this.comboConcepto.Name = "comboConcepto";
            this.comboConcepto.Size = new System.Drawing.Size(207, 22);
            this.comboConcepto.TabIndex = 2;
            this.comboConcepto.SelectedIndexChanged += new System.EventHandler(this.comboConcepto_SelectedIndexChanged);
            // 
            // comboAño
            // 
            this.comboAño.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboAño.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboAño.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            this.comboAño.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboAño.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAño.ForeColor = System.Drawing.SystemColors.Window;
            this.comboAño.FormattingEnabled = true;
            this.comboAño.Location = new System.Drawing.Point(297, 67);
            this.comboAño.Name = "comboAño";
            this.comboAño.Size = new System.Drawing.Size(66, 26);
            this.comboAño.TabIndex = 1;
            this.comboAño.SelectedIndexChanged += new System.EventHandler(this.comboAño_SelectedIndexChanged);
            // 
            // comboEmpresa
            // 
            this.comboEmpresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboEmpresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            this.comboEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboEmpresa.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEmpresa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.comboEmpresa.FormattingEnabled = true;
            this.comboEmpresa.Location = new System.Drawing.Point(71, 39);
            this.comboEmpresa.Name = "comboEmpresa";
            this.comboEmpresa.Size = new System.Drawing.Size(292, 22);
            this.comboEmpresa.TabIndex = 0;
            this.comboEmpresa.SelectedIndexChanged += new System.EventHandler(this.comboEmpresa_SelectedIndexChanged);
            // 
            // lbBienvenido
            // 
            this.lbBienvenido.AutoSize = true;
            this.lbBienvenido.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBienvenido.Location = new System.Drawing.Point(10, 7);
            this.lbBienvenido.Name = "lbBienvenido";
            this.lbBienvenido.Size = new System.Drawing.Size(87, 20);
            this.lbBienvenido.TabIndex = 1;
            this.lbBienvenido.Text = "Bienvenido, ";
            // 
            // errorProviderUsuario
            // 
            this.errorProviderUsuario.ContainerControl = this;
            // 
            // picError
            // 
            this.picError.BackColor = System.Drawing.Color.DarkRed;
            this.picError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picError.Location = new System.Drawing.Point(677, 220);
            this.picError.Name = "picError";
            this.picError.Size = new System.Drawing.Size(10, 32);
            this.picError.TabIndex = 15;
            this.picError.TabStop = false;
            this.picError.Visible = false;
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::ControlDeTiempos.Properties.Resources.diseño_interior_del_sitio_vacío;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(695, 337);
            this.Controls.Add(this.picError);
            this.Controls.Add(this.lbBienvenido);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Usuario";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.Usuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNotaConcepto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textHRS;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox picBoxNotaConcepto;
        private System.Windows.Forms.Button btnVerHr;
        private System.Windows.Forms.Button btnCapurarHr;
        private System.Windows.Forms.ComboBox comboArea;
        private System.Windows.Forms.ComboBox comboConcepto;
        private System.Windows.Forms.ComboBox comboAño;
        private System.Windows.Forms.ComboBox comboEmpresa;
        private System.Windows.Forms.Label lbBienvenido;
        private System.Windows.Forms.ErrorProvider errorProviderUsuario;
        private System.Windows.Forms.PictureBox picError;
    }
}