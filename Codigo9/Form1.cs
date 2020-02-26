using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gasolinera
{
    public partial class Form1 : Form
    {
        Gasolinera gas = new Gasolinera();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"El precio a cobrar sera de: {gas.PrecioEnGalones()}");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gas.Galones = double.Parse(textBox1.Text);
            textBox1.Clear();
        }
    }
}
