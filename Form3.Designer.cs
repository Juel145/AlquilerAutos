
namespace AlquilerAutos
{
    partial class Form3
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
            this.dataGridViewReporte = new System.Windows.Forms.DataGridView();
            this.dataGridViewDatosVehiculos = new System.Windows.Forms.DataGridView();
            this.dataGridViewDatosAlquiler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelMayorRecorrido = new System.Windows.Forms.Label();
            this.buttonRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatosVehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatosAlquiler)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReporte
            // 
            this.dataGridViewReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReporte.Location = new System.Drawing.Point(22, 44);
            this.dataGridViewReporte.Name = "dataGridViewReporte";
            this.dataGridViewReporte.Size = new System.Drawing.Size(417, 216);
            this.dataGridViewReporte.TabIndex = 0;
            // 
            // dataGridViewDatosVehiculos
            // 
            this.dataGridViewDatosVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDatosVehiculos.Location = new System.Drawing.Point(482, 44);
            this.dataGridViewDatosVehiculos.Name = "dataGridViewDatosVehiculos";
            this.dataGridViewDatosVehiculos.Size = new System.Drawing.Size(277, 179);
            this.dataGridViewDatosVehiculos.TabIndex = 1;
            // 
            // dataGridViewDatosAlquiler
            // 
            this.dataGridViewDatosAlquiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDatosAlquiler.Location = new System.Drawing.Point(482, 266);
            this.dataGridViewDatosAlquiler.Name = "dataGridViewDatosAlquiler";
            this.dataGridViewDatosAlquiler.Size = new System.Drawing.Size(277, 172);
            this.dataGridViewDatosAlquiler.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(497, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datos Vehiculos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Datos Alquiler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Reporte ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 54);
            this.button1.TabIndex = 6;
            this.button1.Text = "Mostrar Reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(51, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 49);
            this.button2.TabIndex = 7;
            this.button2.Text = "Mostrar Mayor Recorrido";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelMayorRecorrido
            // 
            this.labelMayorRecorrido.AutoSize = true;
            this.labelMayorRecorrido.Location = new System.Drawing.Point(164, 367);
            this.labelMayorRecorrido.Name = "labelMayorRecorrido";
            this.labelMayorRecorrido.Size = new System.Drawing.Size(85, 13);
            this.labelMayorRecorrido.TabIndex = 8;
            this.labelMayorRecorrido.Text = "Mayor Recorrido";
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.Location = new System.Drawing.Point(364, 386);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(75, 23);
            this.buttonRegresar.TabIndex = 9;
            this.buttonRegresar.Text = "Regresar";
            this.buttonRegresar.UseVisualStyleBackColor = true;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRegresar);
            this.Controls.Add(this.labelMayorRecorrido);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewDatosAlquiler);
            this.Controls.Add(this.dataGridViewDatosVehiculos);
            this.Controls.Add(this.dataGridViewReporte);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatosVehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatosAlquiler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReporte;
        private System.Windows.Forms.DataGridView dataGridViewDatosVehiculos;
        private System.Windows.Forms.DataGridView dataGridViewDatosAlquiler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelMayorRecorrido;
        private System.Windows.Forms.Button buttonRegresar;
    }
}