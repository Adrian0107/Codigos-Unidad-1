using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace llamada
{
    public partial class Form1 : Form
    {
        Llamada telefono = new Llamada();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           telefono.Duracion = int.Parse(textBox1.Text);
           textBox1.Clear();
            if (telefono.Duracion >= 0)
            {
                MessageBox.Show($"El costo de la llamada es: {telefono.CalcularCostoLlamada()}");
            }
            else
            {
                MessageBox.Show("Introducir un numero entero positivo");
            }
        }
    }
}
