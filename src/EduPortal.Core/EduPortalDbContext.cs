using EduPortal.Core.Entities;
using EduPortal.Core.EntityFrameworkConfig;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduPortal.Core
{
    public class EduPortalDbContext : DbContext
    {
        public EduPortalDbContext()
            : base("name=EduPortalDefaultConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           modelBuilder.Configurations.Add(new CourseConfiguration());
        }
    }
}
