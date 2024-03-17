using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hunters_Game.Models.Academies.Departments
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [Display(Name = "Название департамента")]
        public string Name { get; set; }
        [Display(Name = "Описание департамента")]
        public string Description { get; set; }
        [Display(Name = "Количество охотников")]
        public int HuntersCount { get; set; }
        [Display(Name = "Название должности")]
        public string PostName { get; set; }
        //public int SquadsCount { get; set; }
        //public List<Squad> Squads { get; set; }

    }
}
