using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hunters_Game.Models.Location
{
    public class City
    {
        [Key]
        public int CityId { get; set; }
        public string Name { get; set; }
        public int Disctription { get; set; }
        [ForeignKey("Area")]
        public int AreaId { get; set; }
        public Area Area { get; set; }
        [ForeignKey("Territory")]
        public int TerritoryId { get; set; }
        public Territory Territory { get; set; }
        [ForeignKey("Region")]
        public int RegionId { get; set; }
        public Region Region { get; set; }
        public Dictionary<string, bool> Monsters { get; set; }
        public Dictionary<string, bool> MonstersCount { get; set; }

    }
}
