namespace FarmPlannerAPICore.Models.Conta
{
    public class AssinaturaContaViewModel
    {
        public int id { get; set; }
        public string idconta { get; set; }
        public int plano { get; set; }
        public DateTime dataassinatura { get; set; }
        public DateTime dataexpiracao { get; set; }
    }
}