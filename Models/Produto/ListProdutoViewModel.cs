using FarmPlannerAPICore.Models.Enum;

namespace FarmPlannerAPICore.Models.Produto
{
    public class ListProdutoViewModel
    {
        public string idconta { get; set; }
        public string Descricao { get; set; }
        public int IdGrupoProduto { get; set; }

        public int IdFabricante { get; set; }

        //public int IdPrincipioAtivo { get; set; }
        public int unidadeBasica { get; set; }

        public int Id { get; set; }
        public string descunidade { get; set; }

        //public string descprincipio { get; set; }
        public string descfab { get; set; }

        public string descgrupo { get; set; }

        public string? tipo { get; set; }
    }
}