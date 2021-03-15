
namespace AlquilerAutos
{
    partial class Form1
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textPlaca = new System.Windows.Forms.TextBox();
            this.textMarca = new System.Windows.Forms.TextBox();
            this.textColor = new System.Windows.Forms.TextBox();
            this.buttonValidar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textPrecioKilometro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonDatos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Placa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Marca";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Color";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Modelo";
            // 
            // textPlaca
            // 
            this.textPlaca.Location = new System.Drawing.Point(70, 94);
            this.textPlaca.Name = "textPlaca";
            this.textPlaca.Size = new System.Drawing.Size(139, 20);
            this.textPlaca.TabIndex = 13;
            // 
            // textMarca
            // 
            this.textMarca.Location = new System.Drawing.Point(70, 150);
            this.textMarca.Name = "textMarca";
            this.textMarca.Size = new System.Drawing.Size(139, 20);
            this.textMarca.TabIndex = 14;
            // 
            // textColor
            // 
            this.textColor.Location = new System.Drawing.Point(70, 260);
            this.textColor.Name = "textColor";
            this.textColor.Size = new System.Drawing.Size(139, 20);
            this.textColor.TabIndex = 16;
            // 
            // buttonValidar
            // 
            this.buttonValidar.Location = new System.Drawing.Point(280, 343);
            this.buttonValidar.Name = "buttonValidar";
            this.buttonValidar.Size = new System.Drawing.Size(95, 50);
            this.buttonValidar.TabIndex = 17;
            this.buttonValidar.Text = "Validar";
            this.buttonValidar.UseVisualStyleBackColor = true;
            this.buttonValidar.Click += new System.EventHandler(this.buttonValidar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 317);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Precio Kilometro";
            // 
            // textPrecioKilometro
            // 
            this.textPrecioKilometro.Location = new System.Drawing.Point(97, 343);
            this.textPrecioKilometro.Name = "textPrecioKilometro";
            this.textPrecioKilometro.Size = new System.Drawing.Size(93, 20);
            this.textPrecioKilometro.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Datos Vehiculo";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(80, 206);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 20;
            this.numericUpDown1.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // buttonDatos
            // 
            this.buttonDatos.Location = new System.Drawing.Point(298, 260);
            this.buttonDatos.Name = "buttonDatos";
            this.buttonDatos.Size = new System.Drawing.Size(88, 39);
            this.buttonDatos.TabIndex = 21;
            this.buttonDatos.Text = "Mostrar Datos";
            this.buttonDatos.UseVisualStyleBackColor = true;
            this.buttonDatos.Click += new System.EventHandler(this.buttonDatos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 435);
            this.Controls.Add(this.buttonDatos);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textPrecioKilometro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonValidar);
            this.Controls.Add(this.textColor);
            this.Controls.Add(this.textMarca);
            this.Controls.Add(this.textPlaca);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textPlaca;
        private System.Windows.Forms.TextBox textMarca;
        private System.Windows.Forms.TextBox textColor;
        private System.Windows.Forms.Button buttonValidar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textPrecioKilometro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button buttonDatos;
    }
}

