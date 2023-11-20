using Laboratorium_3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium_3.Controllers
{
    public class ProductController : Controller
    {
        private static List<ProductModel> listaProduktow = new List<ProductModel>
        {
            new ProductModel { Id = 1, Nazwa = "Produkt 1", Cena = 10.99m, Producent = "Producent 1", DataProdukcji = DateTime.Now, Opis = "Opis produktu 1" },
            new ProductModel { Id = 2, Nazwa = "Produkt 2", Cena = 20.99m, Producent = "Producent 2", DataProdukcji = DateTime.Now, Opis = "Opis produktu 2" },
        };

        // GLOWNY WIDOK
        // GET: /Product
        public IActionResult Index()
        {
            return View(listaProduktow);
        }

        //SZCZEGOLOWE INFORMACJE
        // GET: /Product/Details/1
        public IActionResult Details(int id)
        {
            // Znajdź produkt o danym id w liście
            var product = listaProduktow.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound(); // Produkt o podanym id nie został znaleziony
            }

            return View(product);
        }

        // DODAWANIE
        // GET: /Product/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View("Form");
        }

        // POST: /Product/Create
        [HttpPost]
        public IActionResult Create(ProductModel model)
        {
            if (ModelState.IsValid)
            {
                model.Id = listaProduktow.Count + 1;

                listaProduktow.Add(model);

                return RedirectToAction("Index");
            }
            else
            {
                return View("Form", model);
            }
        }

        //EDYCJA

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var product = listaProduktow.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return View("Edit", product);
        }

        [HttpPost]
        public IActionResult Edit(ProductModel model)
        {
            if (ModelState.IsValid)
            {
                var index = listaProduktow.FindIndex(p => p.Id == model.Id);

                if (index != -1)
                {
                    listaProduktow[index] = model;
                }

                return RedirectToAction("Index");
            }
            else
            {
                return View("Edit", model);
            }

        }

        //USUWANIE
        // GET: /Product/Delete/1

        [HttpGet]
        public IActionResult Delete(int id)
        {
            // Znajdź produkt o danym id w liście
            var product = listaProduktow.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound(); // Produkt o podanym id nie został znaleziony
            }

            return View(product);
        }

        // POST: /Product/DeleteConfirmed/1
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            // Znajdź produkt o danym id w liście
            var product = listaProduktow.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound(); // Produkt o podanym id nie został znaleziony
            }

            // Usuń produkt z listy
            listaProduktow.Remove(product);

            return RedirectToAction("Index");
        }
    }
 }
