using Microsoft.EntityFrameworkCore;

namespace FarmPlannerAPICore.Models.Maquinas
{
    public class ListModeloParametroViewModel
    {
        public int Id { get; set; }
        public int IdModeloMaquina { get; set; }
        public int IdCultura { get; set; }
        public int IdOperacao { get; set; }
        [Precision(18, 2)]
        public decimal Rendimento { get; set; }
        [Precision(18, 2)]
        public decimal Consumo { get; set; }

        public string DescModelo { get; set; }
        public string DescCultura { get; set; }
        public string DescOperacao { get; set; }
    }
}
