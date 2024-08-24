namespace FarmPlannerAPICore.Models.Organizacao
{
    public class OrganizacaoUsuarioViewModel
    {
        public int id { get; set; }
        public string uid { get; set; }
        public int idorganizacao { get; set; }
        public string? nomeusuario { get; set; }
        public string? descorg { get; set; }
    }
}