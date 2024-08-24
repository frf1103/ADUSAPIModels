using FarmPlannerAPI.Entities.Enum.FarmPlannerAPI.Entities.Enum;
using System.ComponentModel.DataAnnotations;

namespace FarmPlannerAPICore.Models.Organizacao
{
    public class EditarOrganizacaoViewModel
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Nome { get; set; }

        [MaxLength(15)]
        public string Mascara { get; set; }

        public TipodePessoa TipoPessoa { get; set; }
        public string Registro { get; set; }
        public string idconta { get; set; }
        public List<OrganizacaoUsuarioViewModel>? Usuarios { get; set; }
        public string? desctipo { get; set; }
    }
}