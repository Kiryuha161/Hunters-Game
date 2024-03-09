using Hunters_Game.Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace Hunters_Game.Models.Characters
{
    public class Creature
    {
        [Key]
        public int CreatureId { get; set; }
        public string Name { get; set; }
        public Creatures Type { get; set; }
        public bool IsPresent { get; set; }
        public int Count { get; set; }
    }
}
