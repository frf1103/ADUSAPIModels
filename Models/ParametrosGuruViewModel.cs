using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADUSAPICore.Models
{
    public class ParametrosGuruViewModel
    {
        public int id { get; set; }
        public string token { get; set; }
        public DateTime ultdata { get; set; }
        public string urlsub { get; set; }
        public string urltransac { get; set; }

        public int? idtransacao { get; set; }
        public int? idcategoria { get; set; }
        public string? idconta { get; set; }
        public string? idparceiro { get; set; }
        public int? idccusto { get; set; }
        public int? idcategoriataxa { get; set; }
        public int? idcategoriaant { get; set; }
        public int? idtransacaotaxa { get; set; }
        public int? idtransacaoant { get; set; }
        public int? idtransacaocomiss { get; set; }
        public int? idcategoriacomiss { get; set; }
    }
}