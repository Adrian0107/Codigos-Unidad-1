using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class Form1 : Form
    {
        Restaurante mesa1 = new Restaurante();
        Restaurante mesa2 = new Restaurante();
        Restaurante mesa3 = new Restaurante();
        Restaurante mesa4 = new Restaurante();
        Restaurante mesa5 = new Restaurante();


        public Form1()
        {
            InitializeComponent();
        }

         void button1_Click(object sender, EventArgs e)
        {
            
                if (radioButton1.Checked == true) 
            { 
                    mesa1.CantidadUno = int.Parse(textBox1.Text);
                textBox1.Clear();

                mesa1.CantidadDos = int.Parse(textBox2.Text);
                textBox2.Clear();

                mesa1.CantidadTres = int.Parse(textBox3.Text);
                textBox3.Clear();

                mesa1.CantidadCuatro = int.Parse(textBox4.Text);
                textBox4.Clear();

                mesa1.CantidadCinco = int.Parse(textBox5.Text);
                textBox5.Clear();

                mesa1.CantidadSeis = int.Parse(textBox6.Text);
                textBox6.Clear();
            }
            

                if (radioButton2.Checked == true)
            { 
                    mesa2.CantidadUno = int.Parse(textBox1.Text);
                textBox1.Clear();

                mesa2.CantidadDos = int.Parse(textBox2.Text);
                textBox2.Clear();

                mesa2.CantidadTres = int.Parse(textBox3.Text);
                textBox3.Clear();

                mesa2.CantidadCuatro = int.Parse(textBox4.Text);
                textBox4.Clear();

                mesa2.CantidadCinco = int.Parse(textBox5.Text);
                textBox5.Clear();

                mesa2.CantidadSeis = int.Parse(textBox6.Text);
                textBox6.Clear();
            }
           

                if (radioButton3.Checked == true)
            { 
                    mesa3.CantidadUno = int.Parse(textBox1.Text);
                textBox1.Clear();

                mesa3.CantidadDos = int.Parse(textBox2.Text);
                textBox2.Clear();

                mesa3.CantidadTres = int.Parse(textBox3.Text);
                textBox3.Clear();

                mesa3.CantidadCuatro = int.Parse(textBox4.Text);
                textBox4.Clear();

                mesa3.CantidadCinco = int.Parse(textBox5.Text);
                textBox5.Clear();

                mesa3.CantidadSeis = int.Parse(textBox6.Text);
                textBox6.Clear();
            }
            

                if (radioButton4.Checked == true)
                {
                    mesa4.CantidadUno = int.Parse(textBox1.Text);
                    textBox1.Clear();

                    mesa4.CantidadDos = int.Parse(textBox2.Text);
                    textBox2.Clear();

                    mesa4.CantidadTres = int.Parse(textBox3.Text);
                    textBox3.Clear();

                    mesa4.CantidadCuatro = int.Parse(textBox4.Text);
                    textBox4.Clear();

                    mesa4.CantidadCinco = int.Parse(textBox5.Text);
                    textBox5.Clear();

                    mesa4.CantidadSeis = int.Parse(textBox6.Text);
                    textBox6.Clear();
                }

                if (radioButton5.Checked == true)
                {
                    mesa5.CantidadUno = int.Parse(textBox1.Text);
                    textBox1.Clear();

                    mesa5.CantidadDos = int.Parse(textBox2.Text);
                    textBox2.Clear();

                    mesa5.CantidadTres = int.Parse(textBox3.Text);
                    textBox3.Clear();

                    mesa5.CantidadCuatro = int.Parse(textBox4.Text);
                    textBox4.Clear();

                    mesa5.CantidadCinco = int.Parse(textBox5.Text);
                    textBox5.Clear();

                    mesa5.CantidadSeis = int.Parse(textBox6.Text);
                    textBox6.Clear();
                }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        public int CalcularCuentaUno()
        {
            int Cantidad1;
            Cantidad1 = (mesa1.CantidadUno*15) + (mesa1.CantidadDos*18) + (mesa1.CantidadTres*20) + (mesa1.CantidadCuatro*8) + (mesa1.CantidadCinco*5) + (mesa1.CantidadSeis*6);
            return (Cantidad1) ;
        }
        public int CalcularCuentaDos()
        {
            int Cantidad2;
            Cantidad2 = (mesa2.CantidadUno * 15) + (mesa2.CantidadDos * 18) + (mesa2.CantidadTres * 20) + (mesa2.CantidadCuatro * 8) + (mesa2.CantidadCinco * 5) + (mesa2.CantidadSeis * 6);
            return (Cantidad2);
         }
        public int CalcularCuentaTres()
        {
            int Cantidad3;
            Cantidad3 = (mesa3.CantidadUno * 15) + (mesa3.CantidadDos * 18) + (mesa3.CantidadTres * 20) + (mesa3.CantidadCuatro * 8) + (mesa3.CantidadCinco * 5) + (mesa3.CantidadSeis * 6);
            return (Cantidad3);
        }
        public int CalcularCuentaCuatro()
        {
            int Cantidad4;
            Cantidad4 = (mesa4.CantidadUno * 15) + (mesa4.CantidadDos * 18) + (mesa4.CantidadTres * 20) + (mesa4.CantidadCuatro * 8) + (mesa4.CantidadCinco * 5) + (mesa4.CantidadSeis * 6);
            return (Cantidad4);
        }
        public int CalcularCuentaCinco()
        {
            int Cantidad5;
            Cantidad5 = (mesa5.CantidadUno * 15) + (mesa5.CantidadDos * 18) + (mesa5.CantidadTres * 20) + (mesa5.CantidadCuatro * 8) + (mesa5.CantidadCinco * 5) + (mesa5.CantidadSeis * 6);
            return (Cantidad5);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"La cuenta de la mesa uno es de: {CalcularCuentaUno()}");
            MessageBox.Show($"La cuenta de la mesa dos es de: {CalcularCuentaDos()}");
            MessageBox.Show($"La cuenta de la mesa tres es de: {CalcularCuentaTres()}");
            MessageBox.Show($"La cuenta de la mesa cuatro es de: {CalcularCuentaCuatro()}");
            MessageBox.Show($"La cuenta de la mesa cinco es de: {CalcularCuentaCinco()}");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
