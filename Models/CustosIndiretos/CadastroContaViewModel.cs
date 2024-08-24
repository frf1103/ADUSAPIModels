namespace FarmPlannerAPICore.Models.CustosIndiretos
{
    public class CadastroContaViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int IdGrupoConta { get; set; }
        public string? CodigoExterno { get; set; }
        public string? CodigoCliente { get; set; }
        public string idconta { get; set; }
    }
}