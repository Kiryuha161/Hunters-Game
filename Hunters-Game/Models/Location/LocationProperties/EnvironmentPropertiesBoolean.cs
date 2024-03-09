using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hunters_Game.Common.Enums;
using Hunters_Game.Models.Location;

namespace Hunters_Game.Models.Location.LocationProperties
{
    public class EnvironmentPropertiesBoolean
    {
        [Key]
        public int PropertiesBooleanId { get; set; }
        public string Name { get; set; }
        public bool isPresent { get; set; }
        public EnvironmentPropertiesBooleanEnum Type { get; set; }
        public int Districtid { get; set; }
        [ForeignKey("Districtid")]
        public District District { get; set; }
    }
}
