using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Salario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
           double hora, valorhora, desconto, bruto, liquido, resdesconto;

           hora = double.Parse(textBox1.Text);
           valorhora = double.Parse(textBox2.Text);
           desconto = double.Parse(textBox3.Text);
            
            bruto = hora*valorhora;
            liquido =

            label10.Text = bruto;


        }
    }
}
