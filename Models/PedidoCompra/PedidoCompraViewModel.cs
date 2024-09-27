using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPlannerAPICore.Models.PedidoCompra
{
    public class PedidoCompraViewModel
    {
        public int id { get; set; }

        public int idsafra { get; set; }
        public int idfazenda { get; set; }
        public int idfornecedor { get; set; }
        public int idmoeda { get; set; }
        public DateTime vencimento { get; set; }
        public string? pedidofonecedor { get; set; }

        public decimal total { get; set; }

        public DateTime datapedido { get; set; }

        public string? observacao { get; set; }

        public string idconta { get; set; }
        public string uid { get; set; }
        public DateTime datains { get; set; }
        public DateTime? dataup { get; set; }

        public string? descfazenda { get; set; }
        public string? descmoeda { get; set; }
        public string? descsafra { get; set; }
        public string? descfornec { get; set; }
    }
}