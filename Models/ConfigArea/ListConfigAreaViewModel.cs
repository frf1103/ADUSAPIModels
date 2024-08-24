using Microsoft.EntityFrameworkCore;

namespace FarmPlannerAPICore.Models.ConfigArea
{
    public class ListConfigAreaViewModel
    {
        public int Id { get; set; }
        public int IdSafra { get; set; }
        public int IdTalhao { get; set; }
        public int IdVariedade { get; set; }

        [Precision(18, 2)]
        public decimal Area { get; set; }

        public string desctalhao { get; set; }
        public string descvariedade { get; set; }
        public string descsafra { get; set; }
        public string descfazenda { get; set; }

        public int? PopulacaoRecomendada { get; set; }

        [Precision(6, 2)]
        public decimal? Germinacao { get; set; }

        public decimal? PMS { get; set; }
        public decimal? Espacamento { get; set; }

        [Precision(6, 2)]
        public decimal? MargemSeguranca { get; set; }

        public decimal? Stand { get; set; }
        public decimal? UnidadeSementePrevista { get; set; }
        public decimal? QtdSementePrevista { get; set; }
        public decimal? ProdEstimada { get; set; }
        public string? descconfig { get; set; }
    }
}