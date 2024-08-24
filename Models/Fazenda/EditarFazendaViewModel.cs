using FarmPlannerAPI.Entities.Enum.FarmPlannerAPI.Entities.Enum;
using FarmPlannerAPI.Entities;
using Microsoft.EntityFrameworkCore;
using FarmPlannerAPICore.Models.Enum;

namespace FarmPlannerAPICore.Models.Fazenda
{
    public class EditarFazendaViewModel
    {
        public string idconta { get; set; }
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int IdUF { get; set; }
        public int IdMunicipio { get; set; }
        public int Tipo { get; set; }
        public int TipoArrenda { get; set; }

        [Precision(18, 2)]
        public decimal ValorArrendamento { get; set; }

        public string? CodigoExterno { get; set; }
        public int IdRegiao { get; set; }
        public int? IdCultura { get; set; }
        public int IdOrganizacao { get; set; }
    }
}