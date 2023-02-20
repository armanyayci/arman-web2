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


    [HttpGet]
    public IActionResult Comments()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Comments(Comment comment)
    {
        CommentRepository.AddComment(comment);
        comment.creation_date = DateTime.Now;

        return RedirectToAction("Comments");
    }


    public PartialViewResult CommentsPartial()
    {;
        return PartialView("CommentsPartialView",CommentRepository.comments);
    }
}

