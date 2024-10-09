using Microsoft.EntityFrameworkCore;

namespace FarmPlannerAPICore.Models.ProdutoPlanejado
{
    public class ListProdutoPlanejadoViewModel
    {
        public int Id { get; set; }
        public int IdConfigArea { get; set; }

        [Precision(18, 2)]
        public decimal Tamanho { get; set; }

        public int IdPlanejamento { get; set; }

        //   public int? IdPrincipioAtivo { get; set; }
        public int? IdProduto { get; set; }

        [Precision(18, 2)]
        public decimal Dosagem { get; set; }

        [Precision(18, 2)]
        public decimal TotalProduto { get; set; }

        public string? descproduto { get; set; }
        public string? descprincativo { get; set; }
        public string? descricao { get; set; }
        public int idcodigo { get; set; }
        public string? idtipo { get; set; }
    }
}