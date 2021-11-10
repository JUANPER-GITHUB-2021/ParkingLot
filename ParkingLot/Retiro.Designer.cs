namespace ParkingLot
{
    partial class Retiro
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
            this.LbltituloR = new System.Windows.Forms.Label();
            this.LblidentificacionR = new System.Windows.Forms.Label();
            this.LblPlacaR = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LblO = new System.Windows.Forms.Label();
            this.BtnRetirar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbltituloR
            // 
            this.LbltituloR.AutoSize = true;
            this.LbltituloR.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbltituloR.Location = new System.Drawing.Point(12, 9);
            this.LbltituloR.Name = "LbltituloR";
            this.LbltituloR.Size = new System.Drawing.Size(381, 31);
            this.LbltituloR.TabIndex = 1;
            this.LbltituloR.Text = "Ingrese los datos del Retiro:";
            this.LbltituloR.Click += new System.EventHandler(this.Lbltitulo_Click);
            // 
            // LblidentificacionR
            // 
            this.LblidentificacionR.AutoSize = true;
            this.LblidentificacionR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblidentificacionR.Location = new System.Drawing.Point(47, 96);
            this.LblidentificacionR.Name = "LblidentificacionR";
            this.LblidentificacionR.Size = new System.Drawing.Size(103, 16);
            this.LblidentificacionR.TabIndex = 5;
            this.LblidentificacionR.Text = "Identificación:";
            this.LblidentificacionR.Click += new System.EventHandler(this.Lblidentificacion_Click);
            // 
            // LblPlacaR
            // 
            this.LblPlacaR.AutoSize = true;
            this.LblPlacaR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlacaR.Location = new System.Drawing.Point(99, 179);
            this.LblPlacaR.Name = "LblPlacaR";
            this.LblPlacaR.Size = new System.Drawing.Size(51, 16);
            this.LblPlacaR.TabIndex = 6;
            this.LblPlacaR.Text = "Placa:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(156, 179);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(143, 20);
            this.textBox2.TabIndex = 8;
            // 
            // LblO
            // 
            this.LblO.AutoSize = true;
            this.LblO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblO.Location = new System.Drawing.Point(167, 139);
            this.LblO.Name = "LblO";
            this.LblO.Size = new System.Drawing.Size(18, 16);
            this.LblO.TabIndex = 9;
            this.LblO.Text = "O";
            // 
            // BtnRetirar
            // 
            this.BtnRetirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRetirar.Location = new System.Drawing.Point(145, 259);
            this.BtnRetirar.Name = "BtnRetirar";
            this.BtnRetirar.Size = new System.Drawing.Size(121, 49);
            this.BtnRetirar.TabIndex = 10;
            this.BtnRetirar.Text = "Retirar";
            this.BtnRetirar.UseVisualStyleBackColor = true;
            // 
            // Retiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 349);
            this.Controls.Add(this.BtnRetirar);
            this.Controls.Add(this.LblO);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LblPlacaR);
            this.Controls.Add(this.LblidentificacionR);
            this.Controls.Add(this.LbltituloR);
            this.MaximumSize = new System.Drawing.Size(433, 388);
            this.MinimumSize = new System.Drawing.Size(433, 388);
            this.Name = "Retiro";
            this.Text = "Retiro de Vehiculos";
            this.Load += new System.EventHandler(this.Retiro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbltituloR;
        private System.Windows.Forms.Label LblidentificacionR;
        private System.Windows.Forms.Label LblPlacaR;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label LblO;
        private System.Windows.Forms.Button BtnRetirar;
    }
}