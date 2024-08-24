using System.ComponentModel.DataAnnotations;

namespace FarmPlannerAPICore.Models.Localidades
{
    public class RegiaoViewModel
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Nome { get; set; }

        [MaxLength(15)]
        public string Mascara { get; set; }
    }
}
