using System;
using System.Collections.Generic;
using System.Globalization;

namespace Atividade.Fixação.Heranças.Polimorfismo.Entitis
{
    class Produto_Usado : Produto
    {
        public DateTime DataFabricacao { get; set; }

        public Produto_Usado()
        {

        }
        public Produto_Usado(DateTime dataFabricacao, string nome, double preco) : base (nome, preco)
        {
            DataFabricacao = dataFabricacao;
        }
        public override string PrecoEtiqueta()
        {
            return Nome
                + "(Usado) $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + " (Data Fabricação:  "
                + DataFabricacao.ToString("dd/MM/yyyy")
                + ")";
        }
    }
}
