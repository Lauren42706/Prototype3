using Microsoft.EntityFrameworkCore;
using Prototype2WebApi.Models;

namespace Prototype2WebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<UserInfoData> UserInfoDatas { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Acheivement> Acheivements { get; set; }
        public DbSet<Avatar> Avatars { get; set; }
        public DbSet<Calendar> Calendars { get; set; }
        public DbSet<Discussion> Discussions { get; set; }
        public DbSet<FamilyGroup> FamilyGroups { get; set; }
        public DbSet<FamilyStatus> FamilyStatuses { get; set; }
        public DbSet<Following> Followings { get; set; }
        public DbSet<PostedStory> PostedStories { get; set; }
        public DbSet<Sticker> Stickers { get; set; }
        public DbSet<Story> Stories { get; set; }
        public DbSet<Authentication> Authentications { get; set; }
    }
}
