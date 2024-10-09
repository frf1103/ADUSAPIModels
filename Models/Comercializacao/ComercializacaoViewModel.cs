using Microsoft.EntityFrameworkCore;

namespace FarmPlannerAPICore.Models.Comercializacao
{
    public class ComercializacaoViewModel
    {
        public int Id { get; set; }

        public int IdSafra { get; set; }
        public int IdParceiro { get; set; }
        public int IdFazenda { get; set; }
        public decimal Quantidade { get; set; }

        public int IdMoeda { get; set; }
        public bool Trava { get; set; }

        [Precision(18, 2)]
        public decimal CBOT { get; set; }

        public DateTime? DataPedido { get; set; }

        [Precision(18, 2)]
        public decimal? Frete { get; set; }

        [Precision(18, 2)]
        public decimal Cambio { get; set; }

        [Precision(18, 2)]
        public decimal Premio { get; set; }

        [Precision(18, 2)]
        public decimal ValorUnitario { get; set; }

        [Precision(18, 2)]
        public decimal ValorTotal { get; set; }

        public DateTime DataEntrega { get; set; }
        public DateTime DataPagamento { get; set; }

        [Precision(18, 2)]
        public decimal Descontos { get; set; }

        [Precision(18, 2)]
        public decimal ValorLiquido { get; set; }

        public string? NumeroContrato { get; set; }
        public string idconta { get; set; }
        public string? uid { get; set; }
        public DateTime? datains { get; set; }
        public DateTime? dataup { get; set; }
    }
}