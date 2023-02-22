using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using arman_web2.Models;
using X.PagedList;
using System.Text.Encodings.Web;
using JetBrains.Annotations;

namespace arman_web2.Controllers;

public class HomeController : Controller
{
    private ICommentRepository _commentRepository;
    private IContactRepository _contactRepository;
    public HomeController(ICommentRepository commentRepository,IContactRepository contactRepository)
    {
        _commentRepository = commentRepository;
        _contactRepository = contactRepository;
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

    [HttpPost]
    public IActionResult Contact(Contact model)
    {  
        if (ModelState.IsValid)
        {
            _contactRepository.CreateContact(model);
            return RedirectToAction("Thanks");
        }
        else
        {
            return RedirectToAction("Contact");
        }
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

        var comment = new Comment();

        if (ModelState.IsValid)
        {
            DateTime date = DateTime.Now;
            comment.name = model.name;
            comment.message = model.message;
            comment.creation_date = date;

            _commentRepository.CreateComment(comment);

            return RedirectToAction("Comments");
        }
        else
        {
            return RedirectToAction("Comments");
        }
    }
     public IActionResult Thanks() { return View(); }

}

