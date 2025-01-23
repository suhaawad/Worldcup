using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using worldcup.Data;
using worldcup.Models;

namespace worldcup.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _context;

    // Combined constructor to inject both dependencies

    public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;

    }

    public IActionResult Index()
    {
        // var categories = new List<Categories>
        // {
        //     new Categories { Id = 1, Name = "Stadiums", Description = "Find the Stadiums in the Kingdom", Icon = "fa-solid fa-futbol", Url = "Stadiums" , Image="murabba-Stadium.webp"},
        //     new Categories { Id = 2, Name = "Hotels", Description = "Book the finest hotels for your stay.", Icon = "fa-solid fa-hotel", Url = "Hotels" , Image="hotel-exterior.jpg"},
        //     new Categories { Id = 3, Name = "Transportation", Description = "Convenient transport options for your journey.", Icon ="fa-solid fa-helicopter", Url = "Transportation" , Image="transportation.webp"},
        //     new Categories { Id = 4, Name = "Match Schedule", Description = "Keep track of match timings and venues.", Icon ="fa-regular fa-calendar-days", Url = "Schedule" , Image="Match-Schedule.jpg"},
        //     new Categories { Id = 5, Name = "Tickets", Description = "Get tickets for your favorite matches.", Icon ="fa-solid fa-ticket", Url = "Tickets" , Image="tickets.png"},
        //     new Categories { Id = 6, Name = "Meals and Beverages", Description = "Explore nearby food and drink options.", Icon ="fa-duotone fa-solid fa-utensils", Url = "Beverages", Image="food.jpeg" }
        // };

        var categories = _context.Categories.ToList();



        return View(categories);
    }

public IActionResult Stadiums()
{
    var stadiums = new List<Stadiums>
    {
        // new Stadiums 
        // { 
        //     Id = 1, 
        //     Name = "King Fahd International Stadium",
        //     Capacity = 75000, 
        //     Type = "Football", 
        //     ContractionDate = new DateTime(1987, 1, 1),
        //     Owner = "Saudi Government",
        //     Length = 105, 
        //     Width = 68, 
        //     Height = 50, 
        //     Images = "path/to/image1.jpg",
        //     Facility = new List<string> { "VIP Lounges", "Media Centre", "Floodlights" }
        // },
        // new Stadiums 
        // { 
        //     Id = 2, 
        //     Name = "King Saud University Stadium", 
        //     Capacity = 25000, 
        //     City = "Riyadh", 
        //     Type = "Football", 
        //     ContractionDate = new DateTime(2015, 1, 1),
        //     Owner = "King Saud University",
        //     Length = 105, 
        //     Width = 70, 
        //     Height = 40, 
        //     Images = "path/to/image2.jpg",
        //     Facility = new List<string> { "Athletic Track", "Press Boxes", "Public Seating" }
        // },
        // new Stadiums 
        // { 
        //     Id = 3, 
        //     Name = "Jeddah King Abdullah Sports City",
        //     Capacity = 62000, 
        //     City = "Jeddah", 
        //     Type = "Football", 
        //     ContractionDate = new DateTime(2014, 1, 1),
        //     Owner = "Saudi Government",
        //     Length = 110, 
        //     Width = 72, 
        //     Height = 45, 
        //     Images = "path/to/image3.jpg",
        //     Facility = new List<string> { "Football Pitch", "Concert Hall", "Media Centre" }
        // },
        // new Stadiums 
        // { 
        //     Id = 4, 
        //     Name = "Prince Mohamed bin Fahd Stadium", 
        //     Capacity = 26500, 
        //     City = "Dammam", 
        //     Type = "Football", 
        //     ContractionDate = new DateTime(1997, 1, 1),
        //     Owner = "Saudi Government",
        //     Length = 105, 
        //     Width = 68, 
        //     Height = 45, 
        //     Images = "path/to/image4.jpg",
        //     Facility = new List<string> { "VIP Lounges", "Press Area", "Public Seating" }
        // },
        // new Stadiums 
        // { 
        //     Id = 5, 
        //     Name = "King Khalid Sports City", 
        //     Capacity = 22000, 
        //     City = "Abha", 
        //     Type = "Football", 
        //     ContractionDate = new DateTime(1985, 1, 1),
        //     Owner = "Saudi Government",
        //     Length = 100, 
        //     Width = 65, 
        //     Height = 40, 
        //     Images = "path/to/image5.jpg",
        //     Facility = new List<string> { "Athletic Track", "Football Field", "Press Boxes" }
        // },
        // new Stadiums 
        // { 
        //     Id = 6, 
        //     Name = "Prince Sultan bin Abdul Aziz Stadium", 
        //     Capacity = 27000, 
        //     City = "Al-Majma'ah", 
        //     Type = "Football", 
        //     ContractionDate = new DateTime(2008, 1, 1),
        //     Owner = "Saudi Government",
        //     Length = 105, 
        //     Width = 70, 
        //     Height = 43, 
        //     Images = "path/to/image6.jpg",
        //     Facility = new List<string> { "Athletic Track", "VIP Lounge", "Food Court" }
        // }
    };

    return View(stadiums);
}




    public IActionResult Hotels()
    {
        return View();
    }
    

    public IActionResult Transportation()
    {
        return View();
    }

    public IActionResult Schedule()
    {
        return View();
    }

    public IActionResult Tickets()
    {
        return View();
    }

    public IActionResult Beverages()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
