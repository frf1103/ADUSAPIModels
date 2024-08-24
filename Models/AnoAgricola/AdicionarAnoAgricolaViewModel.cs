namespace FarmPlannerAPICore.Models.AnoAgricola
{
    public class AdicionarAnoAgricolaViewModel
    {
        public int Id { get; set; }
        public string? Descricao { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public string? CodigoExterno { get; set; }
        public int? IdOrganizacao { get; set; }
        public string? idconta { get; set; }

        public string? descorganizacao { get; set; }
    }
}