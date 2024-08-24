namespace FarmPlannerAPICore.Models.CustosIndiretos
{
    public class GrupoContaViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int IdOrganizacao { get; set; }
        public int IdClasseConta { get; set; }
        public string? CodigoCliente { get; set; }
        public string? CodigoExterno { get; set; }
        public string idconta { get; set; }
    }
}