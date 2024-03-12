using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Schema;
using Hunters_Game.Models.Location;

namespace Hunters_Game.Models.Academies
{
    public class Academy
    {
        [Key]
        public int AcademyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DistrictAcademyId { get; set; }
        [ForeignKey("DistrictAcademyId")]
        public District DistrictAcademy { get; set; }
        public int TotalKnowledge { get; set; }
    }
}
