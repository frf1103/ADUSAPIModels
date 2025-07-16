using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADUSAPICore.Models
{
    public class WebhookAsaasViewModel
    {
        public string Evento { get; set; }
        public string PaymentId { get; set; }
        public string SubscriptionId { get; set; }
        public string CustomerId { get; set; }
        public string Status { get; set; }
        public string BillingType { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataVencimento { get; set; }
        public string JsonCompleto { get; set; }
    }
}