namespace miniCMS.Data
{
   public class MenuDetail
   {
      public int MenuId { get; set; }

      public int LanguageId { get; set; }

      public string Title { get; set; }

      public string Text { get; set; }

      public int ParentId { get; set; }
   }
}
