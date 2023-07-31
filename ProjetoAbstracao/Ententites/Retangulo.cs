using ProjetoAbstracao.Ententites.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjetoAbstracao.Ententites
{
    //metodo abstrato automaticamente tem o "override"//dispensando o virtual
    internal class Retangulo : Figura
    {
        //2 atributos.
        public double Width { get; set; }//largura
        public double Height { get; set; }//altura

        //construtor
        public Retangulo(double width ,double heigth,Color color) : base(color)
        {
            Width = width;//largura 
            Height = heigth;//altura
        }


        //implementação da class area (subscrita do metodo abstrato)
        //pertencente a class Figura
        public override double Area()
        {
           return Width * Height;//calcular area (largura x altura)
        }
    }
}
