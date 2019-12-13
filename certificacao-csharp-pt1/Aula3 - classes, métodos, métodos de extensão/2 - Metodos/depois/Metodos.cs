using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Metodos : IAulaItem
    {
        public void Executar()
        {
            Retangulo retangulo = new Retangulo(12, 10);

            Retangulo vRetangulo = new Retangulo(10,10);
            Console.WriteLine(retangulo.Semelhante(retangulo.Largura, vRetangulo.Largura));

            vRetangulo = new Retangulo(5, 6);
            Console.WriteLine(Retangulo.Semelhante(retangulo, vRetangulo));
        }
    }

    class Retangulo
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public Retangulo(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;

            Console.WriteLine($"altura: {altura}, largura: {largura}");
        }

        public double GetArea()
        {
            return Altura * Largura;
        }

        internal static bool Semelhante(Retangulo pRetangulo, Retangulo pOutroRetangulo)
        {
            return
                ((pRetangulo.Largura / pRetangulo.Altura) == /*proporção deste retângulo*/
                (pOutroRetangulo.Largura / pOutroRetangulo.Largura)) /*proporção do outro retângulo*/
                ||
                ((pRetangulo.Altura / pRetangulo.Largura) == /*compara a proporção inversa*/
                (pOutroRetangulo.Altura / pOutroRetangulo.Altura));
        }

        internal bool Semelhante(double outroRetanguloAltura, double outroRetanguloLargura)
        {
            return
                ((Largura / Altura) == /*proporção deste retângulo*/
                (outroRetanguloLargura / outroRetanguloAltura)) /*proporção do outro retângulo*/
                ||
                ((Altura / Largura) == /*compara a proporção inversa*/
                (outroRetanguloLargura / outroRetanguloAltura));
        }
    }
}
