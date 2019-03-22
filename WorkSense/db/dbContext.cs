using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.models;

namespace TimeTracker.db
{
    class ttContext: DbContext
    {
        public ttContext() : base("ttContext")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var sqliteConnectionInitializer = new MyDbContextInitializer(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);
        }

        public DbSet<trackable> Trackables { get; set; }
        public DbSet<track> Tracks { get; set; }
    }

    class MyDbContextInitializer : SqliteDropCreateDatabaseAlways<ttContext>
    {
        public MyDbContextInitializer(DbModelBuilder modelBuilder)
            : base(modelBuilder) { }

        protected override void Seed(ttContext context)
        {
            context.Set<trackable>().Add(new trackable {
                fileName = "C:\\Program Files (x86)\\Microsoft Visual Studio\\2017\\Community\\Common7\\IDE\\devenv.exe",
                titleRegex = "*"
            });
        }
    }
}
