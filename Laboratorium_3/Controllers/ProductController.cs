using Laboratorium_3.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Laboratorium_3.Controllers
{
    public class ProductController : Controller
    {
        private static List<ProductModel> productList = new List<ProductModel>
        {
            new ProductModel { Id = 1, Name = "Product 1", Price = 10.99m, Producer = "Producer 1", ProductionDate = DateTime.Now, Description = "Product 1 description" },
            new ProductModel { Id = 2, Name = "Product 2", Price = 20.99m, Producer = "Producer 2", ProductionDate = DateTime.Now, Description = "Product 2 description" },
        };

        // MAIN VIEW
        // GET: /Product
        public IActionResult Index()
        {
            return View(productList);
        }

        // DETAILS
        // GET: /Product/Details/1
        public IActionResult Details(int id)
        {
            // Find the product with the given id in the list
            var product = productList.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound(); // Product with the specified id was not found
            }

            return View(product);
        }

        // ADDING
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
                model.Id = productList.Count + 1;

                productList.Add(model);

                return RedirectToAction("Index");
            }
            else
            {
                return View("Form", model);
            }
        }

        // EDITING

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var product = productList.FirstOrDefault(p => p.Id == id);

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
                var index = productList.FindIndex(p => p.Id == model.Id);

                if (index != -1)
                {
                    productList[index] = model;
                }

                return RedirectToAction("Index");
            }
            else
            {
                return View("Edit", model);
            }
        }

        // DELETING
        // GET: /Product/Delete/1

        [HttpGet]
        public IActionResult Delete(int id)
        {
            // Find the product with the given id in the list
            var product = productList.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound(); // Product with the specified id was not found
            }

            return View(product);
        }

        // POST: /Product/DeleteConfirmed/1
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            // Find the product with the given id in the list
            var product = productList.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound(); // Product with the specified id was not found
            }

            // Remove the product from the list
            productList.Remove(product);

            return RedirectToAction("Index");
        }
    }
}