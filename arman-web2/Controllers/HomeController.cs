using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using arman_web2.Models;

namespace arman_web2.Controllers;

public class HomeController : Controller
{   

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Contact()
    {
        return View();
    }


    public IActionResult Comments()
    {
        var com1 = new Comment() { name = "ZORMAN1", message = "ASP.NET Core MVC1" };
        var com2 = new Comment() { name = "ZORMAN2", message = "ASP.NET Core MVC2" };
        var com3 = new Comment() { name = "ZORMAN3", message = "ASP.NET Core MVC3" };
        var com4 = new Comment() { name = "ZORMAN4", message = "ASP.NET Core MVC4" };

        CommentRepository.AddComment(com1);
        CommentRepository.AddComment(com2);
        CommentRepository.AddComment(com3);
        CommentRepository.AddComment(com4);

        return View(CommentRepository.comments);
    }

    [HttpPost]
    public IActionResult Comments(Comment comment)
    {
        CommentRepository.AddComment(comment);
        return View(comment);
    }
}

