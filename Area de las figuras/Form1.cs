using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area_de_las_figuras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculartriangulo_Click(object sender, EventArgs e)
        {
            
            Areas a = new Areas();
            decimal resultado = a.triangulo(numalturatriangulo.Value, numbasetriangulo.Value );
            lblareatriangulo.Text = resultado + "";
        }

        private void calcularcuadrado_Click(object sender, EventArgs e)
        {
            Areas b = new Areas();
            decimal resultado = b.cuadrado(numlado.Value);
            lblareacuadrado.Text = resultado + "";
        }

        private void calcularrombo_Click(object sender, EventArgs e)
        {
            Areas a = new Areas();
            decimal resultado = a.rombo(numdiagonalmayor.Value, numdiagonalmenor.Value);
            lblcarearombo.Text = resultado + "";
        }

        private void calcularpoligono_Click(object sender, EventArgs e)
        {
            Areas a = new Areas();
            decimal resultado = a.poligono(numperimetro.Value, numapotema.Value);
            lblareapoligono.Text = resultado + "";
        }

        private void calcularrectangulo_Click(object sender, EventArgs e)
        {
            Areas a = new Areas();
            decimal resultado = a.rectangulo(numbsaserectangulo.Value, numalturarectangulo.Value);
            lblarearectangulo.Text = resultado + "";
        }

        private void calcularcirculo_Click(object sender, EventArgs e)
        {
            Areas a = new Areas();
            decimal resultado = a.circulo(numradio.Value, numradio.Value);
            lblareacirculo.Text = resultado + "";
        }

        private void calcularromboide_Click(object sender, EventArgs e)
        {
            Areas a = new Areas();
            decimal resultado = a.romboide(numbaseromboide.Value, numalturaromboide.Value);
            lblarearomboide.Text = resultado + "";
        }

        private void calculartrapecio_Click(object sender, EventArgs e)
        {
            Areas a = new Areas();
            decimal resultado = a.trapecio(numbasemayor.Value, numbasemenor.Value, numalturatrapecio.Value);
            lblareatrapecio.Text = resultado + "";
        }


    }
}
