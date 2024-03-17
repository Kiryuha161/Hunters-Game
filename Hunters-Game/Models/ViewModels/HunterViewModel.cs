using Hunters_Game.Models.Academies.Departments;
using Hunters_Game.Models.Characters;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Hunters_Game.Models.ViewModels
{
    public class HunterViewModel
    {
        public Hunter Hunter { get; set; }
        public IEnumerable<Department> Departments { get; set; }
    }
}
