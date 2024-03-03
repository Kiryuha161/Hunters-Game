using System.ComponentModel.DataAnnotations;

namespace Hunters_Game.Models
{
    public class Mail
    {
        [Key]
        public int MailId { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string Sender { get; set; }
        public bool IsRead { get; set; }
        public DateTime SendDate { get; set; }
    }
}
