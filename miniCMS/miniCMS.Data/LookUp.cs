using System.ComponentModel.DataAnnotations;

namespace miniCMS.Data
{
   public class Lookup : Base
   {
      [Required]
      public int PublicationId { get; set; }

      [Required]
      public string Code { get; set; }

      public string Group { get; set; }
   }
}
