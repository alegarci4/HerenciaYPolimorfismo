using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerEjercicio.MisClases
{
    internal class Motocicleta : Vehiculo
    {
        private string motor = "4 tiempos";
        public int niveldeAceite = 83;
        public Motocicleta(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
        }
        public string verTiemposdeMotor()
        {
            return motor;
        }
        public void acelerarmoto(int cuanto)
        {
            base.acelerar(cuanto * 2);
            //lo multiplico por 2 para que acelere el doble.
        }
    }
}
