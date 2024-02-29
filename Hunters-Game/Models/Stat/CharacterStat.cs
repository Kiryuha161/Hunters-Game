using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hunters_Game.Models.Stat
{
    public class CharacterStat
    {
        [Key]
        public int CharacterStatId { get; set; }
        [Display(Name = "Здоровье")]
        public int Health { get; set; }
        [Display(Name = "Сила")]
        public int Strength { get; set; }
        [Display(Name = "Выносливость")]
        public int Endurance { get; set; }
        [Display(Name = "Точность")]
        public int Acuracy { get; set; }
        [Display(Name = "Интеллект")]
        public int Intellegence { get; set; }
        [Display(Name = "Реакция")]
        public int Reaction { get; set; }
        [Display(Name = "Скорость атаки")]
        public int SpeedAttack { get; set; }
        [Display(Name = "Скорость передвижения")]
        public int SpeedMove { get; set; }
        [Display(Name = "Скорость мышления")]
        public int SpeedThinking { get; set; }
        [Display(Name = "Харизма")]
        public int Charisma { get; set; }
        [Display(Name = "Лидерство")]
        public int Leadership { get; set; }
        [Display(Name = "Сила воли")]
        public int WillPower { get; set; }
        [Display(Name = "Смелость")]
        public int Brave { get; set; }
        [Display(Name = "Внимательность")]
        public int Attentivines { get; set; }
        [Display(Name = "Память")]
        public int Memory { get; set; }
        [Display(Name = "Общие знания")]
        public int GeneralKnowledge { get; set; }
        [Display(Name = "Удачливость")]
        public int Fortuna { get; set; }
        [Display(Name = "Магическая энергия")]
        public int MagicEnergy { get; set; }
        [Display(Name = "Контроль магической энергии")]
        public int MagicEnegyControl { get; set; }
        [Display(Name = "Навыки выживания")]
        public int SurvivalSkill { get; set; }
        [Display(Name = "Технические навыки")]
        public int TechnicalSkill { get; set; }
    }
}
