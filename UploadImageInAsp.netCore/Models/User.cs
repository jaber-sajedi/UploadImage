using System.ComponentModel.DataAnnotations;

namespace UploadImageInAsp.netCore.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string ImageUrl { get; set; }

    }
}
