using System.ComponentModel.DataAnnotations;

namespace miniCMS.Data
{
   public class Language : Base
   {
      [Required]
      public string Name { get; set; }

      [Required]
      public string Culture { get; set; }
   }
}
