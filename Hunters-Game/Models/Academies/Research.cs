using System.ComponentModel.DataAnnotations.Schema;

namespace Hunters_Game.Models.Academies
{
    public class Research
    {
        public int ResearchId { get; set; }
        public string ResearchName { get; set;}
        public string ResearchCategoryName { get; set;}
        public string Description { get; set;}
        
        public int CategoryResearchId { get; set; }
        [ForeignKey("CategoryResearchId")]
        public CategoryResearch CategoryResearch { get; set;}
    }
}
