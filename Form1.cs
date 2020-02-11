using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cajero2
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
        private void btnretirar_Click(object sender, EventArgs e)
        {
            double[] denominaciones = { 100, 50, 20, 10, 5, 1, 0.5, 0.25, 0.1, 0.05, 0.01 };
            double cantidad = double.Parse(txtcantidad.Text);
            sbyte n = 0;
            string respuesta = "respuesta\n";
            foreach (double denominacion in denominaciones)
            {
                while (denominacion <= Math.Round(cantidad, 2))
                {
                    n++;
                    cantidad -= denominacion;
                }
                if (n > 0)
                {
                    respuesta += n + (denominacion > 1 ? " billetes " : " monedas") + denominacion + "\n";
                }
                n = 0;
            }
                lblrespuesta.Text = respuesta;
        }
        private void btnpagar_Click(object sender, EventArgs e)
        {
            double num1, num2, total;
            double[] denominaciones = { 100, 50, 20, 10, 5, 1, 0.5, 0.25, 0.05, 0.1, 0.01 };
            num1 = double.Parse(txtefectivo.Text);
            num2 = double.Parse(txtpagar.Text);
            sbyte n = 0;
            string cambio = " \n";
            total = num1 - num2;
            foreach (double denominacion in denominaciones) 
            {
                while (denominacion <= Math.Round(total, 2)) 
                {
                    n++;
                    total -= denominacion;
                }
                if (n > 0) 
                {
                    cambio += n + (denominacion > 1 ? " billetes " : " monedas") + denominacion + "\n";
                }
                n = 0;
            }
            //lblcambio.Text = "Su cambio es:" + cambio;
            lblcambio.Text = "Su cambio es: " + (num1-num2) + cambio;

        }

private void btnsecuencia_Click(object sender, EventArgs e)
        {
            
            double a, b, c, d, numero;
            a = 0;
            b = 1;
            lstsecuencia.Items.Add(a);
            lstsecuencia.Items.Add(b);
            numero = Convert.ToInt32(txtsecuencia.Text);
            for(d=3; d <= numero; d++)
            {
                c = a + b;
                lstsecuencia.Items.Add(c);
                a = b;
                b = c;
            }
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            int a = 0, i, x;
            x = int.Parse(txtnumero.Text);
        a = 0;
            for (i = 1; i < (x + 1); i++)
                if (x % i == 0)
                    a++;
            lblnumres.Visible = true;
            lblnumres.Text = ((a != 2) ? x + " No es primo " : x + "  Es primo" + "\n");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtcantidad.Clear();
            txtcantidad.Focus();
            lblrespuesta.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txtpagar.Clear();
            txtpagar.Focus();
            txtefectivo.Clear();
            txtefectivo.Focus();
            lblcambio.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            txtsecuencia.Clear();
            txtsecuencia.Focus();
            lstsecuencia.Items.Clear(); 
        }
        private void button4_Click(object sender, EventArgs e)
        {
            txtnumero.Clear();
            txtnumero.Focus();
            lblnumres.Text = "";
        }
        private void txtnumero_TextChanged(object sender, EventArgs e)
        {
        }
    }
}





















































