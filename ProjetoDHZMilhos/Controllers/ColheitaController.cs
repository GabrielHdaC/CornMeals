using Microsoft.AspNetCore.Mvc;
using ProjetoDHZMilhos.Models.Colheita;


namespace ProjetoDHZMilhos.Controllers
{
    public class ColheitaController : Controller
    {
        public IActionResult Index()
        {
            var colheitas = new List<ColheitaModel>()
            {
                new ColheitaModel(){Id = 1, Data_Colheita = new DateTime(2025, 01, 27), Plantacao_Id = 1, Qualidade = "ÓTIMO", Quantidade_Colhida = 2300000},
                new ColheitaModel(){Id = 2, Data_Colheita = new DateTime(2024, 02, 23), Plantacao_Id = 5, Qualidade = "RUIM", Quantidade_Colhida = 24500000},
                new ColheitaModel(){Id = 1, Data_Colheita = new DateTime(2023, 09, 28), Plantacao_Id = 1, Qualidade = "MEDIANA", Quantidade_Colhida = 2900000},
                new ColheitaModel(){Id = 1, Data_Colheita = new DateTime(2024, 02, 29), Plantacao_Id = 1, Qualidade = "ÓTIMO", Quantidade_Colhida = 3300000}
            };

            var model = new ColheitasModel()
            {
                Colheitas = colheitas
            };

            return View(model);
        }
    }
}
