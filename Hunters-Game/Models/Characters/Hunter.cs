using Hunters_Game.Common.Utils;
using Hunters_Game.Models.Academies;
using Hunters_Game.Models.Academies.Departments;
using Hunters_Game.Models.Location;
using Hunters_Game.Models.Ranks;
using Hunters_Game.Models.Stat;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace Hunters_Game.Models.Characters
{
    public class Hunter : Character
    {
        [ForeignKey("HunterStats")]
        public int HunterStatsId { get; set; }
        public HunterStat HunterStats { get; set; }
        public int RegionId { get; set; }
        [ForeignKey("RegionId")]
        public Region Region { get; set; }
        public int TerritoryId { get; set; }
        [ForeignKey("TerritoryId")]
        public Territory Territory { get; set; }
        public int AreaId { get; set; }
        [ForeignKey("AreaId")]
        public Area Area { get; set; }
        public int CityId { get; set; }
        [ForeignKey("CityId")]
        public City City { get; set; }
        public int DisсtrictId { get; set; }
        [ForeignKey("DisсtrictId")]
        public District Disсtrict { get; set; }
        public int CurrentLocationId { get; set; }
        [ForeignKey("CurrentLocationId")]
        public District CurrentLocation { get; set; }

        public int AcademyId { get; set; }
        [ForeignKey("AcademyId")]
        public Academy Academy { get; set; }
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }
        public int RankId { get; set; }
        [ForeignKey("RankId")]
        public Rank Rank { get; set; }
        public int LevelId { get; set; }
        [ForeignKey("LevelId")]
        public Level Level { get; set; }
        public int TheoryDegreeId { get; set; }
        [ForeignKey("TheoryDegreeId")]
        public TheoryDegree TheoryDegree { get; set; }
        public int AcademicRankId { get; set; }
        [ForeignKey("AcademicRankId")]
        public AcademicRank AcademicRank { get; set; }
        public int AcademicDegreeId { get; set; }
        [ForeignKey("AcademicDegreeId")]
        public AcademicDegree AcademicDegree { get; set; }
        public int PostGradeId { get; set; }
        [ForeignKey("PostGradeId")]
        public PostGrade PostGrade { get; set; }
        public int StatusId { get; set; }
        [ForeignKey("StatusId")]
        public Status Status { get; set; }
        public float Rate { get; set; }
        public int Stage { get; set; }
        public DateTime StartHunt { get; set; }


        public void GetRandomInfo()
        {
            HunterStat hunterStat = new HunterStat();
            Random random = new Random();
            Dictionary<int, List<int>> regionTerritoryMap = new Dictionary<int, List<int>>()
            {
                { 1, new List<int>() { 5 } },
                { 2, new List<int>() { 1, 2, 3, 4} }
            };
            Dictionary<int, List<int>> territoryAreaMap = new Dictionary<int, List<int>>()
            {
                { 1, new List<int>() { 1, 2} },
                { 2, new List<int>() { 4 } },
                { 3, new List<int>() { 5 } },
                { 4, new List<int>() { 6 } },
                { 5, new List<int>() { 3 } }
            };
            Dictionary<int, List<int>> areaCityMap = new Dictionary<int, List<int>>
            {
                { 1, new List<int>() {1, 2 } },
                { 2, new List<int>() { 3 } },
                { 3, new List<int>() { 4 } },
                { 4, new List<int>() { 5 } },
                { 5, new List<int>() { 6 } },
                { 6, new List<int>() { 7 } }
            };
            Dictionary<int, List<int>> cityDistrictsMap = new Dictionary<int, List<int>>
            {
                { 1, new List<int>() { 3, 4 } },
                { 2, new List<int>() { 1, 2} },
                { 3, new List<int>() { 5, 6} },
                { 4, new List<int>() { 7, 8} },
                { 5, new List<int>() { 9, 10} },
                { 6, new List<int>() { 11, 12} },
                { 7, new List<int>() { 13, 14} }
            };

            if (random.Next(0, 101) < 65)
            {
                FirstName = Utils.GetName("rus", "male");
                SecondName = Utils.GetSurname("rus", "male");
                Gender = true;
            } 
            else
            {
                FirstName = Utils.GetName("rus", "female");
                SecondName = Utils.GetSurname("rus", "female");
                Gender = false;
            }
            
            Activity = "Охотник";
            Birthday = Utils.GetRandomDate(1970, 2002);
            Age = Utils.СalculateDateDifference(Birthday, Utils.GetCurrentDate());
            MiddleName = "test";
            Type = "Человек";
            RegionId = 2;

            List<int> territories = regionTerritoryMap.FirstOrDefault(x => x.Key == RegionId).Value;

            TerritoryId = territories[random.Next(territories.Count)];

            List<int> areas = territoryAreaMap.FirstOrDefault(x => x.Key == TerritoryId).Value;

            AreaId = areas[random.Next(areas.Count)];
           
            List<int> cities = areaCityMap.FirstOrDefault(x => x.Key == AreaId).Value;

            CityId = cities[random.Next(cities.Count)];

            List<int> districts = cityDistrictsMap.FirstOrDefault(x => x.Key == CityId).Value;

            DisсtrictId = districts[random.Next(districts.Count)];
            CurrentLocationId = 5;

            hunterStat.RandomLowLevelSign(Age, Gender, CityId);
            HunterStats = hunterStat;
            AcademyId = 1;
            DepartmentId = 3;
            RankId = 1;
            LevelId = 1;
            AcademicDegreeId = 4;
            AcademicRankId = 5;
            TheoryDegreeId = 2;
            StatusId = 1;
            PostGradeId = 1;
            StartHunt = Utils.GetCurrentDate();
            Stage = Utils.СalculateDateDifference(StartHunt, Utils.GetCurrentDate());
        }
    }
}
