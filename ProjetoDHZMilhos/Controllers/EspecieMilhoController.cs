using Microsoft.AspNetCore.Mvc;
using ProjetoDHZMilhos.Models.EspecieMilho;

namespace ProjetoDHZMilhos.Controllers
{
    public class EspecieMilhoController : Controller
    {
        public static List<EspecieMilhoModel> _EspeciesMilho = new List<EspecieMilhoModel>()
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

        // teste commit

        public IActionResult Index()
        {
            var model = new EspeciesMilhoModel() { EspeciesMilho = _EspeciesMilho };

            return View(model);
        }

        public IActionResult Record(long id)
        {
            ViewBag.CategoriasMilho = Enum.GetValues(typeof(CategoriaMilho)).Cast<CategoriaMilho>().ToList();
            var especieMilhoAtual = _EspeciesMilho.FirstOrDefault(especieMilho => especieMilho.ID == id);
            return View(especieMilhoAtual);
        }

        [HttpPost]
        public IActionResult Save(EspecieMilhoModel model)
        {
            var especieMilho = _EspeciesMilho.FirstOrDefault(e => e.ID == model.ID);

            especieMilho.Nome = model.Nome;
            especieMilho.Categoria = model.Categoria;
            especieMilho.CorExterna = model.CorExterna;
            especieMilho.RendimentoIndustrial = model.RendimentoIndustrial;
            especieMilho.UniformidadeColheita = model.UniformidadeColheita;
            especieMilho.EstacaoTransplante = model.EstacaoTransplante;
            especieMilho.EstacaoPlantio = model.EstacaoPlantio;
            especieMilho.EstacaoColheita = model.EstacaoColheita;
            especieMilho.Biotech = model.Biotech;

            return RedirectToAction("Index");
        }

        public IActionResult PaginaAdicionar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Adicionar(EspecieMilhoModel model)
        {
            int idEspecieMilhoNovo = _EspeciesMilho.Count;

            _EspeciesMilho.Add(new EspecieMilhoModel()
            {
                ID = ++idEspecieMilhoNovo,
                Nome = model.Nome,
                Categoria = model.Categoria,
                CorExterna = model.CorExterna,
                RendimentoIndustrial = model.RendimentoIndustrial,
                UniformidadeColheita = model.UniformidadeColheita,
                EstacaoTransplante = model.EstacaoTransplante,
                EstacaoPlantio = model.EstacaoPlantio,
                EstacaoColheita = model.EstacaoColheita,
                Biotech = model.Biotech,
            });

            return RedirectToAction("Index");
        }
    }
}
