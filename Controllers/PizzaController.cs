using la_mia_pizzeria_static.Data;
using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            //Collegamento con il db
            PizzeriaDbContext db = new PizzeriaDbContext();

            List<Pizza> lista = db.Pizze.ToList();

            return View(lista);
        }

        public IActionResult Detail(int id)
        {
            //Collegamento con il db
            PizzeriaDbContext db = new PizzeriaDbContext();

            //selezione della pizza dal db secondo l'id passato
            Pizza pizza = db.Pizze.Where(p => p.Id == id).FirstOrDefault();

            return View(pizza);
        }
    }
}
