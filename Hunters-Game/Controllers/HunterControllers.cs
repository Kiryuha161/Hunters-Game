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
            List<Hunter> hunters = _database.Hunters
                .Include(h => h.HunterStats)
                .Include(h => h.Region)
                .Include(h => h.Territory)
                .Include(h => h.Area)
                .Include(h => h.City)
                .Include(h => h.Disсtrict)
                .Include(h => h.CurrentLocation)
                .Include(h => h.Academy)
                .Include(h => h.Department)
                .ToList();

            return View(hunters);
        }

        public IActionResult GetHunterStats(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Hunter hunter = _database.Hunters
                .Include(h => h.HunterStats)
                .Include(h => h.Region)
                .Include(h => h.Territory)
                .Include(h => h.Area)
                .Include(h => h.City)
                .Include(h => h.Disсtrict)
                .Include(h => h.CurrentLocation)
                .Include(h => h.Academy)
                .Include(h => h.Department)
                .FirstOrDefault(h => h.CharacterId == id);

            if (hunter == null)
            {
                return NotFound();
            }

            return View(hunter);
        }


        public IActionResult AddHunters(int count = 1)
        {
            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                Hunter hunter = new Hunter();
                hunter.GetRandomInfo();
                hunter.Region = _database.Regions?.FirstOrDefault(h => h.RegionId == hunter.RegionId);
                hunter.Territory = _database.Territories?.FirstOrDefault(h => h.TerritoryId == hunter.TerritoryId);
                hunter.Area = _database.Areas?.FirstOrDefault(h => h.AreaId == hunter.AreaId);
                hunter.City = _database.Cities?.FirstOrDefault(h => h.CityId == hunter.CityId);
                hunter.Disсtrict = _database.Districts?.FirstOrDefault(h => h.DistrictId == hunter.DisсtrictId);
                hunter.CurrentLocation = _database.Districts?.FirstOrDefault(h => h.DistrictId == hunter.CurrentLocationId);
                hunter.Academy = _database.Academies?.FirstOrDefault(h => h.AcademyId == hunter.AcademyId);
                hunter.Department = _database.Departments?.FirstOrDefault(h => h.DepartmentId == hunter.DepartmentId);
                _database.Hunters.Add(hunter);
            }

            _database.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
