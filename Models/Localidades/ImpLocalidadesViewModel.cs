namespace ADUSAPICore.Models.Localidades
{
    public class ImpUF
    {
        public int codigo_uf { get; set; }
        public string uf { get; set; }
        public string nome { get; set; }
        public decimal latitude { get; set; }
        public decimal longitude { get; set; }
        public string regiao { get; set; }
    }

    public class ImpMun
    {
        public int codigo_ibge { get; set; }
        public string nome { get; set; }
        public decimal latitude { get; set; }
        public decimal longitude { get; set; }
        public int capital { get; set; }
        public int codigo_uf { get; set; }
        public int siafi_id { get; set; }
        public int ddd { get; set; }
        public string fuso_horario { get; set; }
    }

}
