using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hunters_Game.Models.Location
{
    public class Territory
    {
        [Key]
        public int TerritoryId { get; set; }
        public string Name { get; set; }
        public int Disctription { get; set; }

        [ForeignKey("Region")]
        public int RegionId { get; set; }
        public Region Region { get; set; }
        public Dictionary<string, bool> Monsters { get; set; }
        public Dictionary<string, bool> MonstersCount { get; set; }
    }
}
