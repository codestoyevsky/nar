using System.ComponentModel.DataAnnotations;

namespace miniCMS.Data
{
   public class Subsciption : Base
   {
      [Required]
      public int PublicationId { get; set; }

      [Required]
      public string Name { get; set; }

      [Required]
      public string Surname { get; set; }

      [Required]
      public string Email {get;set;}

      public bool Approved { get; set; }
   }
}
