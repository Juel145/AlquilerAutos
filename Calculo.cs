using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerAutos
{
    class Calculo
    {
        string nombreCliente;
        string placa;
        string marca;
        int modelo;
        string color;
        DateTime fechadevolucion;
        float total;

        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Marca { get => marca; set => marca = value; }
        public int Modelo { get => modelo; set => modelo = value; }
        public string Color { get => color; set => color = value; }
        public DateTime Fechadevolucion { get => fechadevolucion; set => fechadevolucion = value; }
        public float Total { get => total; set => total = value; }
    }
}
