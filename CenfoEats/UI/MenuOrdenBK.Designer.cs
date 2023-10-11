using CenfoEats.BackEnd.Gestor;

namespace CenfoEats.UI
{
    partial class MenuOrdenBK
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
            this.Título = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Restaurantes = new System.Windows.Forms.Label();
            this.menuDespegableSedeRest = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.menuDespegableTipoPedido = new System.Windows.Forms.ComboBox();
            this.btnOrdenarBK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // Título
            // 
            this.Título.AutoSize = true;
            this.Título.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Título.Location = new System.Drawing.Point(15, 22);
            this.Título.Name = "Título";
            this.Título.Size = new System.Drawing.Size(133, 29);
            this.Título.TabIndex = 23;
            this.Título.Text = "CenfoEats";
            this.Título.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::CenfoEats.Properties.Resources.restaurante;
            this.pictureBox5.Location = new System.Drawing.Point(400, 22);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(44, 46);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 41;
            this.pictureBox5.TabStop = false;
            // 
            // Restaurantes
            // 
            this.Restaurantes.AutoSize = true;
            this.Restaurantes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Restaurantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restaurantes.Location = new System.Drawing.Point(40, 106);
            this.Restaurantes.Name = "Restaurantes";
            this.Restaurantes.Size = new System.Drawing.Size(333, 27);
            this.Restaurantes.TabIndex = 42;
            this.Restaurantes.Text = "Por favor confirme su restaurante";
            // 
            // menuDespegableSedeRest
            // 
            this.menuDespegableSedeRest.FormattingEnabled = true;
            this.menuDespegableSedeRest.Location = new System.Drawing.Point(40, 160);
            this.menuDespegableSedeRest.Margin = new System.Windows.Forms.Padding(4);
            this.menuDespegableSedeRest.Name = "menuDespegableSedeRest";
            this.menuDespegableSedeRest.Size = new System.Drawing.Size(333, 24);
            this.menuDespegableSedeRest.TabIndex = 43;
            this.menuDespegableSedeRest.SelectedIndexChanged += new System.EventHandler(this.Restaurante_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 27);
            this.label1.TabIndex = 44;
            this.label1.Text = "Detale de orden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 415);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Productos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(301, 415);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "2";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 446);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "Subtotal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(116, 480);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "IVA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(260, 446);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 49;
            this.label6.Text = "20.500";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(272, 480);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "2665";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(116, 511);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 51;
            this.label8.Text = "Total";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(259, 511);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 52;
            this.label9.Text = "23.165";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(40, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(354, 27);
            this.label10.TabIndex = 53;
            this.label10.Text = "Por favor confirme el tipo de pedido";
            // 
            // menuDespegableTipoPedido
            // 
            this.menuDespegableTipoPedido.DisplayMember = "55";
            this.menuDespegableTipoPedido.FormattingEnabled = true;
            this.menuDespegableTipoPedido.Items.AddRange(new object[] {
            "Express",
            "LLevar"});
            this.menuDespegableTipoPedido.Location = new System.Drawing.Point(40, 282);
            this.menuDespegableTipoPedido.Margin = new System.Windows.Forms.Padding(4);
            this.menuDespegableTipoPedido.Name = "menuDespegableTipoPedido";
            this.menuDespegableTipoPedido.Size = new System.Drawing.Size(333, 24);
            this.menuDespegableTipoPedido.TabIndex = 54;
            this.menuDespegableTipoPedido.SelectedIndexChanged += new System.EventHandler(this.menuDespegableTipoPedido_SelectedIndexChanged);
            // 
            // btnOrdenarBK
            // 
            this.btnOrdenarBK.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOrdenarBK.FlatAppearance.BorderSize = 2;
            this.btnOrdenarBK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenarBK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenarBK.Location = new System.Drawing.Point(95, 583);
            this.btnOrdenarBK.Margin = new System.Windows.Forms.Padding(1);
            this.btnOrdenarBK.Name = "btnOrdenarBK";
            this.btnOrdenarBK.Size = new System.Drawing.Size(245, 64);
            this.btnOrdenarBK.TabIndex = 56;
            this.btnOrdenarBK.Text = "Ordernar";
            this.btnOrdenarBK.UseVisualStyleBackColor = true;
            this.btnOrdenarBK.Click += new System.EventHandler(this.btnOrdenarBK_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(159, 602);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 57);
            this.panel1.TabIndex = 57;
            // 
            // MenuOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 697);
            this.ControlBox = false;
            this.Controls.Add(this.btnOrdenarBK);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuDespegableTipoPedido);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuDespegableSedeRest);
            this.Controls.Add(this.Restaurantes);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.Título);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuOrden";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Título;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label Restaurantes;
        private System.Windows.Forms.ComboBox menuDespegableSedeRest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox menuDespegableTipoPedido;
        private System.Windows.Forms.Button btnOrdenarBK;
        private System.Windows.Forms.Panel panel1;
    }
}