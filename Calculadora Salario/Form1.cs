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
            resdesconto = (desconto / 100) * bruto;
            liquido = bruto - resdesconto;          
            label10.Text = bruto.ToString();
            label7.Text = Math.Round(liquido, 2).ToString();
            label9.Text = Math.Round(resdesconto, 2).ToString();



            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label10.Text = "";
            label7.Text = "";
            label9.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
