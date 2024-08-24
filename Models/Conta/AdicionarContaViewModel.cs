namespace FarmPlannerAPICore.Models.Conta
{
    public class AdicionarUsuarioConta
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string? uid { get; set; }
        public string? telefone { get; set; }
        public string? representanteid { get; set; }
        public bool? ativa { get; set; }
    }
}