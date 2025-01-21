using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Model.Movies;
using WebApp.Models.Movies;

namespace WebApp.Controllers;

public class MovieCastController : Controller
{
    private readonly MoviesDbContext _context;

    public MovieCastController(MoviesDbContext context)
    {
        _context = context;
    }

    // GET: MovieCast
    public async Task<IActionResult> Index(int? id)
    {
        var movieCast = new MovieCast
        {
            MovieId = id 
        };
        return View(movieCast);
    }

    // POST: Movie/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(MovieCast movieCast, string personName)
    {
        if (ModelState.IsValid)
        {
            var lastPerson = await _context.People
                .OrderByDescending(p => p.PersonId)
                .FirstOrDefaultAsync();
            
            var newPerson = new Person
            {
                PersonId = lastPerson.PersonId + 1,
                PersonName = personName
            };
            _context.People.Add(newPerson);
            await _context.SaveChangesAsync();

            movieCast.PersonId = newPerson.PersonId;

            _context.MovieCasts.Add(movieCast);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Movie");
        }

        return View(movieCast);
    }
}