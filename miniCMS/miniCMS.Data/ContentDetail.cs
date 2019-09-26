namespace miniCMS.Data
{
   public class ContentDetail : Base
   {
      public int ContentId { get; set; }

      public int LanguageId { get; set; }

      public string Title { get; set; }

      public string Description { get; set; }

      public string Text { get; set; } 
   }
}
