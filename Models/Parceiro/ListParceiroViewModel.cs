using ADUSAPI.Entities.Enum.ADUSAPI.Entities.Enum;
using ADUSAPICore.Models.Enum;

namespace ADUSAPICore.Models.Parceiro
{
    public class ListParceiroViewModel
    {
        public string Id { get; set; }

        public string? RazaoSocial { get; set; }
        public string? Fantasia { get; set; }
        public TipodePessoa? TipodePessoa { get; set; }
        public string? Registro { get; set; }

        public string? cep { get; set; }

        public string? Logradouro { get; set; }

        public string? Numero { get; set; }
        public string Bairro { get; set; }
        public int? uf { get; set; }
        public string? Complemento { get; set; }

        public int? Cidade { get; set; }
        public string? Profissao { get; set; }
        public TipoEstadoCivil EstadoCivil { get; set; }
        public string? IdRepresentante { get; set; }

        public string? nomecidade { get; set; }

        public string? nomeuf { get; set; }

        public DateTime? DtNascimento { get; set; }

        public DateTime? datains { get; set; }
        public DateTime? dataup { get; set; }

        public string? Fone1 { get; set; }
        public string? Fone2 { get; set; }
        public string? email { get; set; }
        public string? observacao { get; set; }
        public int? Sexo { get; set; }
        public string desctipo { get; set; }
        public string descestadocivil { get; set; }
    }
}