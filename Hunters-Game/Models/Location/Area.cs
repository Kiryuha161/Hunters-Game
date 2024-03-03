using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hunters_Game.Models.Location
{
    public class Area
    {
        [Key]
        public int AreaId { get; set; }
        public string Name { get; set; }
        public int Disctription { get; set; }
       
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
