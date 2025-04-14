using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADUSAPICore.Models.Banco
{
    public class BancoViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public string Codigo { get; set; } = string.Empty;
    }
}