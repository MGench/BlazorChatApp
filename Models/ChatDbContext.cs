namespace BlazorChatApp.Models
{
    using Microsoft.EntityFrameworkCore;

    public class ChatDbContext : DbContext
    {
        public DbSet<ChatMessage> Messages { get; set; }

        public ChatDbContext(DbContextOptions<ChatDbContext> options) : base(options) { }
    }

}
