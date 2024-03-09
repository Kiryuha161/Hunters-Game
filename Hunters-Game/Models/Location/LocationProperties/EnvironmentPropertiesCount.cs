using Hunters_Game.Common.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hunters_Game.Models.Location.LocationProperties
{
    public class EnvironmentPropertiesCount
    {
        [Key]
        public int PropertiesCountId { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public EnvironmentPropertiesCountEnum Type { get; set; }
        public int Districtid { get; set; }
        [ForeignKey("Districtid")]
        public District District { get; set; }
    }
}
