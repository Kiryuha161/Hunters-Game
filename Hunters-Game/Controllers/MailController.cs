using Hunters_Game.Data;
using Hunters_Game.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hunters_Game.Controllers
{
    public class MailController : Controller
    {
        private readonly HunterDbContext _database;

        public MailController(HunterDbContext database) 
        {
            _database = database;
        }
        public IActionResult Index()
        {
            List<Mail> mails = _database.Mails.ToList();

            return View(mails);
        }
    }
}
