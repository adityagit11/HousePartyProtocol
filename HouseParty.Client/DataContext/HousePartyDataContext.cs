using HouseParty.Client.Contracts.Feedbacks;
using HouseParty.Client.Contracts.Questions;
using Microsoft.EntityFrameworkCore;

namespace HouseParty.Client.DataContext
{
    public class HousePartyDataContext : DbContext
    {
        public HousePartyDataContext(DbContextOptions<HousePartyDataContext> options)
            : base(options)
        {
        }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Feedback> Feedbacks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("HouseParty");
        }
    }
}
