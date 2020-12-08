using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Area_de_las_figuras
{
    public class Areas
    {

        //Cuadrado
        public decimal cuadrado(decimal lado)
        { return lado * lado; }
        //Triangulo
        public decimal triangulo(decimal b, decimal h)
        { return (b * h)/2; }
        //Rombo
        public decimal rombo(decimal D, decimal d)
        { return (D * d); }
        //Recangulo
        public decimal rectangulo(decimal b, decimal h)
        { return (b * h); }
        //Trapecio
        public decimal trapecio(decimal B, decimal b, decimal h)
        { return h*(B + b)/ 2; }
        //Circulo
        public decimal circulo( decimal r, decimal value)
        { return (decimal)(Math.PI*Math.Pow((double) r, 2)); }
        //Romboide
        public decimal romboide(decimal b, decimal h)
        { return (b * h); }
        //Poligono
        public decimal poligono(decimal p, decimal a)
        { return (p * a) / 2; }
    }
}
