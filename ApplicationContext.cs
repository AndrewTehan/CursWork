using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace course_work
{
    internal class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("DbConnection")
        {
            Database.CreateIfNotExists();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<LikedMedia> LikedMedias { get; set; }
        public DbSet<HistoryMedia> HistorieMedias { get; set; }
        public DbSet<Сomment> Comments { get; set; }
        public DbSet<Discription> Discriptions { get; set; }
    }
}