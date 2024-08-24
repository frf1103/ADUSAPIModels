namespace FarmPlannerAPICore.Models.OrcamentoProduto
{
    public class ListOrcamentoProdutoViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int IdSafra { get; set; }
        public int IdFazenda { get; set; }
        public string DescFazenda { get; set; }
        public string DescSafra { get; set; }


    }
}
