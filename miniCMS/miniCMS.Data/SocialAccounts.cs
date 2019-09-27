using System.ComponentModel.DataAnnotations;

namespace miniCMS.Data
{
   public class SocialAccounts : Base
   {
      [Required]
      public int PublicationId { get; set; }

      public string Facebook { get; set; }

      public string Twitter { get; set; }

      public string LinkedIn { get; set; }

      public string Medium { get; set; }
   }
}
