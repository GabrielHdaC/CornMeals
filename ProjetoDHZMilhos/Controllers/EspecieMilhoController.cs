using Microsoft.AspNetCore.Mvc;
using ProjetoDHZMilhos.Models.EspecieMilho;

namespace ProjetoDHZMilhos.Controllers
{
    public class EspecieMilhoController : Controller
    {
        public IActionResult Index()
        {

            var especiesMilho = new List<EspecieMilhoModel>()
            {
                new EspecieMilhoModel() 
                { 
                    ID = 1, 
                    Nome = "Híbrido SV9298SN",
                    Categoria = CategoriaMilho.Doce,
                    CorExterna = "Amarelo",
                    RendimentoIndustrial = 44,
                    UniformidadeColheita = "Alta Uniformidade",
                    EstacaoTransplante = "Ano Todo",
                    EstacaoPlantio = "Ano Todo",
                    EstacaoColheita = "Ano Todo",
                    Biotech = true
                }
            };

            var model = new EspeciesMilhoModel()
            {
                EspeciesMilho = especiesMilho
            };

            return View(model);
        }
    }
}
