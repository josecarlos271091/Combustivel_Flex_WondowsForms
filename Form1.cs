using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using br.ucb.framework.Util;

namespace desafioCombustivel
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var _gasolina = double.Parse(textBox1.Text);
                var _alcool = double.Parse(textBox2.Text);
                Combustivel comb = new Combustivel();
                comb.calcularGasolinaEAlcool(_gasolina); //Nao estou usando, so testando referencia framework


                if (_alcool / _gasolina < 0.7)
                    label4.Text = "ABASTECA COM ALCOOL";
                else
                    label4.Text = "ABASTECA COM GASOLINA";

            }
            catch { MessageBox.Show("Dados Invalidos, Informe Numeros!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error); }


           }
    }
}
