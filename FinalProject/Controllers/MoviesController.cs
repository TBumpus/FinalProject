using FinalProject.Data;
using FinalProject.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        private IIMDBService _IMDBService;
        public MoviesController(ApplicationDbContext context, IIMDBService imdbService)
        {
            _context = context;
            _IMDBService = imdbService;
           
        }




        [HttpGet("GetAllMovies")]
        public IActionResult GetAllMovies()
        {
            if (_context.Movies == null)
            {
                return NotFound();
            }
            _IMDBService.GetMovieByName();
            return Ok(_context.Movies.ToList());


        }

        //Figure out how to find a random movie 
        [HttpGet("GetRandomMovieFromThirdParty")]
        public IActionResult GetRandomMovieFromThirdParty()
        {
            return Ok();
        }

        //Use random feature 
        [HttpGet("GetRandomMovieFromUserList")]
        public IActionResult GetRandomMovieFromUserList()
        {
            return Ok();
        }

        [HttpGet("GetMoviesByCategoryFromList")]
        public IActionResult GetMoviesByCategoryFromList()
        {
            return Ok();
        }

        [HttpGet("GetMovieByIdFromList")]
        public IActionResult GetMovieByIdFromList()
        {
            return Ok();
        }

        [HttpDelete("DeleteMovieFromList")]
        public IActionResult DeleteMovieFromList()
        {
            return Ok();
        }

        [HttpPost("AddMovieToList")]
        public IActionResult AddMovieToList()
        {
            return Ok();
        }

        [HttpPut("UpdateCategory")]
        public IActionResult UpdateCategory()
        {
            return Ok();
        }

        [HttpGet("SearchThirdParty")]
        public IActionResult SearchThirdParty()
        {
            return Ok();
        }
    }
}
