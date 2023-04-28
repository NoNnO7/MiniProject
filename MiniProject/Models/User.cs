using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MiniProject.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Menu")]
        public string Menu { get; set; }
        [DisplayName("Option")]
        public string Option { get; set; }
        [DisplayName("Location")]
        public string Location { get; set; }
    }
}
