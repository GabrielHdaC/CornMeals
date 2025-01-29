using MinhaPrimeiraAplicacao.Utils.Entidades;

namespace ProjetoDHZMilhos.Models.Fazenda

{
    public class FazendaModel
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public int Tamanho { get; set; }

        public FazendaModel()
        {

        }

        
        public FazendaModel(MinhaPrimeiraAplicacao.Utils.Entidades.Fazenda fazenda)
        {
            ID = fazenda.ID;
            Nome = fazenda.Nome;
            Endereco = fazenda.Endereco;
            Tamanho = fazenda.Tamanho;
        }
    }
}
