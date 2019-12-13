using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class ParametrosNomeados : IAulaItem
    {
        public void Executar()
        {
            ImprimirDetalhesDoPedido("Geraldin", 132, "Torradeira");
            ImprimirDetalhesDoPedido(numeroPedido: 31, nomeProduto:"Caneta Azul",vendedor: "Dona Creusa");

            ImprimirDetalhesDoPedido("Maria d Fátima", 31, nomeProduto:"Caneca Vermelha");


        }

        void ImprimirDetalhesDoPedido(string vendedor, int numeroPedido, string nomeProduto)
        {
            if (string.IsNullOrWhiteSpace(vendedor))
            {
                throw new ArgumentException(message: "Nome de vendedor não pode ser nulo ou vazio.", paramName: nameof(vendedor));
            }

            Console.WriteLine($"Vendedor: {vendedor}, Pedido No.: {numeroPedido}, Produto: {nomeProduto}");
        }
    }
}
