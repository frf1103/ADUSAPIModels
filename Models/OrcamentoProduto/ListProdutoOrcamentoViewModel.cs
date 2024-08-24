using FarmPlannerAPICore.Models.Enum;
using Microsoft.EntityFrameworkCore;

namespace FarmPlannerAPICore.Models.OrcamentoProduto
{
    public class ListProdutoOrcamentoViewModel
    {
        public int Id { get; set; }
        public int IdOrcamento { get; set; }
        public int TipoProdutoOrc { get; set; }
        public int? IdPrincipioAtivo { get; set; }
        public int IdProduto { get; set; }

        [Precision(18, 4)]
        public decimal PrecoUnitario { get; set; }

        public DateTime? DataPreco { get; set; }
        public string descproduto { get; set; }
        public string descpricativo { get; set; }
        public string desctipoproduto { get; set; }
    }
}