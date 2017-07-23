using System.ComponentModel.DataAnnotations;

namespace p5_mvc_chat.Models
{
    public class AdminRight
    {
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }
        
        [DataType(DataType.Text)]
        [Display(Name = "权限")]
        public string Name { get; set; }

        [Display(Name = "启用")]
        public bool Enabled { get; set; }
    }
}