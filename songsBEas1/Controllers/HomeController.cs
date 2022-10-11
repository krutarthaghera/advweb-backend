using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using songsBEas1.Models;

namespace songsBEas1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return Json(new[]
            {new
                {
                    key=0,
                    drugname="combiflam",
                    manufacturedby="sanofy india",
                    expiredate="june 2023",
                    catagory="tablet",
                    effects="fever",
                },
                new
                {
                    key=1,
                    drugname="crocin",
                    manufacturedby="gsk healthcare",
                    expiredate="MAY 2014",
                    catagory="tablet",
                    effects="headache",
                },
                new
                {
                    key=2,
                    drugname="dolo650",
                    manufacturedby="microlabs india pvt ltd",
                    expiredate="JAN 2023",
                    catagory="tablet",
                    effects="fever",
                },new
                {
                    key=3,
                    drugname="ldio1",
                    manufacturedby="mercury lab",
                    expiredate="MARCH 2025",
                    catagory="tablet",
                    effects="cold",
                },new
                {
                    key=4,
                    drugname="aspirine",
                    manufacturedby="bayer",
                    expiredate="JUNE 2024",
                    catagory="tablet",
                    effects="headache",
                },
              });
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

