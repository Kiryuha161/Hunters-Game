using Hunters_Game.Common.Utils;
using Hunters_Game.Models.Stat;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hunters_Game.Models.Characters
{
    public class Hunter : Character
    {
        [ForeignKey("HunterStats")]
        public int HunterStatsId { get; set; }
        public HunterStat HunterStats { get; set; }

        public void GetRandomInfo()
        {
            HunterStat hunterStat = new HunterStat();

            Random random = new Random();

            if (random.Next(0, 101) < 65)
            {
                FirstName = Utils.GetName("rus", "male");
                SecondName = Utils.GetSurname("rus", "male");
                Gender = true;
            } 
            else
            {
                FirstName = Utils.GetName("rus", "female");
                SecondName = Utils.GetSurname("rus", "male");
                Gender = false;
            }
            
            Activity = "Охотник";
            Birthday = Utils.GetRandomDate(1970, 2002);
            Age = Utils.GetAge(Birthday, Utils.GetCurrentDate());
            MiddleName = "test";
            Type = "Человек";
            HunterStats = hunterStat;
            hunterStat.RandomLowLevelSign(Age, Gender);
        }
    }
}
