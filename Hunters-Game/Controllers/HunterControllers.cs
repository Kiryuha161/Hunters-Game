using Hunters_Game.Common.Utils;
using Hunters_Game.Data;
using Hunters_Game.Models.Academies.Departments;
using Hunters_Game.Models.Characters;
using Hunters_Game.Models.Stat;
using Hunters_Game.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Diagnostics.Metrics;

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
                .Include(h => h.Rank)
                .Include(h => h.Level)
                .Include(h => h.TheoryDegree)
                .Include(h => h.Status)
                .Include(h => h.AcademicRank)
                .Include(h => h.AcademicDegree)
                .Include(h => h.PostGrade)
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
                .Include(h => h.Rank)
                .Include(h => h.Level)
                .Include(h => h.TheoryDegree)
                .Include(h => h.Status)
                .Include(h => h.AcademicRank)
                .Include(h => h.AcademicDegree)
                .Include(h => h.PostGrade)
                .FirstOrDefault(h => h.CharacterId == id);

            if (hunter == null)
            {
                return NotFound();
            }

            HunterViewModel hunterViewModel = new HunterViewModel()
            {
                Hunter = hunter,
                Departments = _database.Departments.ToList()
            };

            return View(hunterViewModel);
        }


        public IActionResult AddHunters(int count = 1)
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

        public IActionResult SignDepartment(int id, int departmentId)
        {
            Hunter hunter = _database.Hunters.Include(h => h.Department).FirstOrDefault(h => h.CharacterId == id);

            if (hunter == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                hunter.DepartmentId = departmentId;

                _database.SaveChanges();

                return RedirectToAction("GetHunterStats", new { id = hunter.CharacterId });
            }

            return RedirectToAction("GetHunterStats");
        }
    }
}
