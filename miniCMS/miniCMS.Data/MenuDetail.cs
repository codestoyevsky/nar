using System.ComponentModel.DataAnnotations;

namespace miniCMS.Data
{
   public class MenuDetail
   {
      [Required]
      public int MenuId { get; set; }

      [Required]
      public int LanguageId { get; set; }

      [Required]
      public string Title { get; set; }

      public string Text { get; set; }

      [Required]
      public int ParentId { get; set; }
   }
}
