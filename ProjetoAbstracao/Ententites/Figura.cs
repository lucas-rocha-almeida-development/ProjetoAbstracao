using ProjetoAbstracao.Ententites.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAbstracao.Ententites
{
    internal abstract class Figura
    {
        public Color Cores { get; set; }


     
        
        //construtor com argumentos
        public Figura(Color cores)
        {
            Cores = cores;
        }

        //metodo ( não e um metodo comum).
        public abstract double Area(); //operacao abstract
    }

}
