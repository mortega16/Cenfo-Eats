namespace CenfoEats
{
    partial class pantallaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIniciarSesión = new System.Windows.Forms.Button();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.txtBoxCorreo = new System.Windows.Forms.TextBox();
            this.txtBoxTelefono = new System.Windows.Forms.TextBox();
            this.Título = new System.Windows.Forms.Label();
            this.TextoBienvenida = new System.Windows.Forms.Label();
            this.Subtítulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtBoxTipo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciarSesión
            // 
            this.btnIniciarSesión.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnIniciarSesión.FlatAppearance.BorderSize = 2;
            this.btnIniciarSesión.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesión.Font = new System.Drawing.Font("Raleway SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesión.Location = new System.Drawing.Point(93, 451);
            this.btnIniciarSesión.Margin = new System.Windows.Forms.Padding(1);
            this.btnIniciarSesión.Name = "btnIniciarSesión";
            this.btnIniciarSesión.Size = new System.Drawing.Size(246, 64);
            this.btnIniciarSesión.TabIndex = 0;
            this.btnIniciarSesión.Text = "INICIAR SESIÓN";
            this.btnIniciarSesión.UseVisualStyleBackColor = true;
            this.btnIniciarSesión.Click += new System.EventHandler(this.btnIniciarSesión_Click);
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Font = new System.Drawing.Font("Raleway", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNombre.Location = new System.Drawing.Point(118, 230);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(286, 23);
            this.txtBoxNombre.TabIndex = 2;
            this.txtBoxNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtBoxCorreo
            // 
            this.txtBoxCorreo.Font = new System.Drawing.Font("Raleway", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCorreo.Location = new System.Drawing.Point(118, 267);
            this.txtBoxCorreo.Name = "txtBoxCorreo";
            this.txtBoxCorreo.Size = new System.Drawing.Size(286, 23);
            this.txtBoxCorreo.TabIndex = 3;
            this.txtBoxCorreo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtBoxTelefono
            // 
            this.txtBoxTelefono.Font = new System.Drawing.Font("Raleway", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTelefono.Location = new System.Drawing.Point(118, 305);
            this.txtBoxTelefono.Name = "txtBoxTelefono";
            this.txtBoxTelefono.Size = new System.Drawing.Size(286, 23);
            this.txtBoxTelefono.TabIndex = 4;
            this.txtBoxTelefono.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Título
            // 
            this.Título.AutoSize = true;
            this.Título.Font = new System.Drawing.Font("Raleway SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Título.Location = new System.Drawing.Point(22, 19);
            this.Título.Name = "Título";
            this.Título.Size = new System.Drawing.Size(125, 32);
            this.Título.TabIndex = 5;
            this.Título.Text = "CenfoEats";
            this.Título.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TextoBienvenida
            // 
            this.TextoBienvenida.AutoSize = true;
            this.TextoBienvenida.Font = new System.Drawing.Font("Raleway SemiBold", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoBienvenida.Location = new System.Drawing.Point(5, 61);
            this.TextoBienvenida.Name = "TextoBienvenida";
            this.TextoBienvenida.Size = new System.Drawing.Size(378, 75);
            this.TextoBienvenida.TabIndex = 7;
            this.TextoBienvenida.Text = "BIENVENIDO!\r\n";
            this.TextoBienvenida.Click += new System.EventHandler(this.TextoBienvenida_Click);
            // 
            // Subtítulo
            // 
            this.Subtítulo.AutoSize = true;
            this.Subtítulo.BackColor = System.Drawing.Color.Transparent;
            this.Subtítulo.Font = new System.Drawing.Font("Raleway Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtítulo.Location = new System.Drawing.Point(12, 136);
            this.Subtítulo.Name = "Subtítulo";
            this.Subtítulo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Subtítulo.Size = new System.Drawing.Size(328, 68);
            this.Subtítulo.TabIndex = 8;
            this.Subtítulo.Text = "desde un desayuno francés,\r\nhasta un almuerzo burgués";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Raleway SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(13, 223);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(89, 28);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Raleway SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(13, 260);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(71, 28);
            this.lblCorreo.TabIndex = 10;
            this.lblCorreo.Text = "E-Mail";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefono.Font = new System.Drawing.Font("Raleway SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(13, 298);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(94, 28);
            this.lblTelefono.TabIndex = 11;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipo.Font = new System.Drawing.Font("Raleway SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(24, 345);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(370, 48);
            this.lblTipo.TabIndex = 12;
            this.lblTipo.Text = "Escribí 1 si quieres colaborar como repartidor\r\n(o 2 si solo tenés hambre!)";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTipo.Click += new System.EventHandler(this.lblTipo_Click);
            // 
            // txtBoxTipo
            // 
            this.txtBoxTipo.Font = new System.Drawing.Font("Raleway", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTipo.Location = new System.Drawing.Point(191, 409);
            this.txtBoxTipo.Name = "txtBoxTipo";
            this.txtBoxTipo.Size = new System.Drawing.Size(43, 23);
            this.txtBoxTipo.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(157, 470);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 56);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CenfoEats.Properties.Resources.restaurante;
            this.pictureBox1.Location = new System.Drawing.Point(360, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CenfoEats.Properties.Resources.estrellas;
            this.pictureBox2.Location = new System.Drawing.Point(313, 144);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::CenfoEats.Properties.Resources.delivery_location;
            this.pictureBox3.Location = new System.Drawing.Point(23, 500);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(399, 206);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(434, 633);
            this.Controls.Add(this.txtBoxTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.Subtítulo);
            this.Controls.Add(this.TextoBienvenida);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Título);
            this.Controls.Add(this.btnIniciarSesión);
            this.Controls.Add(this.txtBoxTelefono);
            this.Controls.Add(this.txtBoxCorreo);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pantallaPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.pantallaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarSesión;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.TextBox txtBoxCorreo;
        private System.Windows.Forms.TextBox txtBoxTelefono;
        private System.Windows.Forms.Label Título;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TextoBienvenida;
        private System.Windows.Forms.Label Subtítulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtBoxTipo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

