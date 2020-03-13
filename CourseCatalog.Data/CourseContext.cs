﻿using System;
using System.Collections.Generic;
using System.Text;
using CourseCatalog.Domain;
using Microsoft.EntityFrameworkCore;

namespace CourseCatalog.Data
{
    public class CourseContext: DbContext
    {

        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data Source=.;initial catalog=CoursesDemo;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;Application Name=Courses";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseLevel>().ToTable("CourseLevels"); 
            modelBuilder.Entity<CourseType>().ToTable("CourseTypes"); 
            modelBuilder.Entity<Grade>().ToTable("Grades"); 
        }
    }
}
