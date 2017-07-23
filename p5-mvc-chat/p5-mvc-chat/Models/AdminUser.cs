using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace p5_mvc_chat.Models
{
    public class AdminUser
    {
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }
        
        [DataType(DataType.Text)]
        [Display(Name = "作者")]
        public string UserName { get; set; }

        [Display(Name = "权限")]
        public List<AdminRight> AdminRights { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "IP地址")]
        public string Ip { get; set; }
    }
}