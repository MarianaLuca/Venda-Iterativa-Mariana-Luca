﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using UMFG.Venda.Aprensetacao.Classes;

namespace UMFG.Venda.Aprensetacao.Models
{

   internal sealed class ProdutoModel : AbstractModel
    {

        private ImageSource _imagem;
        private string _ref;
        private string _descricao;
        private decimal _preco;

        public ImageSource Imagem
        {
            get => _imagem;
            set => SetField(ref _imagem, value);
        }

        public string Ref 
        {
            get => _ref;
            set => SetField(ref _ref, value);
        }

        public string Descricao
        {
            get => _descricao;
            set => SetField(ref _descricao, value);
        }

        public decimal Preco
        {
            get => _preco;
            set => SetField(ref _preco, value);
        }

    }
}
