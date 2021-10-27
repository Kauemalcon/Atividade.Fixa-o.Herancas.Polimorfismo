using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade.Fixação.Heranças.Polimorfismo.Entitis
{
    class Produto_Importado : Produto
    {
        public double TaxaAlfandega { get; set; }

        public Produto_Importado()
        {

        }
        public Produto_Importado(double taxaAlfandega, string nome, double preco) : base (nome, preco)
        {
            TaxaAlfandega = taxaAlfandega;
        }

        public double PrecoTotal()
        {
            return Preco + TaxaAlfandega;
        }

        public override string PrecoEtiqueta()
        {
            return Nome
                + " $ "
                + PrecoTotal().ToString("F2", CultureInfo.InvariantCulture)
                + " (Taxa Alfandega: $ "
                + TaxaAlfandega.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }

       
    }
}
