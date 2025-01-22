namespace ProjetoDHZMilhos.Models.Colheita
{
    public class ColheitaModel
    {
        public int Id { get; set; }
        public string Plantacao_Id { get; set; }
        public DateTime Data_Colheita { get; set; }
        public double Quantidade_Colhida { get; set; }
        public string Qualidade { get; set; }

    }
}
