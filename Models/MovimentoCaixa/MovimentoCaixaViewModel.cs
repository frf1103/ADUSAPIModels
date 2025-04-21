using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADUSClient.MovimentoCaixa
{
    public class MovimentoCaixaViewModel
    {
        public int Id { get; set; }
        public int IdTransacao { get; set; }
        public int IdCentroCusto { get; set; }
        public string IdContaCorrente { get; set; }
        public int IdCategoria { get; set; }

        public string Sinal { get; set; }
        public string? Observacao { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataMov { get; set; }

        public string? DescTransacao { get; set; }
        public string? DescCentroCusto { get; set; }
        public string? DescContaCorrente { get; set; }
        public string? DescCategoria { get; set; }
        public string idparceiro { get; set; }
        public string? nomeparceiro { get; set; }
    }
}