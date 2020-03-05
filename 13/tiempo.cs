using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundos
{
    class tiempo
    {
		private int dias;

		public int Dias
		{
			get { return dias; }
			set { dias = value; }
		}
		private int segundos;

		public int Segundos
		{
			get { return segundos; }
			set { segundos = value; }
		}

		public int CalcularSegundos()
		{
			return Dias * 86400;
		}


	}
}
