using Hunters_Game.Data;
using Hunters_Game.Models.Location;
using Hunters_Game.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Hunters_Game.Controllers
{
    public class LocationController : Controller
    {
        private readonly HunterDbContext _database;

        public LocationController(HunterDbContext database)
        {
            _database = database;
        }

        public IActionResult GetDistrictDangerRatio(int? districtId)
        {
            int districtDangerRatio = _database.Districts.FirstOrDefault(h => h.DistrictId == districtId).DangerRatio;
            return View(districtDangerRatio);
        }

        public void GetCityDangerRatio(int? cityId)
        {
            int cityDangerRatio = 0;
            var districtsInCity = _database.Districts.Where(h => h.CityId == cityId).ToList();
            int districtInCityCount = districtsInCity.Count();

            for (int i = 0; i < districtInCityCount; i++)
            {
                cityDangerRatio += districtsInCity[i].DangerRatio;
            }

            _database.Cities.FirstOrDefault(h => h.CityId == cityId).DangerRatio = cityDangerRatio;
            _database.SaveChanges();
        }

        public void GetAreaDangerRatio(int? areaId)
        {
            int areaDangerRatio = 0;
            var citiesInArea = _database.Cities.Where(h => h.AreaId == areaId).ToList();
            int citiesInAreaCount = citiesInArea.Count();

            for (int i = 0; i < citiesInAreaCount; i++)
            {
                areaDangerRatio += citiesInArea[i].DangerRatio;
            }

            _database.Areas.FirstOrDefault(h => h.AreaId == areaId).DangerRatio = areaDangerRatio;
            _database.SaveChanges();
        }

        public void GetTerritoryDengerRatio(int? territoryId)
        {
            int territoryDengerRatio = 0;
            var areaInTerritory = _database.Areas.Where(h => h.TerritoryId == territoryId).ToList();
            int areaInTerritoryCount = areaInTerritory.Count();

            for (int i = 0; i < areaInTerritoryCount; i++)
            {
                territoryDengerRatio += areaInTerritory[i].DangerRatio;
            }

            _database.Territories.FirstOrDefault(h => h.TerritoryId == territoryId).DangerRatio = territoryDengerRatio;
            _database.SaveChanges();
        }

        public void GetRegionDangerRatio(int? regionId)
        {
            int regionDangerRatio = 0;
            var territoryInRegion = _database.Territories.Where(h => h.RegionId == regionId).ToList();
            int territoryInRegionCount = territoryInRegion.Count();

            for (int i = 0; i < territoryInRegionCount; i++)
            {
                regionDangerRatio += territoryInRegion[i].DangerRatio;
            }

            _database.Regions.FirstOrDefault(h => h.RegionId == regionId).DangerRatio = regionDangerRatio;
            _database.SaveChanges();
        }

        public ActionResult Index()
        {
            var cities = _database.Cities.ToList();
            foreach (var city in cities)
            {
                city.DangerRatio = _database.Districts
                  .Where(d => d.CityId == city.CityId)
                  .Sum(d => d.DangerRatio);
            }

            var areas = _database.Areas.ToList();
            foreach (var area in areas)
            {
                area.DangerRatio = _database.Cities
                  .Where(c => c.AreaId == area.AreaId)
                  .Sum(c => c.DangerRatio);
            }

            var territories = _database.Territories.ToList();
            foreach (var territory in territories)
            {
                territory.DangerRatio = _database.Areas
                  .Where(a => a.TerritoryId == territory.TerritoryId)
                  .Sum(a => a.DangerRatio);
            }

            var regions = _database.Regions.ToList();
            foreach (var region in regions)
            {
                region.DangerRatio = _database.Territories
                  .Where(t => t.RegionId == region.RegionId)
                  .Sum(t => t.DangerRatio);
            }

            _database.SaveChanges();

            var model = new LocationViewModel
            {
                Districts = _database.Districts.ToList(),
                Cities = cities,
                Areas = areas,
                Territories = territories,
                Regions = regions
            };

            return View(model);
        }
    }
}
