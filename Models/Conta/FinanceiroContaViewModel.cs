using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace FarmPlannerAPICore.Models.Conta
{
    public class FinanceiroContaViewModel
    {
        public int id { get; set; }
        public string idconta { get; set; }

        public DateTime emissao { get; set; }
        public DateTime vencimento { get; set; }
        public DateTime datapagto { get; set; }

        [Precision(18, 2)]
        public decimal valor { get; set; }

        [Precision(18, 2)]
        public decimal desconto { get; set; }

        [Precision(18, 2)]
        public decimal valorpago { get; set; }

        public int tipo { get; set; }

        [MaxLength(250)]
        public string obs { get; set; }
    }
}