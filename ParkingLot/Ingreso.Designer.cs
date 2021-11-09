namespace ParkingLot
{
    partial class Ingreso
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
            this.Lbltitulo = new System.Windows.Forms.Label();
            this.LblTipo = new System.Windows.Forms.Label();
            this.LblPlaca = new System.Windows.Forms.Label();
            this.Lblidentificacion = new System.Windows.Forms.Label();
            this.LblSexo = new System.Windows.Forms.Label();
            this.Lblafilicacion = new System.Windows.Forms.Label();
            this.LblDV = new System.Windows.Forms.Label();
            this.LblDC = new System.Windows.Forms.Label();
            this.LblMarca = new System.Windows.Forms.Label();
            this.TBSexo = new System.Windows.Forms.TextBox();
            this.TBIdentificacion = new System.Windows.Forms.TextBox();
            this.TBMarca = new System.Windows.Forms.TextBox();
            this.TBPlaca = new System.Windows.Forms.TextBox();
            this.ComboBoxTipo = new System.Windows.Forms.ComboBox();
            this.ComboBoxAfiliacion = new System.Windows.Forms.ComboBox();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.LblHora = new System.Windows.Forms.Label();
            this.TxtBHora = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lbltitulo
            // 
            this.Lbltitulo.AutoSize = true;
            this.Lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbltitulo.Location = new System.Drawing.Point(12, 9);
            this.Lbltitulo.Name = "Lbltitulo";
            this.Lbltitulo.Size = new System.Drawing.Size(401, 31);
            this.Lbltitulo.TabIndex = 0;
            this.Lbltitulo.Text = "Ingrese los datos del vehiculo";
            this.Lbltitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipo.Location = new System.Drawing.Point(60, 142);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(43, 16);
            this.LblTipo.TabIndex = 1;
            this.LblTipo.Text = "Tipo:";
            // 
            // LblPlaca
            // 
            this.LblPlaca.AutoSize = true;
            this.LblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlaca.Location = new System.Drawing.Point(59, 197);
            this.LblPlaca.Name = "LblPlaca";
            this.LblPlaca.Size = new System.Drawing.Size(51, 16);
            this.LblPlaca.TabIndex = 2;
            this.LblPlaca.Text = "Placa:";
            this.LblPlaca.Click += new System.EventHandler(this.label3_Click);
            // 
            // Lblidentificacion
            // 
            this.Lblidentificacion.AutoSize = true;
            this.Lblidentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblidentificacion.Location = new System.Drawing.Point(421, 142);
            this.Lblidentificacion.Name = "Lblidentificacion";
            this.Lblidentificacion.Size = new System.Drawing.Size(103, 16);
            this.Lblidentificacion.TabIndex = 4;
            this.Lblidentificacion.Text = "Identificación:";
            this.Lblidentificacion.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LblSexo
            // 
            this.LblSexo.AutoSize = true;
            this.LblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSexo.Location = new System.Drawing.Point(478, 198);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.Size = new System.Drawing.Size(46, 16);
            this.LblSexo.TabIndex = 5;
            this.LblSexo.Text = "Sexo:";
            // 
            // Lblafilicacion
            // 
            this.Lblafilicacion.AutoSize = true;
            this.Lblafilicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblafilicacion.Location = new System.Drawing.Point(449, 256);
            this.Lblafilicacion.Name = "Lblafilicacion";
            this.Lblafilicacion.Size = new System.Drawing.Size(75, 16);
            this.Lblafilicacion.TabIndex = 6;
            this.Lblafilicacion.Text = "Afiliación:";
            // 
            // LblDV
            // 
            this.LblDV.AutoSize = true;
            this.LblDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDV.Location = new System.Drawing.Point(59, 87);
            this.LblDV.Name = "LblDV";
            this.LblDV.Size = new System.Drawing.Size(157, 24);
            this.LblDV.TabIndex = 8;
            this.LblDV.Text = "Datos Vehiculo:";
            this.LblDV.Click += new System.EventHandler(this.label2_Click);
            // 
            // LblDC
            // 
            this.LblDC.AutoSize = true;
            this.LblDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDC.Location = new System.Drawing.Point(420, 87);
            this.LblDC.Name = "LblDC";
            this.LblDC.Size = new System.Drawing.Size(171, 24);
            this.LblDC.TabIndex = 9;
            this.LblDC.Text = "Datos Conductor:";
            // 
            // LblMarca
            // 
            this.LblMarca.AutoSize = true;
            this.LblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMarca.Location = new System.Drawing.Point(60, 256);
            this.LblMarca.Name = "LblMarca";
            this.LblMarca.Size = new System.Drawing.Size(54, 16);
            this.LblMarca.TabIndex = 3;
            this.LblMarca.Text = "Marca:";
            // 
            // TBSexo
            // 
            this.TBSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBSexo.Location = new System.Drawing.Point(530, 193);
            this.TBSexo.Name = "TBSexo";
            this.TBSexo.Size = new System.Drawing.Size(139, 22);
            this.TBSexo.TabIndex = 11;
            // 
            // TBIdentificacion
            // 
            this.TBIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBIdentificacion.Location = new System.Drawing.Point(530, 142);
            this.TBIdentificacion.Name = "TBIdentificacion";
            this.TBIdentificacion.Size = new System.Drawing.Size(139, 22);
            this.TBIdentificacion.TabIndex = 12;
            // 
            // TBMarca
            // 
            this.TBMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBMarca.Location = new System.Drawing.Point(120, 256);
            this.TBMarca.Name = "TBMarca";
            this.TBMarca.Size = new System.Drawing.Size(121, 22);
            this.TBMarca.TabIndex = 13;
            // 
            // TBPlaca
            // 
            this.TBPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPlaca.Location = new System.Drawing.Point(120, 197);
            this.TBPlaca.Name = "TBPlaca";
            this.TBPlaca.Size = new System.Drawing.Size(121, 22);
            this.TBPlaca.TabIndex = 14;
            // 
            // ComboBoxTipo
            // 
            this.ComboBoxTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxTipo.FormattingEnabled = true;
            this.ComboBoxTipo.Items.AddRange(new object[] {
            "Carro",
            "Camioneta",
            "MicroBus"});
            this.ComboBoxTipo.Location = new System.Drawing.Point(120, 142);
            this.ComboBoxTipo.Name = "ComboBoxTipo";
            this.ComboBoxTipo.Size = new System.Drawing.Size(121, 24);
            this.ComboBoxTipo.TabIndex = 16;
            this.ComboBoxTipo.Text = "Carro";
            // 
            // ComboBoxAfiliacion
            // 
            this.ComboBoxAfiliacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxAfiliacion.FormattingEnabled = true;
            this.ComboBoxAfiliacion.Items.AddRange(new object[] {
            "No",
            "Sí"});
            this.ComboBoxAfiliacion.Location = new System.Drawing.Point(530, 251);
            this.ComboBoxAfiliacion.Name = "ComboBoxAfiliacion";
            this.ComboBoxAfiliacion.Size = new System.Drawing.Size(139, 24);
            this.ComboBoxAfiliacion.TabIndex = 17;
            this.ComboBoxAfiliacion.Text = "No";
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.Location = new System.Drawing.Point(481, 337);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(152, 46);
            this.BtnIngresar.TabIndex = 19;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            this.BtnIngresar.Click += new System.EventHandler(this.button2_Click);
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora.Location = new System.Drawing.Point(60, 354);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(123, 16);
            this.LblHora.TabIndex = 20;
            this.LblHora.Text = "Hora de ingreso:";
            // 
            // TxtBHora
            // 
            this.TxtBHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBHora.Location = new System.Drawing.Point(189, 351);
            this.TxtBHora.Name = "TxtBHora";
            this.TxtBHora.Size = new System.Drawing.Size(177, 22);
            this.TxtBHora.TabIndex = 21;
            // 
            // Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 425);
            this.Controls.Add(this.TxtBHora);
            this.Controls.Add(this.LblHora);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.ComboBoxAfiliacion);
            this.Controls.Add(this.ComboBoxTipo);
            this.Controls.Add(this.TBPlaca);
            this.Controls.Add(this.TBMarca);
            this.Controls.Add(this.TBIdentificacion);
            this.Controls.Add(this.TBSexo);
            this.Controls.Add(this.LblMarca);
            this.Controls.Add(this.LblDC);
            this.Controls.Add(this.LblDV);
            this.Controls.Add(this.Lblafilicacion);
            this.Controls.Add(this.LblSexo);
            this.Controls.Add(this.Lblidentificacion);
            this.Controls.Add(this.LblPlaca);
            this.Controls.Add(this.LblTipo);
            this.Controls.Add(this.Lbltitulo);
            this.MaximumSize = new System.Drawing.Size(790, 464);
            this.MinimumSize = new System.Drawing.Size(790, 464);
            this.Name = "Ingreso";
            this.Text = "Ingreso de vehiculos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbltitulo;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.Label LblPlaca;
        private System.Windows.Forms.Label Lblidentificacion;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.Label Lblafilicacion;
        private System.Windows.Forms.Label LblDV;
        private System.Windows.Forms.Label LblDC;
        private System.Windows.Forms.Label LblMarca;
        private System.Windows.Forms.TextBox TBSexo;
        private System.Windows.Forms.TextBox TBIdentificacion;
        private System.Windows.Forms.TextBox TBMarca;
        private System.Windows.Forms.TextBox TBPlaca;
        private System.Windows.Forms.ComboBox ComboBoxTipo;
        private System.Windows.Forms.ComboBox ComboBoxAfiliacion;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.TextBox TxtBHora;
    }
}