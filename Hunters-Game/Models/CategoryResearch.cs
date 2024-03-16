using Hunters_Game.Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace Hunters_Game.Models
{
    public class CategoryResearch
    {
        [Key]
        public int CategoryResearchId { get; set; }
        public string CategoryName { get; set; }
        public string SubCategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public string SubCategoryDescription { get; set; }
        public ResearchesCategoryType ResearchesCategoryType { get; set; }
        public ResearchSubCategoryType ResearchSubCategoryType { get; set; }
    }
}
