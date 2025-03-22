using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerEjercicio.MisClases
{
    internal class Camion : Vehiculo
    {
        private string tipoCamion = "Carga";

        public Camion(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
        }

        public void tipo()
        {
            Console.WriteLine("Este camión es de tipo {0}", tipoCamion);
        }

        public int verCapacidad()
        {
            return 15;
        }
        public int cargaActual(int cuanto)
        {
            Console.WriteLine("La carga actual es de {0} toneladas", cuanto);
            return cuanto;

        }
        public void capacidadCarga()
        {
            Console.WriteLine("Este camión volvió a tener una capacidad de 15 toneladas");
        }
        public void descargar()
        {

            Console.WriteLine("Se ha descargado la carga");
        }
        public void acelerarcamion(int cuanto)
        {
            base.acelerar(cuanto / 2);
            //El camión con carga va más lento.
        }
    }
}
