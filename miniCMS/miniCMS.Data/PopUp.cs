using System;
using System.ComponentModel.DataAnnotations;

namespace miniCMS.Data
{
   public class PopUp
   {
      [Required]
      public int PublicationId { get; set; } 

      public DateTime FromDate { get; set; }

      public DateTime ToDate { get; set; }

      public string Link { get; set; }
   }
}
