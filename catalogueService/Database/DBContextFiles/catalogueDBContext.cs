﻿using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using catalogueService.Database.DBsets;

namespace catalogueService.Database.DBContextFiles
{
    public class catalogueDBContext : DbContext
    {
        public catalogueDBContext(DbContextOptions<catalogueDBContext> options) : base(options)
        {

        }
        public DbSet<category> Categories { get; set; }
        public DbSet<customer> Customers { get; set; }
        public DbSet<job> Jobs { get; set; }
        public DbSet<withdrawnStudents> withdrawnStudents { get; set; }
        public DbSet<student> Students { get; set; }
        public DbSet<admin> Admins { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<location> Locations { get; set; }
        public DbSet<manager> Managers { get; set; }
        public DbSet<Fee> Fees { get; set; }
        public DbSet<type> Types { get; set; }
        public DbSet<users> Users { get; set; }
        public DbSet<orders> orders { get; set; }
        public DbSet<sales> sales { get; set; }
        
    }
}