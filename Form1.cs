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

        private void GuardarCliente()
        {
           FileStream stream = new FileStream("clientes.txt", FileMode.OpenOrCreate, FileAccess.Write);
           StreamWriter writer = new StreamWriter(stream);
           foreach (var p in clientes)
            {
                writer.WriteLine(p.Nit);
                writer.WriteLine(p.Nombre);
                writer.WriteLine(p.Direccion);
            }
            writer.Close();

        }
        private void GuardarDatosVeculo()
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
        private void GuardarDatosAlquiler()
        {
            FileStream stream = new FileStream("datosalquiler.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            foreach (var p in datosAlquileres)
            {
                writer.WriteLine(p.Nit);
                writer.WriteLine(p.Placa);
                writer.WriteLine(p.FechaAlquiler);
                writer.WriteLine(p.FechaDevolucion);
                writer.WriteLine(p.KilometrosRecorridos);
            }
            writer.Close();

        }
        void LeerClientes()
        {

            FileStream stream = new FileStream("clientes.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

           
            while (reader.Peek() > -1)
            {
                Cliente clienteTemp = new Cliente();
                clienteTemp.Nit = Convert.ToInt32(reader.ReadLine());
                clienteTemp.Nombre = reader.ReadLine();
                clienteTemp.Direccion = reader.ReadLine();
                
                clientes.Add(clienteTemp);
                
            }
            reader.Close();

        }
        void LeerDatosVehiculo()
        {


            FileStream stream = new FileStream("datosvehiculos.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                DatosVehiculo datosVehiculoTemp = new DatosVehiculo();
                datosVehiculoTemp.Placa = reader.ReadLine();
                datosVehiculoTemp.Marca = reader.ReadLine();
                datosVehiculoTemp.Modelo = Convert.ToInt32(reader.ReadLine());
                datosVehiculoTemp.PrecioKilometro = float.Parse(reader.ReadLine());

                datosVehiculos.Add(datosVehiculoTemp);
             }
             reader.Close();

        }


        private void buttonValidar_Click(object sender, EventArgs e)
        {

        }
    }
}
