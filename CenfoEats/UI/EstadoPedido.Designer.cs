namespace CenfoEats.UI
{
    partial class EstadoPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstadoPedido));
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Título = new System.Windows.Forms.Label();
            this.Restaurantes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Salir = new System.Windows.Forms.Button();
            this.PendienteBar = new System.Windows.Forms.Label();
            this.EntregadoBar = new System.Windows.Forms.Label();
            this.EnCaminoBar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::CenfoEats.Properties.Resources.restaurante;
            this.pictureBox5.Location = new System.Drawing.Point(397, 20);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(44, 46);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 43;
            this.pictureBox5.TabStop = false;
            // 
            // Título
            // 
            this.Título.AutoSize = true;
            this.Título.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Título.Location = new System.Drawing.Point(12, 20);
            this.Título.Name = "Título";
            this.Título.Size = new System.Drawing.Size(133, 29);
            this.Título.TabIndex = 42;
            this.Título.Text = "CenfoEats";
            this.Título.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Restaurantes
            // 
            this.Restaurantes.AutoSize = true;
            this.Restaurantes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Restaurantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restaurantes.Location = new System.Drawing.Point(106, 103);
            this.Restaurantes.Name = "Restaurantes";
            this.Restaurantes.Size = new System.Drawing.Size(187, 27);
            this.Restaurantes.TabIndex = 44;
            this.Restaurantes.Text = "Estado del pedido";
            this.Restaurantes.Click += new System.EventHandler(this.Restaurantes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(132, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 49;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Salir
            // 
            this.Salir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Salir.FlatAppearance.BorderSize = 2;
            this.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.Location = new System.Drawing.Point(87, 542);
            this.Salir.Margin = new System.Windows.Forms.Padding(1);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(245, 64);
            this.Salir.TabIndex = 57;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // PendienteBar
            // 
            this.PendienteBar.BackColor = System.Drawing.SystemColors.Window;
            this.PendienteBar.Location = new System.Drawing.Point(29, 299);
            this.PendienteBar.Name = "PendienteBar";
            this.PendienteBar.Size = new System.Drawing.Size(131, 27);
            this.PendienteBar.TabIndex = 58;
            this.PendienteBar.Text = "                           ";
            // 
            // EntregadoBar
            // 
            this.EntregadoBar.BackColor = System.Drawing.SystemColors.Window;
            this.EntregadoBar.Location = new System.Drawing.Point(303, 299);
            this.EntregadoBar.Name = "EntregadoBar";
            this.EntregadoBar.Size = new System.Drawing.Size(131, 27);
            this.EntregadoBar.TabIndex = 59;
            this.EntregadoBar.Text = "                           ";
            // 
            // EnCaminoBar
            // 
            this.EnCaminoBar.BackColor = System.Drawing.SystemColors.Window;
            this.EnCaminoBar.Location = new System.Drawing.Point(166, 299);
            this.EnCaminoBar.Name = "EnCaminoBar";
            this.EnCaminoBar.Size = new System.Drawing.Size(131, 27);
            this.EnCaminoBar.TabIndex = 60;
            this.EnCaminoBar.Text = "                        ";
            this.EnCaminoBar.Click += new System.EventHandler(this.label4_Click);
            // 
            // EstadoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(459, 697);
            this.Controls.Add(this.EnCaminoBar);
            this.Controls.Add(this.EntregadoBar);
            this.Controls.Add(this.PendienteBar);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Restaurantes);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.Título);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EstadoPedido";
            this.Text = "EstadoPedido";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label Título;
        private System.Windows.Forms.Label Restaurantes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Label PendienteBar;
        private System.Windows.Forms.Label EntregadoBar;
        private System.Windows.Forms.Label EnCaminoBar;
    }
}