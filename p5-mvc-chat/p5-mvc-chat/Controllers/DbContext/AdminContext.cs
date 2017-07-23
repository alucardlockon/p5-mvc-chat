using System.Data.Entity;
using p5_mvc_chat.Models;

namespace p5_mvc_chat.Controllers.DbContext
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class AdminContext:System.Data.Entity.DbContext
    {
        public DbSet<AdminUser> AdminUsers { get; set; }
        public DbSet<AdminRight> AdminRights { get; set; }
    }
}