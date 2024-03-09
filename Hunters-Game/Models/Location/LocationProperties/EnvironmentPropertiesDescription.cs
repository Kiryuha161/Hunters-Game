using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hunters_Game.Common.Enums;

namespace Hunters_Game.Models.Location.LocationProperties
{
    public class EnvironmentPropertiesDescription
    {
        [Key]
        public int PropertiesDescriptionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public EnvironmentPropetiesDescriptionsEnum Type { get; set; }
        public int Districtid { get; set; }
        [ForeignKey("Districtid")]
        public District District { get; set; }

    }
}
