using Microsoft.EntityFrameworkCore;

namespace FarmPlannerAPICore.Models.MaquinaPlanejada
{
    public class MaquinaPlanejadaViewModel
    {
        public string idconta { get; set; }
        public int Id { get; set; }
        public int IdPlanejamento { get; set; }
        public int IdModeloMaquina { get; set; }
        public int IdMaquina { get; set; }

        [Precision(18, 2)]
        public decimal Rendimento { get; set; }

        [Precision(18, 2)]
        public decimal Consumo { get; set; }

        [Precision(18, 2)]
        public decimal QtdHoraEstimada { get; set; }

        [Precision(18, 2)]
        public decimal QtdCombEstimado { get; set; }
    }
}