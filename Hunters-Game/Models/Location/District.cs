using Hunters_Game.Models.Characters;
using Hunters_Game.Models.Location.LocationProperties;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hunters_Game.Models.Location
{
    public class District
    {
        [Key]
        public int DistrictId { get; set; }
        public string Name { get; set; }
        public string Desctription { get; set; }
      
        public int? CreatureId { get; set; }
        [ForeignKey("CreatureId")]
        public List<Creature> Creatures { get; set; }
        public int CityId { get; set; }
        [ForeignKey("CityId")]
        public City City { get; set; }
        public int DangerRatio { get; set; }
    }
}
