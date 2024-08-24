namespace FarmPlannerAPICore.Models
{
    public class PreferUsuViewModel
    {
        public string uid { get; set; }
        public int idorganizacao { get; set; }
        public int idanoagricola { get; set; }

        public string? descorg { get; set; } = null;
        public string? descano { get; set; } = null;
        public string idconta { get; set; }
    }
}