using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace p5_mvc_chat.Models
{
    [Table("p5_admin_right")]
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
        [Display(Name = "创建时间")]
        public DateTime Create { get; set; }
    }
}