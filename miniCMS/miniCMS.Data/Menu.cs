
using System.ComponentModel.DataAnnotations;

namespace miniCMS.Data
{
   public class Menu : Base
   {
      [Required]
      public string PublicationId { get; set; }

      public string Group { get; set; }
   }
}
