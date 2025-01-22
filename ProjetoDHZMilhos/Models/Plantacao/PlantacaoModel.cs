namespace ProjetoDHZMilhos.Models.Plantacao
{
    public class PlantacaoModel
    {
        public int Id { get; set; }
        public int Fazenda_ID { get; set; } 
        public string Nome { get; set; }
        public double Area { get; set; }
        public string Tipo_Milho { get; set; }

    }
}
