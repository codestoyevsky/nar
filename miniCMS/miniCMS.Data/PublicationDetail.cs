﻿using System.ComponentModel.DataAnnotations;

namespace miniCMS.Data
{
   public class PublicationDetail
   {
      [Required]
      public int PublicationId { get; set; }

      [Required]
      public int LanguageId { get; set; }

      [Required]
      public string Name { get; set; }

      [Required]
      public string Title { get; set; }
   }
}
