using FarmPlannerAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace FarmPlannerAPICore.Models.CustosIndiretos
{
    public class OrcamentoCustoIndiretoViewModel
    {
        public int Id { get; set; }
        public int IdSafra { get; set; }
        public DateTime Data { get; set; }
        public int idcontaCad { get; set; }

        [Precision(18, 2)]
        public decimal valor { get; set; }

        public string idconta { get; set; }
    }
}