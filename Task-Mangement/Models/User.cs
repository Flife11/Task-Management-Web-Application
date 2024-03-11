using System.ComponentModel.DataAnnotations;

namespace Task_Mangement.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [StringLength(50)]
        public string UserName { get; set; }               

    }
}
