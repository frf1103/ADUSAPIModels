namespace FarmPlannerAPICore.Models.Maquinas
{
    public class ListMaquinaViewModel
    {
        public int Id { get; set; }
        public string idconta { get; set; }
        public string Descricao { get; set; }
        public int Ano { get; set; }
        public string CodigoExterno { get; set; }
        public int IdModeloMaquina { get; set; }
        public string DescModelo { get; set; }
        public int idorganizacao { get; set; }
    }
}