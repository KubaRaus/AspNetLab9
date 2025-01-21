using Microsoft.AspNetCore.Mvc;
using WebApp.Model.Movies;
using WebApp.Models.Movies;

namespace WebApp.Controllers;

public class CastController : Controller
{
    private readonly MoviesDbContext _context;

    public CastController(MoviesDbContext context)
    {
        _context = context;
    }
    
    // POST: Cast/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("CharacterName,Person,Gender,CastOrder")] MovieCast movieCast)
    {
        if (ModelState.IsValid)
        {
            _context.MovieCasts.Add(movieCast);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Movie");
        }

        return View(movieCast);
    }
}



    
