using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private MoviesContext _context;
        public MoviesController(MoviesContext context)
        {
            this._context = context;
        }

        [HttpGet(Name = "Get All Movies")]
        public ActionResult<IEnumerable<MoviesItem>> GetMoviesItems()
        {
            _context = HttpContext.RequestServices.GetService(typeof(MoviesContext)) as MoviesContext;
            return _context.GetAllMovies();
        }

        [HttpPost(Name = "Add Movies")]
        public ActionResult<string> AddMovies(MoviesItem item)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MoviesContext)) as MoviesContext;
            return _context.AddMovies(item);

        }

        [HttpGet("{id}", Name = "Get Movies By Id")]
        public ActionResult<IEnumerable<MoviesItem>> GetMoviesItem(String id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MoviesContext)) as MoviesContext;
            return _context.GetMoviesById(id);

        }

        [HttpPut("{id}",Name = "Update Movies By Id")]
        public ActionResult<string> UpdateMoviesById(string id,MoviesItem item)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MoviesContext)) as MoviesContext;
            return _context.UpdateById(id,item);

        }

        [HttpDelete("{id}", Name = "Delete Movies By Id")]
        public ActionResult<string> DeleteMoviesById(string id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MoviesContext)) as MoviesContext;
            return _context.DeleteById(id);

        }
    }
}
