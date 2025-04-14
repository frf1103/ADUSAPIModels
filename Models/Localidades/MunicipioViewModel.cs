using System.ComponentModel.DataAnnotations;

namespace ADUSAPICore.Models.Localidades
{
    public class MunicipioViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [MaxLength(7)]
        public string CodigoIBGE { get; set; }
        public int IdUF { get; set; }
    }
}
