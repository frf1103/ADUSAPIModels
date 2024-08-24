using FarmPlannerAPI.Entities.Enum.FarmPlannerAPI.Entities.Enum;

namespace FarmPlannerAPICore.Models.Parceiro
{
    public class ParceiroViewModel
    {
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string Fantasia { get; set; }
        public TipodePessoa TipodePessoa { get; set; }
        public string Registro { get; set; }
        public string idconta { get; set; }
    }
}