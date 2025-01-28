namespace ProjetoDHZMilhos.Models.EspecieMilho
{
    public class EspecieMilhoModel
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public CategoriaMilho Categoria { get; set; }
        public string CorExterna { get; set; }
        public int RendimentoIndustrial { get; set; }
        public string UniformidadeColheita { get; set; }
        public string EstacaoTransplante { get; set; }
        public string EstacaoPlantio { get; set; }
        public string EstacaoColheita { get; set; }
        public bool Biotech { get; set; }
    }
}
