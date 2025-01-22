namespace ProjetoDHZMilhos.Models.Plantio
{
    public class PlantioModel
    {
        public int Id { get; set; }
        public int Plantacao_Id { get; set; }
        public DateTime Data_Plantio { get; set; }
        public string Tipo_Milho { get; set; }
        public string Quantidade_Sementes { get; set; }

    }
}
