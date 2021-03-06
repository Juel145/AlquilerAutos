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
    public partial class Form2 : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        List<DatosVehiculo> datosVehiculos = new List<DatosVehiculo>();
        List<DatosAlquiler> datosAlquileres = new List<DatosAlquiler>();
        List<Calculo> calculos = new List<Calculo>();
        public Form2()
        {
            InitializeComponent();
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
        void LeerDatosAlquiler()
        {


            FileStream stream = new FileStream("datosalquiler.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                DatosAlquiler datosAlquilerTemp = new DatosAlquiler();
                datosAlquilerTemp.Nit = Convert.ToInt32(reader.ReadLine());
                datosAlquilerTemp.Placa = reader.ReadLine();
                datosAlquilerTemp.FechaAlquiler = Convert.ToDateTime(reader.ReadLine());
                datosAlquilerTemp.FechaDevolucion = Convert.ToDateTime(reader.ReadLine());
                datosAlquilerTemp.KilometrosRecorridos = float.Parse(reader.ReadLine());

                datosAlquileres.Add(datosAlquilerTemp);
            }
            reader.Close();

        }
        private void GuardarDatosAlquiler()
        {
            FileStream stream = new FileStream("datosalquiler.txt", FileMode.Append, FileAccess.Write);
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
        
      
        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            datosAlquileres.Clear();
            clientes.Clear();
            datosVehiculos.Clear();
            LeerClientes();
            LeerDatosVehiculo();
            Cliente clientesTemp = new Cliente();
            DatosAlquiler datosAlquilerTemp = new DatosAlquiler();
            datosAlquilerTemp.Placa = comboBoxPlaca.SelectedValue.ToString();
            clientesTemp.Nombre = textBoxNombre.Text;
            clientesTemp.Direccion = textBoxDireccion.Text;
            datosAlquilerTemp.Nit = Convert.ToInt32(textNit.Text);
            clientesTemp.Nit = Convert.ToInt32(textNit.Text);
            datosAlquilerTemp.FechaAlquiler = dateTimePickerAlquilar.Value;
            datosAlquilerTemp.FechaDevolucion = dateTimePickerDevolucion.Value;
            datosAlquilerTemp.KilometrosRecorridos = float.Parse(textKilometrosRecorridos.Text);
            datosAlquileres.Add(datosAlquilerTemp);
            clientes.Add(clientesTemp);
            GuardarDatosAlquiler();
            GuardarCliente();
            
           
         }

        private void Form2_Load(object sender, EventArgs e)
        {
            datosAlquileres.Clear();
            clientes.Clear();
            datosVehiculos.Clear();
             LeerDatosVehiculo();
            comboBoxPlaca.ValueMember = "Placa";
            comboBoxPlaca.DataSource = null;
            comboBoxPlaca.DataSource = datosVehiculos;
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }

        private void buttonDatos_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();

            frm3.Show();
            
        }
    }
}
