using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlquilerAutos
{
    public partial class Form1 : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        List<DatosVehiculo> datosVehiculos = new List<DatosVehiculo>();
        List<DatosAlquiler> datosAlquileres = new List<DatosAlquiler>();

        public Form1()
        {
            InitializeComponent();
        }

    
        private void GuardarDatosVehiculo()
        {
            FileStream stream = new FileStream("datosvehiculo.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            foreach (var p in datosVehiculos)
            {
                writer.WriteLine(p.Placa);
                writer.WriteLine(p.Marca);
                writer.WriteLine(p.Modelo);
                writer.WriteLine(p.Color);
                writer.WriteLine(p.PrecioKilometro);
            }
            writer.Close();

        }
     
        void LeerDatosVehiculo()
        {


            FileStream stream = new FileStream("datosvehiculo.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                DatosVehiculo datosVehiculoTemp = new DatosVehiculo();
                datosVehiculoTemp.Placa = reader.ReadLine();
                datosVehiculoTemp.Marca = reader.ReadLine();
                datosVehiculoTemp.Modelo = Convert.ToInt32(reader.ReadLine());
                datosVehiculoTemp.Color = reader.ReadLine();
                datosVehiculoTemp.PrecioKilometro = float.Parse(reader.ReadLine());

                datosVehiculos.Add(datosVehiculoTemp);
             }
             reader.Close();

        }


        private void buttonValidar_Click(object sender, EventArgs e)
        {
           
            LeerDatosVehiculo();
            DatosVehiculo datosVehiculoTemp = new DatosVehiculo();
            string placaVehiculo = textPlaca.Text;
            string marcaVechiculo = textMarca.Text;
            int modelovehiculo= Convert.ToInt32(numericUpDown1.Value);
            string colorVehiculo= textColor.Text;
            float precioKilometroVehiculo= float.Parse(textPrecioKilometro.Text);

            
                if (datosVehiculos.Exists(x => x.Placa == placaVehiculo) == true)
                {
                MessageBox.Show("El Vehiculo Ya Existe", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning );
                }
                else
                {
                
                datosVehiculoTemp.Placa = placaVehiculo;
                datosVehiculoTemp.Marca = marcaVechiculo;
                datosVehiculoTemp.Modelo = modelovehiculo;
                datosVehiculoTemp.Color = colorVehiculo;
                datosVehiculoTemp.PrecioKilometro = precioKilometroVehiculo;
                datosVehiculos.Add(datosVehiculoTemp);
                GuardarDatosVehiculo();
                Form2 frm2 = new Form2();

                frm2.Show();
                }
            



        }

        private void buttonDatos_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();

            frm3.Show();
        }
    }
}
