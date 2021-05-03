using System.Collections.Generic;
using Library.Models;
using Microsoft.AspNetCore.Mvc;

namespace Controllers
{
    [Route("api/books")]
    public class BooksController : Controller
    {

    [HttpGet]
    public IEnumerable<Book> Get()
    {
    // return todos los libros
    }

    [HttpGet("{id}")]
    public Book Get(int id)
    {
    // return el libro que coincida con el id }
    }
}