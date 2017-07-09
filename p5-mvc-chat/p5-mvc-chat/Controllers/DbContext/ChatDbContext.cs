using System.Data.Entity;
using p5_mvc_chat.Models;

namespace p5_mvc_chat.Controllers.ChatDbContext
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class ChatDbContext:DbContext
    {
        public DbSet<Chat> Chats { get; set; }
    }
}