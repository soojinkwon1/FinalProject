using KidsClubApplication.Data;
using KidsClubApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
#nullable disable
namespace KidsClubApplication.Controllers
{
    public class EventBookController : Controller 
    {
        private readonly ApplicationDbContext _context;

        public EventBookController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.EventList = await _context.Event.ToListAsync();
            return View();
        }
        [HttpPost]
        /*public IActionResult EventMessage(Booked b)
        {
            b.CreatedAt = DateTime.Now;
            _context.Booked.Add(b);
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                ViewData["ebm"] = $"Something went wrong.";
            }
            finally
            {
                ViewData["ebm"] = $"A message from {b.EFullName}, {b.PNumber}, {b.ESubject}, {b.EMessage} was successful!";

            }

            return View();*/
        public IActionResult EventMessage(Booked b)
        {
            b.CreatedAt = DateTime.Now;
            _context.Booked.Add(b);
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                ViewData["ebm"] = $"Something went wrong.";
            }
            finally
            {
                ViewData["ebm"] = $"A message from {b.EFullName}, {b.PNumber}, {b.ESubject}, {b.EMessage} was successful!";

            }

            return View();

        }
    }
}