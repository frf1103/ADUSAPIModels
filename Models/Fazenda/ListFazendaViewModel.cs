using FarmPlannerAPI.Entities.Enum.FarmPlannerAPI.Entities.Enum;
using Microsoft.EntityFrameworkCore;
using FarmPlannerAPICore.Models.Enum;

namespace FarmPlannerAPICore.Models.Fazenda
{
    public class ListFazendaViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int IdUF { get; set; }
        public int IdMunicipio { get; set; }
        public int Tipo { get; set; }
        public int TipoArrenda { get; set; }

        [Precision(18, 2)]
        public decimal ValorArrendamento { get; set; }

        public string CodigoExterno { get; set; }
        public int IdRegiao { get; set; }
        public int? IdCultura { get; set; }
        public int IdOrganizacao { get; set; }
        public string desccultura { get; set; }
        public string descregiao { get; set; }
        public string desctipoprop { get; set; }
        public string desctipoarrenda { get; set; }
        public string nomeuf { get; set; }
        public string nomemunicipio { get; set; }
    }
}