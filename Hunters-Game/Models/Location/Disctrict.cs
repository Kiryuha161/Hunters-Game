using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hunters_Game.Models.Location
{
    public class Disctrict
    {
        [Key]
        public int DisctrictId { get; set; }
        public string Name { get; set; }
        public int Disctription { get; set; }
        [ForeignKey("City")]
        public int CityId { get; set; }
        public City City { get; set; }
        [ForeignKey("Area")]
        public int AreaId { get; set; }
        public Area Area { get; set;  }
        [ForeignKey("Territory")]
        public int TerritoryId { get; set; }
        public Territory Territory { get; set; }
        [ForeignKey("Region")]
        public int RegionId { get; set; }
        public Region Region { get; set; }
        public Dictionary<string, string> EnvironmentPropertiesDiscription { get; set; }
        public Dictionary<string, bool> EnvironmentPropertiesBoolean { get; set; }
        public Dictionary<string, int> EnvironmentPropertiesCount { get; set; }
        public Dictionary<string, bool> Monsters { get; set; }
        public Dictionary<string, bool> MonstersCount { get; set; }

    }
}
