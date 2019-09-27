
using System.ComponentModel.DataAnnotations;

namespace miniCMS.Data
{
   public class ContactRequest : Base
   {
      [Required]
      public int PublicationId { get; set; }

      [Required]
      public string Name { get; set; }

      [Required]
      public string Surname { get; set; }

      [Required]
      public string Email { get; set; }

      [Required]
      public string Message { get; set; }

      public bool Read { get; set; }
   }
}
