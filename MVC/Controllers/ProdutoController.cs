using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            List<Produto> list = new List<Produto>
            {
                new Produto { Id = 1, Nome = "Notebook", Preco = 3500 },
                new Produto { Id = 2, Nome = "Teclado", Preco = 189 }
            };

            return View(list);
        }
    }
}
