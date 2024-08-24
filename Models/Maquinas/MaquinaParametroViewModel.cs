using Microsoft.EntityFrameworkCore;

namespace FarmPlannerAPICore.Models.Maquinas
{
    public class MaquinaParametroViewModel
    {
        public int Id { get; set; }
        public int IdMaquina { get; set; }
        public int IdCultura { get; set; }
        public int IdOperacao { get; set; }

        [Precision(18, 2)]
        public decimal Rendimento { get; set; }

        [Precision(18, 2)]
        public decimal Consumo { get; set; }

        public string idconta { get; set; }
    }
}