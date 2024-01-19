using CRUDNet8MVC.Data;
using CRUDNet8MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CRUDNet8MVC.Controllers
{
  public class ContactController : Controller
  {
    private readonly ApplicationDbContext _context;

    public ContactController(ApplicationDbContext context)
    {
      _context = context;


    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
      return View(await _context.Contacts.ToListAsync());
    }

    [HttpGet]
    public IActionResult CreateNewContact()
    {
      return View();
    }
        [HttpPost]
        public async Task<IActionResult> CreateNewContact(Contact contact)
        {
            if (ModelState.IsValid)
            {
                _context.Contacts.Add(contact);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
