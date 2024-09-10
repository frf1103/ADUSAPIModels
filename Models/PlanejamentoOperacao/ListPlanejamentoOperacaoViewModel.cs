using FarmPlannerAPICore.Models.Enum;
using Microsoft.EntityFrameworkCore;

namespace FarmPlannerAPICore.Models.PlanejamentoOperacao
{
    public class ListPlanejamentoOperacaoViewModel
    {
        public int Id { get; set; }
        public int IdConfigArea { get; set; }
        public DateTime DataPrevista { get; set; }
        public int IdOperacao { get; set; }

        public bool Plantio { get; set; }
        public int DAE { get; set; }

        //    public int IdOrcamento { get; set; }
        [Precision(18, 2)]
        public decimal Area { get; set; }

        [Precision(18, 2)]
        public decimal QHorasEstimadas { get; set; }

        [Precision(18, 2)]
        public decimal QCombustivelEstimado { get; set; }

        [Precision(18, 2)]
        public int Status { get; set; }

        public decimal CustoOperacao { get; set; }

        public string Descoperacao { get; set; }

        //     public string DescOrcamento { get; set; }
        public string Desctalhao { get; set; }

        public string descvariedade { get; set; }
        public string DescSafra { get; set; }
        public string descconfig { get; set; }
        public decimal? Percentual { get; set; }
    }
}