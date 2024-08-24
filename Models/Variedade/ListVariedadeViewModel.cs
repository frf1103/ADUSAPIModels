namespace FarmPlannerAPICore.Models.Variedade
{
    public class ListVariedadeViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int IdCultura { get; set; }
        public int Ciclo { get; set; }
        public string CodigoExterno { get; set; }

        public int IdTecnologia { get; set; }
        public string desctecnologia { get; set; }
        public string desccultura { get; set; }
    }
}
