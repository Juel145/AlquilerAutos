namespace AlquilerAutos
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelNitAlquiler = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textNit = new System.Windows.Forms.TextBox();
            this.textPlaca = new System.Windows.Forms.TextBox();
            this.dataGridViewDatosVehiculo = new System.Windows.Forms.DataGridView();
            this.dataGridViewDatosalquiler = new System.Windows.Forms.DataGridView();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textKilometrosRecorridos = new System.Windows.Forms.TextBox();
            this.dataGridViewCalculo = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.sfechaAlquiler = new System.Windows.Forms.MonthCalendar();
            this.sfechaDevolucion = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.MayorRecorrido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatosVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatosalquiler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalculo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos del Alquiler";
            // 
            // labelNitAlquiler
            // 
            this.labelNitAlquiler.AutoSize = true;
            this.labelNitAlquiler.Location = new System.Drawing.Point(12, 35);
            this.labelNitAlquiler.Name = "labelNitAlquiler";
            this.labelNitAlquiler.Size = new System.Drawing.Size(20, 13);
            this.labelNitAlquiler.TabIndex = 1;
            this.labelNitAlquiler.Text = "Nit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Placa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de Alquiler";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha devolucion";
            // 
            // textNit
            // 
            this.textNit.Location = new System.Drawing.Point(50, 35);
            this.textNit.Name = "textNit";
            this.textNit.Size = new System.Drawing.Size(127, 20);
            this.textNit.TabIndex = 7;
            // 
            // textPlaca
            // 
            this.textPlaca.Location = new System.Drawing.Point(52, 69);
            this.textPlaca.Name = "textPlaca";
            this.textPlaca.Size = new System.Drawing.Size(125, 20);
            this.textPlaca.TabIndex = 8;
            // 
            // dataGridViewDatosVehiculo
            // 
            this.dataGridViewDatosVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDatosVehiculo.Location = new System.Drawing.Point(412, 35);
            this.dataGridViewDatosVehiculo.Name = "dataGridViewDatosVehiculo";
            this.dataGridViewDatosVehiculo.Size = new System.Drawing.Size(341, 122);
            this.dataGridViewDatosVehiculo.TabIndex = 9;
            // 
            // dataGridViewDatosalquiler
            // 
            this.dataGridViewDatosalquiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDatosalquiler.Location = new System.Drawing.Point(412, 163);
            this.dataGridViewDatosalquiler.Name = "dataGridViewDatosalquiler";
            this.dataGridViewDatosalquiler.Size = new System.Drawing.Size(341, 127);
            this.dataGridViewDatosalquiler.TabIndex = 10;
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Location = new System.Drawing.Point(290, 226);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(102, 60);
            this.buttonIngresar.TabIndex = 11;
            this.buttonIngresar.Text = "Ingresar Datos";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Kilometros Recorridos";
            // 
            // textKilometrosRecorridos
            // 
            this.textKilometrosRecorridos.Location = new System.Drawing.Point(211, 65);
            this.textKilometrosRecorridos.Name = "textKilometrosRecorridos";
            this.textKilometrosRecorridos.Size = new System.Drawing.Size(100, 20);
            this.textKilometrosRecorridos.TabIndex = 14;
            // 
            // dataGridViewCalculo
            // 
            this.dataGridViewCalculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCalculo.Location = new System.Drawing.Point(412, 296);
            this.dataGridViewCalculo.Name = "dataGridViewCalculo";
            this.dataGridViewCalculo.Size = new System.Drawing.Size(341, 120);
            this.dataGridViewCalculo.TabIndex = 15;
            // 
            // sfechaAlquiler
            // 
            this.sfechaAlquiler.Location = new System.Drawing.Point(15, 124);
            this.sfechaAlquiler.Name = "sfechaAlquiler";
            this.sfechaAlquiler.TabIndex = 16;
            // 
            // sfechaDevolucion
            // 
            this.sfechaDevolucion.Location = new System.Drawing.Point(15, 315);
            this.sfechaDevolucion.Name = "sfechaDevolucion";
            this.sfechaDevolucion.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Mayor Kilometros Recorridos:";
            // 
            // MayorRecorrido
            // 
            this.MayorRecorrido.AutoSize = true;
            this.MayorRecorrido.Location = new System.Drawing.Point(578, 455);
            this.MayorRecorrido.Name = "MayorRecorrido";
            this.MayorRecorrido.Size = new System.Drawing.Size(35, 13);
            this.MayorRecorrido.TabIndex = 19;
            this.MayorRecorrido.Text = "label7";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.MayorRecorrido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sfechaDevolucion);
            this.Controls.Add(this.sfechaAlquiler);
            this.Controls.Add(this.dataGridViewCalculo);
            this.Controls.Add(this.textKilometrosRecorridos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.dataGridViewDatosalquiler);
            this.Controls.Add(this.dataGridViewDatosVehiculo);
            this.Controls.Add(this.textPlaca);
            this.Controls.Add(this.textNit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNitAlquiler);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatosVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatosalquiler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNitAlquiler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNit;
        private System.Windows.Forms.TextBox textPlaca;
        private System.Windows.Forms.DataGridView dataGridViewDatosVehiculo;
        private System.Windows.Forms.DataGridView dataGridViewDatosalquiler;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textKilometrosRecorridos;
        private System.Windows.Forms.DataGridView dataGridViewCalculo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MonthCalendar sfechaAlquiler;
        private System.Windows.Forms.MonthCalendar sfechaDevolucion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label MayorRecorrido;
    }
}