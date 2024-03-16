using Hunters_Game.Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace Hunters_Game.Models.Ranks
{
    public class Status
    {
        [Key]
        public int StatusId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public StatusType StatusType { get; set; }
    }
}
