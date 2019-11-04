using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication13.Models
{
    public class SDbContext:DbContext
    {
        public SDbContext(DbContextOptions<SDbContext> options):base(options)
        {
            Database.Migrate();
        }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<CourseType>  Types { get; set; }
        public virtual DbSet<CourseName>  Courses { get; set; }
        public virtual DbSet<CourseTime>  Times { get; set; }


        
        public virtual DbQuery<Response> Responses { get; set; }


    }
}
