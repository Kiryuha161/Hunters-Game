using Hunters_Game.Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace Hunters_Game.Models.Ranks
{
    public class AcademicRank
    {
        [Key]
        public int AcademicRankId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public AcademicRankType AcademicRankType { get; set; }
    }
}
