using Microsoft.EntityFrameworkCore;

namespace ADUSAPICore.Models.Moeda
{
    public class CotacaoMoedaViewModel
    {
        public int Id { get; set; }
        public int IdMoeda { get; set; }
        public DateTime CotacaoData { get; set; }

        [Precision(18, 4)]
        public decimal CotacaoValor { get; set; }

        public string? descmoeda { get; set; }
    }
}