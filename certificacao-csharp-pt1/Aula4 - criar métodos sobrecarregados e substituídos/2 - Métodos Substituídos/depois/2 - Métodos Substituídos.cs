using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class MetodosSubstituidos : IAulaItem
    {
        public void Executar()
        {
            Animal gato = new Gato() { Nome = "Bichano" };
            gato.Beber();
            gato.Comer();
            gato.Andar();

            Gato gata = new Gato() { Nome = "Penelope" };
            gato.Beber();
            gato.Comer();
            gato.Andar();
        }
    }

    class Animal
    {
        public String Nome { get; set; }

        public void Beber()
        {
            Console.WriteLine("Animal.Beber");
        }

        public virtual void Comer()
        {
            Console.WriteLine("Animal.Comer");
        }

        public virtual void Andar()
        {
            Console.WriteLine("Animal.Andar");
        }
    }

    class Gato : Animal
    {
        public new void Beber()
        {
            Console.WriteLine("Gato.Beber");
        }

        public override void Comer()
        {
            Console.WriteLine("Gato.Comer");
        }

        public override void Andar()
        {
            Console.WriteLine("Gato.Andar");
        }
    }
}