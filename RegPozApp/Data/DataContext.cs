using Microsoft.EntityFrameworkCore;
using RegPozApp.Models;

namespace RegPozApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Form> Forms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Form>().HasData(
                new Form()
                {
                    Id = 1,
                    Name = "Form #1",
                    IsDeleted = false
                });

            modelBuilder.Entity<Question>().HasData(
                new Question()
                {
                    Id = 1,
                    Name = "Reikia atlikti rangos darbus",
                    AnswerId = 1,
                    FormId = 1,
                    IsDeleted = false
                },
                new Question()
                {
                    Id = 2,
                    Name = "Rangos darbus atliks",
                    AnswerId = 3,
                    FormId = 1,
                    IsDeleted = false
                },
                new Question()
                {
                    Id = 3,
                    Name = "Verslo klientas",
                    AnswerId = 8,
                    FormId = 1,
                    IsDeleted = false
                },
                new Question()
                {
                    Id = 4,
                    Name = "Skaičiavimo metodas",
                    AnswerId = 9,
                    FormId = 1,
                    IsDeleted = false
                },
                new Question()
                {
                    Id = 5,
                    Name = "Svarbus klientas",
                    AnswerId = 0,
                    FormId = 1,
                    IsDeleted = false
                }
            );

            modelBuilder.Entity<Answer>().HasData(
                new Answer()
                {
                    Id = 1,
                    Name = "Taip",
                    QuestionId = 1,
                    IsDeleted = false
                },
                new Answer()
                {
                    Id = 2,
                    Name = "Ne",
                    QuestionId = 1,
                    IsDeleted = false
                },
                new Answer()
                {
                    Id = 3,
                    Name = "Metinis rangovas",
                    QuestionId = 2,
                    IsDeleted = false
                },
                new Answer()
                {
                    Id = 4,
                    Name = "Metinis subrangovas",
                    QuestionId = 2,
                    IsDeleted = false
                },
                new Answer()
                {
                    Id = 5,
                    Name = "Senas rangovas",
                    QuestionId = 2,
                    IsDeleted = false
                },
                new Answer()
                {
                    Id = 6,
                    Name = "Naujas rangovas",
                    QuestionId = 2,
                    IsDeleted = false
                },
                new Answer()
                {
                    Id = 7,
                    Name = "Taip",
                    QuestionId = 3,
                    IsDeleted = false
                },
                new Answer()
                {
                    Id = 8,
                    Name = "Ne",
                    QuestionId = 3,
                    IsDeleted = false
                },
                new Answer()
                {
                    Id = 9,
                    Name = "Automatinis",
                    QuestionId = 4,
                    IsDeleted = false
                },
                new Answer()
                {
                    Id = 10,
                    Name = "Rankinis",
                    QuestionId = 4,
                    IsDeleted = false
                },
                new Answer()
                {
                    Id = 11,
                    Name = "Taip",
                    QuestionId = 5,
                    IsDeleted = false
                },
                new Answer()
                {
                    Id = 12,
                    Name = "Ne",
                    QuestionId = 5,
                    IsDeleted = false
                }
            );
        }
    }
}
