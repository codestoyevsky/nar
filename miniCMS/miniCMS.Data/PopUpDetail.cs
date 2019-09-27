using System.ComponentModel.DataAnnotations;

namespace miniCMS.Data
{
   public class PopUpDetail : Base
   {
      [Required]
      public int PopUpId { get; set; }

      [Required]
      public int LanguageId { get; set; }

      [Required]
      public string Title { get; set; }

      [Required]
      public string Text { get; set; } 
   }
}
