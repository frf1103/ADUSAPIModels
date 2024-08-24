namespace FarmPlannerAPICore.Models.Safra
{
    public class SafraViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string? CodigoExterno { get; set; }
        public bool Abertura { get; set; }
        public bool Reforma { get; set; }
        public int? IdCultura { get; set; } = null;
        public int IdAnoAgricola { get; set; }
        public string idconta { get; set; }
    }
}