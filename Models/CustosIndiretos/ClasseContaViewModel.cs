using FarmPlannerAPICore.Models.Enum;

namespace FarmPlannerAPICore.Models.CustosIndiretos
{
    public class ClasseContaViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public int TipoClasseConta { get; set; }
    }
}