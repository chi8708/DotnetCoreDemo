using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.Model;

namespace webapi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TodoController : ControllerBase
    {

        private readonly AppDbContext _db;
        public TodoController(AppDbContext db)
        {
            _db = db;
        }


        [HttpPost]
        public ActionResult<IList<TodoItem>> GetAll()
        {
            return _db.TodoItem.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<TodoItem> GetById(long id)
        {
            return _db.TodoItem.FirstOrDefault(p=>p.Id==id);
        }

        // POST api/values
        [HttpPost]
        public void Add([FromBody] TodoItem model)
        {
            _db.TodoItem.Add(model);
            _db.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}