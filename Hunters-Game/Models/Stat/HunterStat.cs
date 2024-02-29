using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hunters_Game.Models.Stat
{
    public class HunterStat : CharacterStat
    {
        [ForeignKey("Hunters")]
        public int HunterId { get; set; }
        [Display(Name = "Знания охотничьего ремесла")]
        public int HunterKnowledge { get; set; }

        public void RandomLowLevelSign(int age, bool isMan)
        {
            Random random = new Random();

            if (age > 40)
            {
                if (isMan)
                {
                    this.Acuracy = random.Next(10, 30);
                    this.Attentivines = random.Next(10, 30);
                    this.Brave = random.Next(10, 30);
                    this.Charisma = random.Next(10, 30);
                    this.Endurance = random.Next(10, 20);
                    this.Fortuna = random.Next(10, 30);
                    this.GeneralKnowledge = random.Next(10, 40);
                    this.Health = random.Next(10, 20);
                    this.HunterKnowledge = random.Next(10, 30);
                    this.Intellegence = random.Next(10, 40);
                    this.Leadership = random.Next(10, 30);
                    this.MagicEnegyControl = random.Next(0, 10);
                    this.MagicEnergy = random.Next(1, 10);
                    this.Memory = random.Next(10, 20);
                    this.Reaction = random.Next(10, 20);
                    this.SpeedAttack = random.Next(10, 20);
                    this.SpeedMove = random.Next(10, 20);
                    this.SpeedThinking = random.Next(10, 30);
                    this.Strength = random.Next(10, 30);
                    this.TechnicalSkill = random.Next(10, 40);
                    this.SurvivalSkill = random.Next(10, 40);
                    this.WillPower = random.Next(0, 40);
                } 
                else
                {
                    this.Acuracy = random.Next(10, 30);
                    this.Attentivines = random.Next(10, 40);
                    this.Brave = random.Next(10, 30);
                    this.Charisma = random.Next(10, 30);
                    this.Endurance = random.Next(10, 20);
                    this.Fortuna = random.Next(10, 30);
                    this.GeneralKnowledge = random.Next(10, 40);
                    this.Health = random.Next(10, 15);
                    this.HunterKnowledge = random.Next(10, 30);
                    this.Intellegence = random.Next(10, 40);
                    this.Leadership = random.Next(10, 30);
                    this.MagicEnegyControl = random.Next(0, 10);
                    this.MagicEnergy = random.Next(1, 10);
                    this.Memory = random.Next(10, 20);
                    this.Reaction = random.Next(10, 20);
                    this.SpeedAttack = random.Next(10, 20);
                    this.SpeedMove = random.Next(10, 20);
                    this.SpeedThinking = random.Next(10, 30);
                    this.Strength = random.Next(10, 20);
                    this.TechnicalSkill = random.Next(10, 40);
                    this.SurvivalSkill = random.Next(10, 40);
                    this.WillPower = random.Next(0, 40);
                }
            }
            else
            {
                if (isMan)
                {
                    this.Acuracy = random.Next(10, 30);
                    this.Attentivines = random.Next(10, 30);
                    this.Brave = random.Next(10, 30);
                    this.Charisma = random.Next(10, 30);
                    this.Endurance = random.Next(10, 30);
                    this.Fortuna = random.Next(10, 30);
                    this.GeneralKnowledge = random.Next(10, 30);
                    this.Health = random.Next(10, 30);
                    this.HunterKnowledge = random.Next(10, 30);
                    this.Intellegence = random.Next(10, 30);
                    this.Leadership = random.Next(10, 30);
                    this.MagicEnegyControl = random.Next(0, 10);
                    this.MagicEnergy = random.Next(1, 10);
                    this.Memory = random.Next(10, 30);
                    this.Reaction = random.Next(10, 30);
                    this.SpeedAttack = random.Next(10, 30);
                    this.SpeedMove = random.Next(10, 30);
                    this.SpeedThinking = random.Next(10, 30);
                    this.Strength = random.Next(10, 30);
                    this.TechnicalSkill = random.Next(10, 40);
                    this.SurvivalSkill = random.Next(10, 30);
                    this.WillPower = random.Next(0, 30);
                }
                else
                {
                    this.Acuracy = random.Next(10, 30);
                    this.Attentivines = random.Next(10, 40);
                    this.Brave = random.Next(10, 30);
                    this.Charisma = random.Next(10, 30);
                    this.Endurance = random.Next(10, 20);
                    this.Fortuna = random.Next(10, 30);
                    this.GeneralKnowledge = random.Next(10, 40);
                    this.Health = random.Next(10, 20);
                    this.HunterKnowledge = random.Next(10, 30);
                    this.Intellegence = random.Next(10, 30);
                    this.Leadership = random.Next(10, 30);
                    this.MagicEnegyControl = random.Next(0, 10);
                    this.MagicEnergy = random.Next(1, 10);
                    this.Memory = random.Next(10, 30);
                    this.Reaction = random.Next(10, 30);
                    this.SpeedAttack = random.Next(10, 30);
                    this.SpeedMove = random.Next(10, 30);
                    this.SpeedThinking = random.Next(10, 30);
                    this.Strength = random.Next(10, 20);
                    this.TechnicalSkill = random.Next(10, 40);
                    this.SurvivalSkill = random.Next(10, 40);
                    this.WillPower = random.Next(0, 40);
                }
            }
           
        }
    }
}
