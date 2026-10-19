using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projTriangulos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            byte x;
            InitializeComponent();
        }

        private void click_classificar(object sender, EventArgs e)
        {
            Triangulo triangulo = new Triangulo(int.Parse(txtLado1.Text),
                                                int.Parse(txtLado2.Text),
                                                int.Parse(txtLado3.Text));
            triangulo.classificar();

            lblClassificacao.Text = triangulo.getClassificacao().ToString();

            if (triangulo.getClassificacao() == 0)
            {
                txtClassificacao.Text = "NÃO FORMA TRIÂNGULO";
                radNFT.Checked = true;
                picClassificacao.Image = projTriangulos.Properties.Resources.nft;
            }
            else
            {
                if (triangulo.getClassificacao() == 1)
                {
                    txtClassificacao.Text = "TRIÂNGULO EQUILÁTERO";
                    radEQ.Checked = true;
                    picClassificacao.Image = projTriangulos.Properties.Resources.equilatero;
                }
                else
                {
                    if (triangulo.getClassificacao() == 2)
                    {
                        txtClassificacao.Text = "TRIÂNGULO ISÓSCELES";
                        radIS.Checked = true;
                        picClassificacao.Image = projTriangulos.Properties.Resources.isosceles;
                    }
                    else
                    {
                        txtClassificacao.Text = "TRIÂNGULO ESCALENO";
                        radES.Checked= true;
                        picClassificacao.Image = projTriangulos.Properties.Resources.escaleno;
                    }
                }
            }
        }
    }
}
