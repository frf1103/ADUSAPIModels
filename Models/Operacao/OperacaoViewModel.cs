using Microsoft.EntityFrameworkCore;

namespace FarmPlannerAPICore.Models.Operacao
{
    public class OperacaoViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int IdTipoOperacao { get; set; }
        public bool Insumo { get; set; }
        public string? CodigoExterno { get; set; }

        [Precision(18, 2)]
        public decimal? Rendimento { get; set; }

        [Precision(18, 2)]
        public decimal? Consumo { get; set; }

        public string idconta { get; set; }
        public bool? plantio { get; set; }
    }
}