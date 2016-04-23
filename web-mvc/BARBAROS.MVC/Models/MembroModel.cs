
namespace BARBAROS.MVC.Models
{
    public class MembroModel
    {
        public string Tag { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public int Level { get; set; }
        public int Trofeis { get; set; }
        public int ClanRank { get; set; }
        public int Doacoes { get; set; }
        public int DoacoesRecebidas { get; set; }
        public LigaModel Liga { get; set; }
    }
}