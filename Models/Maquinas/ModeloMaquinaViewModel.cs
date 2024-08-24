using FarmPlannerAPI.Entities.Enum;

namespace FarmPlannerAPICore.Models.Maquinas
{
    public class ModeloMaquinaViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int IdMarca { get; set; }
        public int Combustivel { get; set; }

    }
}
