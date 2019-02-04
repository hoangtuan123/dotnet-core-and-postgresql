

using Microsoft.EntityFrameworkCore;
namespace CollectMyNewFeedFacebook.Models
{
    public class NewFeedCollectionContext : DbContext
    {
        public NewFeedCollectionContext(DbContextOptions<NewFeedCollectionContext> options) : base(options)
        {
        }
        public DbSet<NewFeed> NewFeeds { get; set; }

    }
}