using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Hunters_Game.Models.Characters;

namespace Hunters_Game.Models.Location
{
    public class Area
    {
        [Key]
        public int AreaId { get; set; }
        public string Name { get; set; }
        public string Desctription { get; set; }

        public int TerritoryId { get; set; }
        [ForeignKey("TerritoryId")]
        public Territory Territory { get; set; }
        public int? CreatureId { get; set; }
        [ForeignKey("CreatureId")]
        public List<Creature> Creatures { get; set; }
        public int DangerRatio { get; set; }
    }
}
