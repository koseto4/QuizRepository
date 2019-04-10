using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using QuizzApp.Models.EntityModels;

namespace QuizzApp.Data.MVC
{
    public class QuizzAppDbContext : DbContext
    {
        public QuizzAppDbContext(): base("DefaultConnection")
        {           
        }
        public DbSet<Choice> Choices { get; set; }
        public DbSet<Mode> Modes { get; set; }
        public DbSet<Question> Questions { get; set; }
    }
}
