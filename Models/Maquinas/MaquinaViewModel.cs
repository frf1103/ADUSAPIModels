using System.ComponentModel;

namespace FarmPlannerAPICore.Models.Maquinas
{
    public class MaquinaViewModel
    {
        public int Id { get; set; }
        public string idconta { get; set; }
        public string Descricao { get; set; }
        public int Ano { get; set; }
        public string? CodigoExterno { get; set; }
        public int IdModeloMaquina { get; set; }
        public int idorganizacao { get; set; }
    }
}