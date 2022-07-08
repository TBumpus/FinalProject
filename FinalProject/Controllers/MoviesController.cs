﻿using FinalProject.Data;
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
            //pull the movie from the database by id
            var movieToUpdate = _context.Movies.Find(movie.Id);

            //set the category from the pulled movie to the category that is coming in as a function
            movieToUpdate.Category = movie.Category;

            //save changes after
            _context.SaveChanges();

            return Ok();
        }

        [HttpGet("SearchThirdParty")]
        public IActionResult SearchThirdParty()
        {
            return Ok();
        }

        
    }
}
