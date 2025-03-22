using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerEjercicio.MisClases
{
    internal class AutoDeCombustion : Vehiculo

    {
        private int Gasolina;
        public AutoDeCombustion(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            Gasolina = 50;
        }
        public void Gas()
        {
            Gasolina++;
        }
        public int VerNivelGasolina()
        {
            return Gasolina;
        }
        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto);
            Gasolina--;
        }

    }
}
