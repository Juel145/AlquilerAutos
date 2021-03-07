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
        void Calcular()
        {
            LeerDatosAlquiler();
            for (int x = 0; x < datosVehiculos.Count; x++)
            {
                for (int y = 0; y < datosAlquileres.Count; y++)
                {
                    for (int z = 0; z < clientes.Count; z++)
                    {
                        if (datosVehiculos[x].Placa == datosAlquileres[y].Placa)
                        {
                            if (datosAlquileres[y].Nit == clientes[z].Nit)
                            {
                                Calculo calculoTemp = new Calculo();
                                calculoTemp.NombreCliente = clientes[z].Nombre;
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
                }
            }
            dataGridViewDatosVehiculo.DataSource = null;
            dataGridViewDatosVehiculo.DataSource = datosVehiculos;
            dataGridViewDatosVehiculo.Refresh();

            dataGridViewDatosalquiler.DataSource = null;
            dataGridViewDatosalquiler.DataSource = datosAlquileres;
            dataGridViewDatosalquiler.Refresh();

            dataGridViewCalculo.DataSource = null;
            dataGridViewCalculo.DataSource = calculos;
            dataGridViewCalculo.Refresh();

        }
        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            LeerClientes();
            LeerDatosVehiculo();
            int NitCliente = Convert.ToInt32(textNit.Text);
            string PlacaVehiculo = textPlaca.Text;
            DateTime FechaAlquiler = sfechaAlquiler.SelectionStart;
            DateTime FechaDevolucion = sfechaDevolucion.SelectionStart;

            DatosAlquiler datosAlquilerTemp = new DatosAlquiler();
            datosAlquilerTemp.Nit = NitCliente;
            datosAlquilerTemp.Placa = PlacaVehiculo;
            datosAlquilerTemp.FechaAlquiler = FechaAlquiler;
            datosAlquilerTemp.FechaDevolucion = FechaDevolucion;
            datosAlquileres.Add(datosAlquilerTemp);
            GuardarDatosAlquiler();
            Calcular();
                
         }
    }
}
