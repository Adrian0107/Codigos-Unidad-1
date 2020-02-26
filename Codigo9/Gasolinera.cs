using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasolinera
{
    class Gasolinera
    {
        private int Precio;
        public Gasolinera()
        {
            Console.WriteLine("Litro de gasolina: 15$ ");
            Precio = 15;
        }
        private double galones; 

        public double Galones 
        {
            get { return galones; }
            set { galones = value; }
        }
        public double PrecioEnGalones()
        {
            return (Galones * 3.785)*Precio;
        }


    }
}
