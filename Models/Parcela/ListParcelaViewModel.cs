using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADUSAPICore.Models.Enum;

namespace ADUSAPICore.Models.Parcela
{
    public class ListParcelaViewModel
    {
        public string id { get; set; }
        public string idassinatura { get; set; }
        public int numparcela { get; set; }
        public int? idcaixa { get; set; }
        public FormaPagto idformapagto { get; set; }
        public DateTime datavencimento { get; set; }
        public DateTime? databaixa { get; set; }
        public string plataforma { get; set; }

        [Precision(18, 2)]
        public decimal comissao { get; set; }

        [Precision(18, 2)]
        public decimal descontoplataforma { get; set; }

        [Precision(18, 2)]
        public decimal descontoantecipacao { get; set; }

        [Precision(18, 2)]
        public decimal valorliquido { get; set; }

        [Precision(18, 2)]
        public decimal valor { get; set; }

        public string? idcheckout { get; set; }

        public string? nossonumero { get; set; }

        public decimal acrescimos { get; set; }
        public decimal descontos { get; set; }
        public string? observacao { get; set; }
        public string nomeparceiro { get; set; }

        public string descforma { get; set; }
        public string status { get; set; }
        public DateTime? dataestimadapagto { get; set; }
        public string? cctoken { get; set; }
        public string? idafiliado { get; set; }
        public string? registro { get; set; }
        public string? billingType { get; set; }
        public int? QuantidadeArvores { get; set; }
    }
}