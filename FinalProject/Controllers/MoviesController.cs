using FinalProject.Data;
using FinalProject.Models;
using FinalProject.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        private IIMDBService _IMDBService;
        //User newUser = new User(1,"this", 5);
        public MoviesController(ApplicationDbContext context, IIMDBService imdbService)
        {
            _context = context;
            _IMDBService = imdbService;
           
        }



        //Gets all movies from current user list.
        [HttpGet("GetAllMovies")]
        public IActionResult GetAllMoviesFromUserList(string authId)
        {
            if (_context.Movies == null)
            {
                return NotFound();
            }
            var response = _context.Movies.Where(x => x.Auth0Id == authId).ToList();

            return Ok(response);


        }

        //Figure out how to find a random movie 
        [HttpGet("GetRandomMovieFromThirdParty")]
        public IActionResult GetRandomMovieFromThirdParty()
        {
            return Ok();
        }

        //Use random feature 
        [HttpGet("GetRandomMovieFromUserList")]
        public IActionResult GetRandomMovieFromUserList(string authId)
        {
            if (_context.Movies == null)
            {
                return NotFound();
            }

            var userList = _context.Movies.Where(x => x.Auth0Id == authId).ToList();

            var rand = new Random();
            int number = rand.Next(1, userList.Count() + 1);

            var movie = userList[number-1];

            return Ok(movie);
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

        [HttpGet("GetUsername")]
        public IActionResult GetUsername(string username)
        {
            var searchUser = _context.Users.Where(x => x.UserName.ToLower() == username.ToLower()).FirstOrDefault();

            return Ok(searchUser);
        }

        [HttpPost("AddNewUser")]
        public IActionResult AddNewUser(User newUser)
        {
            _context.Users.Add(newUser);
            _context.SaveChanges();
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
