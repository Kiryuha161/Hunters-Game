using Hunters_Game.Models.Characters;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hunters_Game.Models.Ranks
{
    public class HunterSpecialization
    {
            [Key]
            public int HunterSpecializationId { get; set; }
            public int SpecializationId { get; set; }

            [ForeignKey("SpecializationId")]
            public Specialization Specialization { get; set; }
            public List<Hunter> Hunters { get; set; }

    }
}
