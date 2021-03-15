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
    public partial class Form3 : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        List<DatosVehiculo> datosVehiculos = new List<DatosVehiculo>();
        List<DatosAlquiler> datosAlquileres = new List<DatosAlquiler>();
        List<Calculo> calculos = new List<Calculo>();
        public Form3()
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
        
        private void Form3_Load(object sender, EventArgs e)
        {
            LeerDatosAlquiler();
            LeerDatosVehiculo();
            LeerClientes();
            dataGridViewDatosVehiculos.DataSource = null;
            dataGridViewDatosVehiculos.DataSource = datosVehiculos;
            dataGridViewDatosVehiculos.Refresh();
            
            dataGridViewDatosAlquiler.DataSource = null;
            dataGridViewDatosAlquiler.DataSource = datosAlquileres;
            dataGridViewDatosAlquiler.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < datosVehiculos.Count; x++)
            {
                for (int y = 0; y < datosAlquileres.Count; y++)
                {

                    if (datosVehiculos[x].Placa == datosAlquileres[y].Placa)
                    {

                        Calculo calculoTemp = new Calculo();
                        Cliente cliente = clientes.Find(n => n.Nit == datosAlquileres[y].Nit);
                        calculoTemp.NombreCliente = cliente.Nombre;
                        calculoTemp.Placa = datosVehiculos[x].Placa;
                        calculoTemp.Marca = datosVehiculos[x].Marca;
                        calculoTemp.Modelo = datosVehiculos[x].Modelo;
                        calculoTemp.Color = datosVehiculos[x].Color;
                        calculoTemp.Fechadevolucion = datosAlquileres[y].FechaDevolucion;
                        calculoTemp.Total = datosVehiculos[x].PrecioKilometro * datosAlquileres[y].KilometrosRecorridos;
                        calculos.Add(calculoTemp);

                    }

                }
            }


            dataGridViewReporte.DataSource = null;
            dataGridViewReporte.DataSource = calculos;
            dataGridViewReporte.Refresh();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            float mayor = datosAlquileres.Max(p => p.KilometrosRecorridos);
            labelMayorRecorrido.Text = "El mayor recorrido fue de " + mayor.ToString();
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
