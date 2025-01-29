using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraAplicacao.Utils.Entidades;
using ProjetoDHZMilhos.Models.Fazenda;
using ProjetoDHZMilhos.Models.Plantacao;

namespace ProjetoDHZMilhos.Controllers
{
    public class FazendaController : Controller
    {
        public IActionResult Index()
        {
            var model = new FazendasModel();
            model.Fazendas = new List<FazendaModel>();

            var fazendas = Fazenda.GetAll();

            
            model.Fazendas = fazendas.Select(fazendaEntidade => new FazendaModel(fazendaEntidade)).ToList();

            return View(model);
        }

        public IActionResult Record(long id)
        {
            return View(null);
        }
    }
}
