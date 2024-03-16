using Hunters_Game.Common.Enums;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hunters_Game.Models.Ranks
{
    public class AcademicDegree
    {
        [Key]
        public int AcademicDegreeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public AcademicDegreeType AcademicDegreeType { get; set; }

    }
}
