using System.ComponentModel.DataAnnotations;

namespace miniCMS.Data
{
   public class User : Base
   {
      [Required]
      public string Name { get; set; }

      [Required]
      public string Surname { get; set; }

      [Required]
      public string Email { get; set; }

      public string Photo { get; set; }

      [Required]
      public string Password { get; set; }
   }
}
