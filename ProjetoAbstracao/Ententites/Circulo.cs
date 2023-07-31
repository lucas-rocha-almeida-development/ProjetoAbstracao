using ProjetoAbstracao.Ententites.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAbstracao.Ententites
{
    internal class Circulo : Figura
    {
        public double Radius { get; set; }

        public Circulo(double radius,Color color) :base(color)
        {
            Radius = radius;
        }
        public override double Area()
        {
           return Math.PI* Radius * Radius;
        }
    }
}
