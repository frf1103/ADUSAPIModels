using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADUSAPICore.Models.Enum;

namespace ADUSAPICore.Models.Assinatura
{
    public class AssinaturaViewModel
    {
        public string id { get; set; }

        public string idparceiro { get; set; }
        public int qtd { get; set; }

        [Precision(18, 2)]
        public double preco { get; set; }

        [Precision(18, 2)]
        public double valor { get; set; }

        public DateTime datavenda { get; set; }
        public FormaPagto idformapagto { get; set; }
        public StatusAssinatura status { get; set; }

        public string? idplataforma { get; set; }

        public string? observacao { get; set; }
    }
}