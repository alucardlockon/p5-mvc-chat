using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace p5_mvc_chat.Models
{
    [Table("p5_chat")]
    public class Chat
    {
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }
        
        [DataType(DataType.DateTime)]
        [Display(Name = "时间")]
        public DateTime Createtime { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "作者")]
        public string Author { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "内容")]
        public string Msg { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "头像")]
        public string Usrimg { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "IP地址")]
        public string Ip { get; set; }
    }
}