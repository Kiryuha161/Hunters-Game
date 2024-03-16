using Hunters_Game.Common.Enums;
using Hunters_Game.Models.Academies.Departments;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hunters_Game.Models.Ranks
{
    public class PostGrade
    {
        [Key]
        public int PostGradeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public PostGradeType PostGradeType { get; set; }
    }
}
