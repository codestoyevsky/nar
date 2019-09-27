using System.ComponentModel.DataAnnotations;

namespace miniCMS.Data
{
   public class EmailTemplate : Base
   {
      [Required]
      public int PublicationID { get; set; }

      [Required]
      public string Code { get; set; }
   }
}
