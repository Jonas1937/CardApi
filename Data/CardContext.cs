using CardApi.models;
using Microsoft.EntityFrameworkCore;

namespace CardApi.Data{
    public class CardContext: DbContext{
        public DbSet<Card> Cards { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder opt)
        {
            opt.UseInMemoryDatabase("CardsDB");
        }

    }
}