using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using arman_web2.Models;
using X.PagedList;

namespace arman_web2.Controllers;

public class HomeController : Controller
{
    private ICommentRepository _commentRepository;
    public HomeController(ICommentRepository commentRepository)
    {
        _commentRepository = commentRepository;
    }


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
    public IActionResult Comments(int page = 1)
    {   
        var viewmodel = new ViewModel();

        viewmodel.comments = _commentRepository.Comments.ToPagedList(page,5);

        return View(viewmodel);
    }

    [HttpPost]
    public IActionResult Comments(ViewModel model)
    {
 
            DateTime date = DateTime.Now;
            var comment = new Comment
            {
                name = model.comment.name,
                message = model.comment.message,
                creation_date = date
            };

            _commentRepository.CreateComment(comment);

            return RedirectToAction("Comments");
    }

}

