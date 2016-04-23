
namespace BARBAROS.MVC.Models
{
    public class ClanModel
    {
        public string Tag { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string FrequanciaDeGuerra { get; set; }
        public int Level { get; set; }
        public int Vitorias { get; set; }
        public int VitoriasSeguidas { get; set; }
        public int PontuacaoDoClan { get; set; }
        public int QtdMembros { get; set; }
        //public LocacaoModel Locacao { get; set; }
        //public InsigniaModel Insignias { get; set; }
    }
}