namespace ADUSAPICore.Models.Banco
{
    public class ContaCorrenteViewModel
    {
        public string Id { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public string Agencia { get; set; } = string.Empty;
        public string ContaBanco { get; set; } = string.Empty;
        public string Titular { get; set; } = string.Empty;
        public int BancoId { get; set; }

        public string? nomebanco { get; set; }
    }
}