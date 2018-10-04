using KhssData.DomainModels.Attendance;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KhssData
{
   public class KhssContext:DbContext
    {
        public KhssContext(DbContextOptions options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<StudentClass> StudentClasses { get; set; }
    }
}
