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
        public double comissao { get; set; }

        [Precision(18, 2)]
        public double descontoplataforma { get; set; }

        [Precision(18, 2)]
        public double descontoantecipacao { get; set; }

        [Precision(18, 2)]
        public double valorliquido { get; set; }

        [Precision(18, 2)]
        public double valor { get; set; }

        public string? idcheckout { get; set; }

        public string? nossonumero { get; set; }

        public double acrescimos { get; set; }
        public double descontos { get; set; }
        public string? observacao { get; set; }
        public string nomeparceiro { get; set; }

        public string descforma { get; set; }
    }
}