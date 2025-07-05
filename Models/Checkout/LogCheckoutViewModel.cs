using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADUSAPICore.Models.Checkout
{
    public class LogCheckoutViewModel
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public string IpOrigem { get; set; }
        public string TipoOperacao { get; set; } // Nome da operação (ex: "Tokenizacao", "CriarAssinatura")
        public string UrlRequisicao { get; set; }
        public string PayloadEnviado { get; set; }
        public string RetornoApi { get; set; }
        public DateTime DataHora { get; set; }
        public string StatusHttp { get; set; }
        public string? Erro { get; set; }
        public string? idparcela { get; set; }

        public string? nomeparceiro { get; set; }
        public string? idassinatura { get; set; }
        public string? nossonumero { get; set; }
    }
}