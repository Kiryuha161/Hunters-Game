using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hunters_Game.Models.Location
{
    public class Region
    {
        [Key]
        public int RegionId { get; set; }
        public string Name { get; set; }
        public int Disctription { get; set; }

        public Dictionary<string, bool> Monsters { get; set; }
        public Dictionary<string, bool> MonstersCount { get; set; }
    }
}
