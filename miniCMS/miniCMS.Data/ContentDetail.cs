using System.ComponentModel.DataAnnotations;

namespace miniCMS.Data
{
   public class ContentDetail : Base
   {
      [Required]
      public int ContentId { get; set; }

      [Required]
      public int LanguageId { get; set; }

      [Required]
      public string Title { get; set; }

      [Required]
      public string Description { get; set; }

      [Required]
      public string Text { get; set; } 
   }
}
