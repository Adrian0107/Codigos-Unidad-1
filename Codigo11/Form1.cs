using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automovil
{
    public partial class Form1 : Form
    {
        Auto automovil = new Auto();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            automovil.CostoVehiculo = double.Parse(textBox1.Text);
            textBox1.Clear();
        }
        public double CalcularCosto()
        {
            costo = automovil.CostoVehiculo;
            return (costo+(costo*.12)+(Costo*.06));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"El costo total del Automovil es de: {CalcularCosto()}");
        }
    }
    
}
