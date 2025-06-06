﻿using ADUSAPI.Entities.Enum.ADUSAPI.Entities.Enum;
using ADUSAPICore.Models.Enum;

namespace ADUSAPICore.Models.Parceiro
{
    public class ParceiroViewModel
    {
        public string Id { get; set; }

        public string RazaoSocial { get; set; }
        public string Fantasia { get; set; }
        public TipodePessoa TipodePessoa { get; set; }
        public string Registro { get; set; }

        public string cep { get; set; }

        public string Logradouro { get; set; }

        public string Numero { get; set; }
        public string? Complemento { get; set; }
        public string Bairro { get; set; }
        public int iduf { get; set; }

        public int idCidade { get; set; }
        public string Profissao { get; set; }
        public TipoEstadoCivil EstadoCivil { get; set; }
        public string? IdRepresentante { get; set; }

        public DateTime DtNascimento { get; set; }

        public DateTime? datains { get; set; }
        public DateTime? dataup { get; set; }

        public string Fone1 { get; set; }
        public string? Fone2 { get; set; }
        public string email { get; set; }
        public string? observacao { get; set; }
        public int Sexo { get; set; }
    }
}