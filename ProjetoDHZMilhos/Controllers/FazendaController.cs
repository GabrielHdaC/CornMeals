using Microsoft.AspNetCore.Mvc;
using ProjetoDHZMilhos.Models.Fazenda;

namespace ProjetoDHZMilhos.Controllers
{
    public class FazendaController : Controller
    {
        public IActionResult Index()
        {

            var fazendas = new List<FazendaModel>()
            {
                new FazendaModel() { ID = 1, Endereco = "Rua das Flores, 123 Bairro Primavera, Cidade Bela Estado Encantado, Brasil",
                Name = "Fazenda BlackStone", Tamanho = "500 hectares"}
            };

            var model = new FazendasModel()
            {
                Fazendas = fazendas
            };

            return View(model);
        }
    }
}
