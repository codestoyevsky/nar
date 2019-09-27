namespace miniCMS.Data
{
   public class Attachment : Base
   {
      public int PublicationId { get; set; }

      public string Name { get; set; }

      public string Extension { get; set; }

      public string Path { get; set; }
   }
}
