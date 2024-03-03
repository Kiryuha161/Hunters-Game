using Hunters_Game.Common.Utils;
using Hunters_Game.Data;
using Hunters_Game.Models.Characters;
using Hunters_Game.Models.Stat;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hunters_Game.Controllers
{
    public class HunterController : Controller
    {
        private readonly HunterDbContext _database;

        public HunterController(HunterDbContext database)
        {
            _database = database;
        }

        public IActionResult Index()
        {
            List<Hunter> hunters = _database.Hunters.Include(h => h.HunterStats).ToList();

            return View(hunters);
        }

        public IActionResult GetHunterStats(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Hunter hunter = _database.Hunters.Include(h => h.HunterStats).FirstOrDefault(h => h.CharacterId == id);

            if (hunter == null)
            {
                return NotFound();
            }

            return View(hunter);
        }


        public IActionResult AddHunters(int count = 3)
        {
            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                Hunter hunter = new Hunter();
                hunter.GetRandomInfo();
                _database.Hunters.Add(hunter);
            }

            _database.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
