using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7 {
    internal class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) {
            Quantidade = Quantidade + quantidade;
        }




        public override string ToString() {
            return Nome + ", $ " + Preco.ToString("F2") + ", " + Quantidade + "  " "+ unidades, Total: $ " + ValorTotalEmEstoque().ToString("F2");
        }

    }


}
