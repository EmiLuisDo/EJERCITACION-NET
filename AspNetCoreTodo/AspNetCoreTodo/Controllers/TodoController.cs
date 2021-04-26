using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreTodo.Services;
using AspNetCoreTodo.Models;
using Microsoft.AspNetCore.Mvc;
namespace AspNetCoreTodo.Controllers
{
    public class TodoController : Controller
    {
        private readonly ITodoItemService _todoItemService;

        public TodoController(ITodoItemService todoItemService)
        {
            this._todoItemService = todoItemService;
        }
        public async Task<IActionResult> IndexAsync()
        {
            // Obtener las tareas desde la base de datos
            // Colocar los tareas en un modelo
            // Genera la vista usando el modelo

            TodoItem[] items = await _todoItemService.GetIncompleteItemsAsync();
            return null;
        }
    }
}