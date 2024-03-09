using Hunters_Game.Models.Characters;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hunters_Game.Models.Location
{
    public class City
    {
        [Key]
        public int CityId { get; set; }
        public string Name { get; set; }
        public string Desctription { get; set; }
        public int AreaId { get; set; }
        [ForeignKey("AreaId")]
        public Area Area { get; set; }
        public int? CreatureId { get; set; }
        [ForeignKey("CreatureId")]
        public List<Creature> Creatures { get; set; }
        public int DangerRatio { get; set; }

    }
}
