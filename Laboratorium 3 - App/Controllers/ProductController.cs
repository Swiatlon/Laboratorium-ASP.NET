using Microsoft.AspNetCore.Mvc;
using Models.Product;
public class ProductController : Controller
{
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Product model)
    {
        if (ModelState.IsValid)
        {
            return RedirectToAction("Success");
        }
        return View(model);
    }
    public IActionResult Success()
    {
        return View();
    }
}