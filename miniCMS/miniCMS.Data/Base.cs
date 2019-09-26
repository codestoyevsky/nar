using System;

namespace miniCMS.Data
{
   public class Base
   {
      public int Id { get; set; } 

      public DateTime CreatedDate { get; set; }

      public DateTime ModifiedDate { get; set; }

      public bool Deleted { get; set; }
   }
}
