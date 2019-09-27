using System.ComponentModel.DataAnnotations;

namespace miniCMS.Data
{
   public class LookupDetail : Base
   {
      [Required]
      public int LanguageId { get; set; }

      [Required]
      public int LookupId { get; set; }

      [Required]
      public int Text { get; set; }
   }
}
