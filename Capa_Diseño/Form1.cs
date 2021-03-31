using System;
using Capa_logica;
using System.Windows.Forms;

namespace Capa_Diseño
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void funcion()
        {
            //creo proceso para poder llamar las funciones de la capa logica//
            PROCESO Objtraigo = new PROCESO();
            //traigo las variables de la capa logica y las convierto//
            Objtraigo.d1 = Convert.ToDouble(txtD1.Text);
            Objtraigo.d2 = Convert.ToDouble(txtD2.Text);
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            //eventos de boton suma//
            //creo proceso para poder llamar las funciones de la capa logica//
            PROCESO Objtraigo = new PROCESO();
            //traigo las variables de la capa logica y las convierto//
            Objtraigo.d1 = Convert.ToDouble(txtD1.Text);
            Objtraigo.d2 = Convert.ToDouble(txtD2.Text);
            //traigo proceso de suma//
            Objtraigo.prosuma();
            //convierto el resultado a string//
            txtD3.Text = Convert.ToString(Objtraigo.d3);
            //muestro operacion en caja de texto//
            txtOperacion.Text = txtOperacion.Text + "+";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            //eventos de boton resta//
            //creo proceso para poder llamar las funciones de la capa logica//
            PROCESO Objtraigo = new PROCESO();
            //traigo las variables de la capa logica y las convierto//
            Objtraigo.d1 = Convert.ToDouble(txtD1.Text);
            Objtraigo.d2 = Convert.ToDouble(txtD2.Text);
            //traigo proceso de resta//
            Objtraigo.proresta();
            txtD3.Text = Convert.ToString(Objtraigo.d3);
            txtOperacion.Text = txtOperacion.Text + "-";
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            //eventos de boton multiplicacion//
            PROCESO Objtraigo = new PROCESO();
            //traigo las variables de la capa logica y las convierto//
            Objtraigo.d1 = Convert.ToDouble(txtD1.Text);
            Objtraigo.d2 = Convert.ToDouble(txtD2.Text);
            //traigo proceso de multiplicacion//
            Objtraigo.promultiplicacion();
            txtD3.Text = Convert.ToString(Objtraigo.d3);
            txtOperacion.Text = txtOperacion.Text + "*";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            //eventos de boton division//
            //creo proceso para poder llamar las funciones de la capa logica//
            PROCESO Objtraigo = new PROCESO();
            //traigo las variables de la capa logica y las convierto//
            Objtraigo.d1 = Convert.ToDouble(txtD1.Text);
            Objtraigo.d2 = Convert.ToDouble(txtD2.Text);
            //proceso de division, contiene un if, ya que no puede dividir por cero//
            if (Objtraigo.d2 == 0)
            {
                MessageBox.Show("error (no se puede dividir por cero)");
            }
            else
            {
                Objtraigo.prodivision();
                txtD3.Text = Convert.ToString(Objtraigo.d3);
                txtOperacion.Text = txtOperacion.Text + "/";
            }
        }

        //botones de lado izquierdo//


        private void button4_Click(object sender, EventArgs e)
        {
            txtD1.Text = txtD1.Text + "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtD1.Text = txtD1.Text + "1";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtD1.Text = txtD1.Text + "2";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtD1.Text = txtD1.Text + "3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtD1.Text = txtD1.Text + "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtD1.Text = txtD1.Text + "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtD1.Text = txtD1.Text + "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtD1.Text = txtD1.Text + "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtD1.Text = txtD1.Text + "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtD1.Text = txtD1.Text + "9";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtD1.Text = txtD1.Text + ",";
        }


        //botones lado izquierdo//

        private void button19_Click(object sender, EventArgs e)
        {
            txtD2.Text = txtD2.Text + "0";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            txtD2.Text = txtD2.Text + "1";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtD2.Text = txtD2.Text + "2";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtD2.Text = txtD2.Text + "3";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            txtD2.Text = txtD2.Text + "4";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtD2.Text = txtD2.Text + "5";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtD2.Text = txtD2.Text + "6";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            txtD2.Text = txtD2.Text + "7";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtD2.Text = txtD2.Text + "8";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtD2.Text = txtD2.Text + "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtD2.Text = txtD2.Text + ",";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtD1.Clear();
            txtD2.Clear();
            txtD3.Clear();
            txtOperacion.Clear();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            txtD2.Clear();
        }

    }
}
