using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace llamada
{
    class Llamada
    {

		private int duracion;

		public int Duracion
		{
			get { return duracion; }
			set { duracion = value; }
		}
		public double CalcularCostoLlamada()
		{
			if (Duracion <= 3)
			{
				return 5;
			}
			else
			{
				return (Duracion -3)*3 + 5;
			}
		}
	}
}
