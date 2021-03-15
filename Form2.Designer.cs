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
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textKilometrosRecorridos = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.MayorRecorrido = new System.Windows.Forms.Label();
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxPlaca = new System.Windows.Forms.ComboBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.dateTimePickerAlquilar = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDevolucion = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.buttonDatos = new System.Windows.Forms.Button();
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
            this.labelNitAlquiler.Location = new System.Drawing.Point(26, 127);
            this.labelNitAlquiler.Name = "labelNitAlquiler";
            this.labelNitAlquiler.Size = new System.Drawing.Size(20, 13);
            this.labelNitAlquiler.TabIndex = 1;
            this.labelNitAlquiler.Text = "Nit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Placa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de Alquiler";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha devolucion";
            // 
            // textNit
            // 
            this.textNit.Location = new System.Drawing.Point(79, 127);
            this.textNit.Name = "textNit";
            this.textNit.Size = new System.Drawing.Size(127, 20);
            this.textNit.TabIndex = 7;
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Location = new System.Drawing.Point(33, 397);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(102, 60);
            this.buttonIngresar.TabIndex = 11;
            this.buttonIngresar.Text = "Guardat Datos";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Kilometros Recorridos";
            // 
            // textKilometrosRecorridos
            // 
            this.textKilometrosRecorridos.Location = new System.Drawing.Point(106, 344);
            this.textKilometrosRecorridos.Name = "textKilometrosRecorridos";
            this.textKilometrosRecorridos.Size = new System.Drawing.Size(100, 20);
            this.textKilometrosRecorridos.TabIndex = 14;
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
            // buttonRegresar
            // 
            this.buttonRegresar.Location = new System.Drawing.Point(180, 416);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(75, 23);
            this.buttonRegresar.TabIndex = 20;
            this.buttonRegresar.Text = "Regresar ";
            this.buttonRegresar.UseVisualStyleBackColor = true;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Nombre";
            // 
            // comboBoxPlaca
            // 
            this.comboBoxPlaca.FormattingEnabled = true;
            this.comboBoxPlaca.Location = new System.Drawing.Point(79, 52);
            this.comboBoxPlaca.Name = "comboBoxPlaca";
            this.comboBoxPlaca.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPlaca.TabIndex = 22;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(79, 88);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(248, 20);
            this.textBoxNombre.TabIndex = 23;
            // 
            // dateTimePickerAlquilar
            // 
            this.dateTimePickerAlquilar.Location = new System.Drawing.Point(104, 212);
            this.dateTimePickerAlquilar.Name = "dateTimePickerAlquilar";
            this.dateTimePickerAlquilar.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerAlquilar.TabIndex = 24;
            // 
            // dateTimePickerDevolucion
            // 
            this.dateTimePickerDevolucion.Location = new System.Drawing.Point(106, 261);
            this.dateTimePickerDevolucion.Name = "dateTimePickerDevolucion";
            this.dateTimePickerDevolucion.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDevolucion.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Direccion";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(79, 163);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(248, 20);
            this.textBoxDireccion.TabIndex = 27;
            // 
            // buttonDatos
            // 
            this.buttonDatos.Location = new System.Drawing.Point(299, 416);
            this.buttonDatos.Name = "buttonDatos";
            this.buttonDatos.Size = new System.Drawing.Size(100, 41);
            this.buttonDatos.TabIndex = 28;
            this.buttonDatos.Text = "Datos";
            this.buttonDatos.UseVisualStyleBackColor = true;
            this.buttonDatos.Click += new System.EventHandler(this.buttonDatos_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 487);
            this.Controls.Add(this.buttonDatos);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerDevolucion);
            this.Controls.Add(this.dateTimePickerAlquilar);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.comboBoxPlaca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonRegresar);
            this.Controls.Add(this.MayorRecorrido);
            this.Controls.Add(this.textKilometrosRecorridos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.textNit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNitAlquiler);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
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
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textKilometrosRecorridos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label MayorRecorrido;
        private System.Windows.Forms.Button buttonRegresar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxPlaca;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.DateTimePicker dateTimePickerAlquilar;
        private System.Windows.Forms.DateTimePicker dateTimePickerDevolucion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Button buttonDatos;
    }
}