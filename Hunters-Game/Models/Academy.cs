using System.ComponentModel.DataAnnotations;
using System.Xml.Schema;
using Hunters_Game.Models.Location;

namespace Hunters_Game.Models
{
    public class Academy
    {
        [Key]
        public int AcademyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Region Region { get; set; }
        public int TotalKnowledge { get; set; }


    }
}
