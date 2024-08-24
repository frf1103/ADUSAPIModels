namespace FarmPlannerAPICore.Models.Conta
{
    public class EditarContaViewModel
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string contaguid { get; set; }
        public string uid { get; set; }
        public string telefone { get; set; }
        public bool? ativa { get; set; }
    }
}