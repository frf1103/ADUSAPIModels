using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADUSAPICore.Models.PlanoConta
{
    public class PlanoContaViewModel

    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public int? IdMae { get; set; }

        public string Sinal { get; set; }

        // Autorelacionamento
    }
}