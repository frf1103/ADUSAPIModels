using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADUSAPICore.Models.Convite
{
    public class ConviteViewModel
    {
        public string IdConvite { get; set; }
        public string Fone { get; set; }
        public string? Email { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataExpiracao { get; set; }
        public string IdAfiliado { get; set; }
        public int IdPlataforma { get; set; }
        public int Status { get; set; }
        public string? idassinatura { get; set; }
        public string? idformapgto { get; set; }
        public string? Titular { get; set; }
    }
}