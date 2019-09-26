
namespace miniCMS.Data
{
   public class ContactRequest : Base
   {
      public int PublicationId { get; set; }

      public string Name { get; set; }

      public string Surname { get; set; }

      public string Email { get; set; }

      public string Message { get; set; }
   }
}
