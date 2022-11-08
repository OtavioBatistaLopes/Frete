using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreteDominato
{
    public partial class Form1 : Form
    {
        float kmRodado = 0;
        float kmAutonimia = 0;
        float QuantidadeCombustivel = 0;
        double valorCombustivel = 0;
        double custoCombustivel;
        double valorTotal;
        double custoKm;
        public Form1()
        {
            InitializeComponent();
        }

        private void boxTabela_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (boxTabela.Text == "Carro")
            {
                imgVeiculo.Image = FreteDominato.Properties.Resources.Saveiro;
            }
            else
            {
                imgVeiculo.Image = Properties.Resources.caminhão;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            kmRodado = float.Parse(txtDistancia.Text);

            float kmDobrado = 0;

            if (checkBox1.Checked == false)
            {
                kmDobrado = kmRodado * 1; // ida
            }
            else
            {
                kmDobrado = kmRodado * 2; // volta
            }
            //consumo combustivel
            QuantidadeCombustivel =kmDobrado / float.Parse(txtAutonomia.Text);
            txtConsumo.Text = QuantidadeCombustivel.ToString("N0") + " Litros";

            //custo combustivel
            custoCombustivel = double.Parse(txtCustoPL.Text) * QuantidadeCombustivel;

            txtDespesa.Text = custoCombustivel.ToString("N2");

            //Valor Frete
            valorTotal = custoCombustivel * 3;
            txtTotal.Text = valorTotal.ToString("N2");

            //KM Rodados
            txtkms.Text = kmDobrado.ToString();

            //Custo por km
            custoKm = double.Parse(txtCustoPL.Text) / double.Parse(txtAutonomia.Text);
            txtCusto.Text = custoKm.ToString("N2");

        }

        
    }
}





