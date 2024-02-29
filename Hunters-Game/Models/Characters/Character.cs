using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hunters_Game.Models.Characters
{
    public class Character
    {
        [Key]
        public int CharacterId { get; set; }
        [Display(Name = "Тип")]
        public string Type { get; set; }
        [Display(Name = "Деятельность")]
        public string Activity { get; set; }
        [Display(Name = "Имя")]
        public string FirstName { get; set; }
        [Display(Name = "Фамилия")]
        public string SecondName { get; set; }
        [Display(Name = "Отчество")]
        public string MiddleName { get; set; }
        [Display(Name = "Пол")]
        public bool Gender { get; set; }
        [Display(Name = "Возраст")]
        public int Age { get; set; }
        [Display(Name = "Дата рождения")]
        public DateTime Birthday { get; set; }
    }
}
