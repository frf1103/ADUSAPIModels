using Microsoft.EntityFrameworkCore;

namespace FarmPlannerAPICore.Models.PlanejamentoCompra
{
    public class ListPlanejamentoCompraViewModel
    {
        public int Id { get; set; }
        public int IdSafra { get; set; }

        public int IdFazenda { get; set; }
        public int idproduto { get; set; }

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

        public string DescPrincipio { get; set; }
        public string DescSafra { get; set; }
        public string DescFazenda { get; set; }
    }
}