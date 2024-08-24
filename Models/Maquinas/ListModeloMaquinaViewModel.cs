using FarmPlannerAPI.Entities.Enum;

namespace FarmPlannerAPICore.Models.Maquinas
{
    public class ListModeloMaquinaViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int IdMarca { get; set; }
        public string DescMarca { get; set; }
        public string DescComb { get; set; }
        public int Combustivel { get; set; }

    }
}
