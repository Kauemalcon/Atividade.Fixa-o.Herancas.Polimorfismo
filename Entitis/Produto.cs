﻿using System;
using System.Collections.Generic;
using System.Globalization;

namespace Atividade.Fixação.Heranças.Polimorfismo.Entitis
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public Produto()
        {

        }
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public virtual string PrecoEtiqueta()
        {
            return Nome
                + " $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
