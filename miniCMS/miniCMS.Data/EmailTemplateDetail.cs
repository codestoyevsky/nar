using System.ComponentModel.DataAnnotations;

namespace miniCMS.Data
{
   public class EmailTemplateDetail : Base
   {
      [Required]
      public int EmailTemplateId { get; set; }

      [Required]
      public int LanguageId { get; set; }

      [Required]
      public string Subject { get; set; }

      [Required]
      public string Body { get; set; }
   }
}
