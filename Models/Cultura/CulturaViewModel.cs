using FarmPlannerAPICore.Models.Variedade;

namespace FarmPlannerAPICore.Models.Cultura
{
    public class CulturaViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string UnidadeProdutiva { get; set; }
        public string NomeProduto { get; set; }
        public int DiasEstimadosEmergencia { get; set; }
        public string? CodigoExterno { get; set; }

        public List<ListVariedadeViewModel>? listVariedade { get; set; }
    }
}