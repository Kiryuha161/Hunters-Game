using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hunters_Game.Models.Ranks
{
    public class Specialization
    {
        [Key]
        public int SpecializationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ParentId { get; set; }
        [ForeignKey("ParentId")]
        public Specialization Parent { get; set; }
        public ICollection<Specialization> Children { get; set; }
    }
}
