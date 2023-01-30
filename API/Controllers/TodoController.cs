using Infrastructure.Data;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly TodoContext _context;
        public TodoController(TodoContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Todo>>> getTodos()
        {
            var todos = await _context.Todos.ToListAsync();
            return Ok(todos);
        }
        [HttpGet("{id}")]
        public string getTodo(int id)
        {
            return "This is a todo";
        }
    }
}