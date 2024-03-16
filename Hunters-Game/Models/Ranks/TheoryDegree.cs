using Hunters_Game.Common.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hunters_Game.Models.Ranks
{
    public class TheoryDegree
    {
        [Key]
        public int TheoryDegreeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TheoryDegreeType TheoryType { get; set; }
    }
}
