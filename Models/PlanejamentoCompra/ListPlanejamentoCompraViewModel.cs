using Microsoft.EntityFrameworkCore;

namespace FarmPlannerAPICore.Models.PlanejamentoCompra
{
    public class ListPlanejamentoCompraViewModel
    {
        public int Id { get; set; }
        public int IdSafra { get; set; }
        public int IdProduto { get; set; }
        [Precision(18, 2)]
        public decimal QtdNecessaria { get; set; }
        [Precision(18, 2)]
        public decimal QtdEstoque { get; set; }
        [Precision(18, 2)]
        public decimal QtdComprar { get; set; }
        [Precision(18, 2)]
        public decimal QtdComprada { get; set; }
        [Precision(18, 2)]
        public decimal Saldo { get; set; }
        public string DescProduto { get; set; }
        public string DescSafra { get; set; }
    }
}
