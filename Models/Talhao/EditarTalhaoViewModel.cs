using FarmPlannerAPI.Entities.Enum.FarmPlannerAPI.Entities.Enum;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace FarmPlannerAPICore.Models.Talhao
{
    public class EditarTalhaoViewModel
    {
        public int Id { get; set; }

        [MaxLength(20)]
        public string Descricao { get; set; }

        [Precision(18, 2)]
        public decimal AreaProdutiva { get; set; }

        public TipodeArea TipoArea { get; set; }
        public string? CodigoExterno { get; set; }
        public int IdFazenda { get; set; }
        public int IdAnoAgricola { get; set; }
        public string idconta { get; set; }

        [Precision(18, 2)]
        public decimal? areaDisp { get; set; }

        public string? uid { get; set; }
    }
}