﻿using System.ComponentModel.DataAnnotations;

namespace miniCMS.Data
{
   class PublicationUser : Base
   {
      [Required]
      public int UserId { get; set; }

      [Required]
      public int PublicationId { get; set; }
   }
}
