using Hunters_Game.Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace Hunters_Game.Models.Ranks
{
    public class Rank
    {
        [Key]
        public int RankId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public RanksType RanksType { get; set; }
    }
}
