using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Task_Mangement.Models
{
    public class Task
    {
        [Key]
        public int TaskId { get; set; }
        [Required]
        [MaxLength(100)]
        public string TaskTitle { get; set; }

        [DefaultValue("false")]
        public bool TaskStatus { get; set; }

        [Required]
        [MaxLength(500)]
        public string TaskDescription { get; set; }

        [Required]
        public DateTime TaskDueDate { get; set; }

    }
}
