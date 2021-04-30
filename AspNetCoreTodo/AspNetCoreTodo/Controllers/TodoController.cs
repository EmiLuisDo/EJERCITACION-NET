using System;
using AspNetCoreTodo.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreTodo.Models;

namespace AspNetCoreTodo.Controllers
{
    public class TodoController : Controller
{
    private readonly ITodoItemService _todoItemService;
    public TodoController(ITodoItemService todoItemService)
    {
        _todoItemService = todoItemService;
    }

    [ValidateAntiForgeryToken]
    public async Task<IActionResult> AddItem(TodoItem newItem)
    {
        if (!ModelState.IsValid)
        {
            Console.WriteLine("Entro1");
            return RedirectToAction("Index");
        }
        var successful = await _todoItemService.AddItemAsync(newItem);
        if (!successful)
        {
            Console.WriteLine("Entro2");
            return BadRequest("Could not add item.");
        }
        return RedirectToAction("Index");
    }


    public async Task<IActionResult> Index()
    {
    var items = await _todoItemService.GetIncompleteItemsAsync();
    var model = new TodoViewModel()
    {
        Items = items
    };
    return View(model);
    }
}
}