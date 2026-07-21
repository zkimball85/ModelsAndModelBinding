using Microsoft.AspNetCore.Mvc;
using ModelsAndModelBinding.Models;

namespace ModelsAndModelBinding.Controllers;

public class ProductController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Product p)
    {
        if (ModelState.IsValid)
        {
            // Add the product to the database.

            // Redirect to the product list page.
            return RedirectToAction("Index");
        }

        // Show webpage with validation errors.
        return View(p);
    }
}

