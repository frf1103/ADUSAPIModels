using Microsoft.EntityFrameworkCore;

namespace FarmPlannerAPICore.Models.ProdutoPlanejado
{
    public class ProdutoPlanejadoViewModel
    {
        public int Id { get; set; }
        public int IdConfigArea { get; set; }

        [Precision(18, 2)]
        public decimal Tamanho { get; set; }

        [Precision(6, 2)]
        public decimal AreaPercent { get; set; }

        public int IdPlanejamento { get; set; }
        public int? IdPrincipioAtivo { get; set; }
        public int? IdProduto { get; set; }

        [Precision(18, 2)]
        public decimal Dosagem { get; set; }

        [Precision(18, 2)]
        public decimal TotalProduto { get; set; }

        public string idconta { get; set; }
    }
}