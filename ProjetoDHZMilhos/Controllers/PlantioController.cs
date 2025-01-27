using Microsoft.AspNetCore.Mvc;
using ProjetoDHZMilhos.Models.Plantio;

namespace ProjetoDHZMilhos.Controllers
{
    public class PlantioController : Controller
    {
        public IActionResult Index()
        {

            var plantios = new List<PlantioModel>()
            {
                new PlantioModel()
                {
                    Id = 1,
                    Plantacao_Id = 1,
                    Data_Plantio = new DateTime(2025, 1, 27), 
                    Tipo_Milho = "feio",
                    Quantidade_Sementes = 5000,
                    Hectares_Plantados = 100,
                }
            };

            var model = new PlantiosModel()
            {
                Plantios = plantios
            };

            return View(model);
        }
    }
}
