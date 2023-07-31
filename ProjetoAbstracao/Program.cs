using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoAbstracao.Ententites;
using ProjetoAbstracao.Ententites.Enums;

namespace ProjetoAbstracao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Figura> list = new List<Figura>();//lista do tipo generico
            Console.Write("Entre com a quantidade de Figuras: ");
            int N = int.Parse(Console.ReadLine());

            //criar for para percorrer a lista e prenchimento
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Figura # {i} dados : ");
                Console.Write("Figura seria Retangulo ou Circulo: (R/C): ? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("( Black/Blue/Red ) :");
                //Não e mais aceito Color cor = Enum.Parse<Color>(Console.ReadLine());
                Color cor =(Color) Enum.Parse(typeof(Color), Console.ReadLine());

                //vamos realizar um if e else para diferenciar retangulo e triangulo
                if(ch == 'r')//retangulo
                {
                    Console.Write("Digite Largura: ");
                    double Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Digite Altura: ");
                    double Altura = double.Parse((Console.ReadLine()),CultureInfo.InvariantCulture);
                    //podemos adicionar um novo retangulo<List> com os valores digitados acima (largura e altura)
                    list.Add(new Retangulo(Altura, Largura,cor));
                }
                else//Circulo
                {
                    Console.Write("Digite Circunferência(Raio) : ");
                    double Raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new Circulo(Raio,cor));

                }
               
              

            }
            Console.WriteLine();
            Console.WriteLine("Area da figura:");
            foreach (Figura figura in list)
            {
                Console.WriteLine(figura.Area().ToString("F2", CultureInfo.InvariantCulture));

            }
        }
    }
}
