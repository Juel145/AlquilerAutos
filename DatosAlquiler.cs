using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerAutos
{
    class DatosAlquiler
    {
        int nit;
        string placa;
        DateTime fechaAlquiler;
        DateTime fechaDevolucion;
        float kilometrosRecorridos;

        public int Nit { get => nit; set => nit = value; }
        public string Placa { get => placa; set => placa = value; }
        public DateTime FechaAlquiler { get => fechaAlquiler; set => fechaAlquiler = value; }
        public DateTime FechaDevolucion { get => fechaDevolucion; set => fechaDevolucion = value; }
        public float KilometrosRecorridos { get => kilometrosRecorridos; set => kilometrosRecorridos = value; }
    }
}
