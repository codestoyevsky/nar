﻿namespace miniCMS.Data
{
   public class Subsciption : Base
   {
      public int PublicationId { get; set; }

      public string Name { get; set; }

      public string Surname { get; set; }

      public string Email {get;set;}

      public bool Approved { get; set; }
   }
}
