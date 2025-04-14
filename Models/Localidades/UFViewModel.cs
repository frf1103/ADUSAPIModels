using ADUSAPI.Entities;
using System.ComponentModel.DataAnnotations;

namespace ADUSAPICore.Models.Localidades
{
    public class UFViewModel
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Nome { get; set; }
        [MaxLength(2)]
        public string Sigla { get; set; }
        [MaxLength(2)]
        public string CodigoIBGE { get; set; }


    }
}
