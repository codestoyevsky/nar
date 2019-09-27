using System.ComponentModel.DataAnnotations;

namespace miniCMS.Data
{
   public class Content : Base
   {
      [Required]
      public int PublicationId { get; set; }

      public string Image { get; set; }

      public string FaeturedImage { get; set; }

      public bool Published { get; set; }

      public bool Faetured { get; set; }
   }
}
