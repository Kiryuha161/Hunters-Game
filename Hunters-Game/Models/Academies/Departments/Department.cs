using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hunters_Game.Models.Academies.Departments
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int HuntersCount { get; set; }
        //public int SquadsCount { get; set; }
        //public List<Squad> Squads { get; set; }

    }
}
