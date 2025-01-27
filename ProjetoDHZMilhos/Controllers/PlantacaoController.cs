using Microsoft.AspNetCore.Mvc;
using ProjetoDHZMilhos.Models.Plantacao;

namespace ProjetoDHZMilhos.Controllers
{
    public class PlantacaoController : Controller
    {
        

        public IActionResult Index()
        {
            var plantacoes = new List<PlantacaoModel>()
            {
                new PlantacaoModel() {ID = 1, Fazenda_ID = 1, Nome = "Plantação 1", Area = "10 hectares", Tipo_Milho = "Milho Pipoca"}
            };

            var model = new PlantacoesModel()
            {
                Plantacoes = plantacoes
            };

            return View(model);
        }

        


    }
}
