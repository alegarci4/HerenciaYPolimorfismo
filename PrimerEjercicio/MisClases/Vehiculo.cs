using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerEjercicio.MisClases
{
    internal class Vehiculo
    {
        public string Color { get; set; }
        public string Modelo { get; }
        public int Year { get; }

        private int velocidad = 0;


        //Constructor
        public Vehiculo(int anio, string elColor, string elModelo)
        {
            this.Color = elColor;
            this.Modelo = elModelo;
            this.Year = anio;
        }

        public void informacionVehiculo()
        {
            Console.WriteLine("Color: {0}", this.Color);
            Console.WriteLine("Modelo: {0}", this.Modelo);
            Console.WriteLine("Año: {0}", this.Year);
        }
        public virtual void acelerar(int cuanto)
        {
            velocidad += cuanto;
            Console.WriteLine("vas a {0} KMS / Hora", velocidad);
            
        }
        public void frenar(int cuanto)
        {
            velocidad = velocidad -= cuanto;
          
            Console.WriteLine("Has frenado,las luces traceras están encendidas. Ahora vas a: {0} kms/h",velocidad);
        }

        public void encender ()
        {
            Console.WriteLine("Estoy encendido, a dónde iremos ahora?");
        }

        public void apagar()
        {
            Console.WriteLine("Me apagaste, hasta la próxima <3");
        }
    }
}
