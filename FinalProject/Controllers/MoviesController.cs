using FinalProject.Data;
using FinalProject.Enums;
using FinalProject.Models;
using FinalProject.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : BaseController
    {
        private ApplicationDbContext _context;

        private IIMDBService _IMDBService;

        public MoviesController(ApplicationDbContext context, IIMDBService imdbService)
        {
            _context = context;
            _IMDBService = imdbService;
           
        }



        //Gets all movies from current user list.
        [HttpGet("GetAllMoviesFromUserList")]
        public IActionResult GetAllMoviesFromUserList()
        {
            if (_context.Movies == null)
            {
                return NotFound();
            }
            var response = _context.Movies.Where(x => x.Auth0Id == GetUserAuthId()).ToList();

            return Ok(response);


        }

        //Use random feature 
        [HttpGet("GetRandomMovieFromUserList")]
        public IActionResult GetRandomMovieFromUserList()
        {
            if (_context.Movies == null)
            {
                return NotFound();
            }

            var userList = _context.Movies.Where(x => x.Auth0Id == GetUserAuthId()).ToList();

            var rand = new Random();
            int number = rand.Next(1, userList.Count() + 1);

            var movie = userList[number-1];

            return Ok(movie);
        }

        [HttpGet("GetMoviesByCategoryFromUserList")]
        public IActionResult GetMoviesByCategoryFromUserList(MovieCategory category)
        {
            if (_context.Movies == null)
            {
                return NotFound();
            }

            var response = _context.Movies.Where(x => x.Auth0Id == GetUserAuthId() && x.Category == category).ToList();

            if (response.Count == 0)
            {
                return BadRequest(category);
            }   

            return Ok(response);
        }

        [HttpGet("GetRandomMovieByCategoryFromUserList")]
        public IActionResult GetRandomMovieByCategoryFromUserList(MovieCategory category)
        {
            if (_context.Movies == null)
            {
                return NotFound();
            }

            var userCategoryList = _context.Movies.Where(x => x.Auth0Id == GetUserAuthId() && x.Category == category).ToList();

            var rand = new Random();
            int number = rand.Next(1, userCategoryList.Count() + 1);

            if (userCategoryList.Count == 0)
            {
                return BadRequest(category);
            }

            var movie = userCategoryList[number - 1];

            if (movie == null)
            {
                return BadRequest(movie);
            }

            return Ok(movie);
        }


        [HttpDelete("DeleteMovieFromUserList")]
        public IActionResult DeleteMovieFromUserList(int id)
        {
            Movie movie = _context.Movies.FirstOrDefault(x => x.Id == id);
            if (movie == null)
            {
                return BadRequest(movie);
            }
            _context.Movies.Remove(movie);

            _context.SaveChanges();

            return Ok();
        }

        [HttpPost("AddMovieToUserList")]
        public IActionResult AddMovieToUserList(Movie newMovie)
        {
            _context.Movies.Add(newMovie);
            _context.SaveChanges();
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
        public IActionResult UpdateCategory(Movie movie)
        {

            var test = GetUserAuthId();

            var movieToUpdate = _context.Movies.Find(movie.Id);

            movieToUpdate.Category = movie.Category;

            _context.SaveChanges();

            return Ok();
        }
        
        [HttpGet("SearchThirdParty")]
        public  async Task<IActionResult> SearchThirdParty(string searchTerm)
        {

            var userSearch = await _IMDBService.GetMovieByName(searchTerm);
            return Ok(userSearch);
        }

        
    }
}
