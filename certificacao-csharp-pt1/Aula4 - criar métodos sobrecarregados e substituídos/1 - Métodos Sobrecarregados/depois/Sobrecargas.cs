using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Sobrecargas : IAulaItem
    {
        public void Executar()
        {
            //VOLUME DO CUBO = lado ^ 3;
            int lado = 3;
            Console.WriteLine($"Volume do Cubo: {Volume(lado)}");

            //VOLUME DO CILINDRO = altura * PI * raio ^ 2;
            double raio = 2;
            int altura = 10;
            Console.WriteLine($"Volume do cilindro: {Volume(altura, raio)}");

            //VOLUME DO PRISMA = largura * profundidade * altura
            long largura = 10;
            altura = 6;
            int profundidade = 4;
            Console.WriteLine($"Volume prisma: {Volume(largura, profundidade, altura)}");
        }
        double Volume(double pLado)
        {
            return Math.Pow(pLado, 3);
        }
        double Volume(double pAltura, double pRaio)
        {
            return pAltura * Math.PI * Math.Pow(pRaio, 2);
        }
        double Volume(double pLargura, double pProfundidade, double pAltura)
        {
            return pLargura * pProfundidade * pAltura;
        }
    }
}
