using System.ComponentModel.DataAnnotations;

namespace miniCMS.Data
{
   public class AttachmentDetail : Base
   {
      [Required]
      public int AttachmentId { get; set; }

      public string Description { get; set; }
   }
}
