using Microsoft.EntityFrameworkCore;

namespace StudentBillingAPI.Models
{
    public class StudentBillingDbContext : DbContext
    {
        public StudentBillingDbContext(DbContextOptions<StudentBillingDbContext> options) : base(options)
        {
        }

        // Define DbSet properties to represent the database tables (e.g., Students, Bills, Payments).
        public DbSet<Student> Students { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Payment> Payments { get; set; }
    }

    // Define your data models (Student, Bill, Payment) here to be used in the DbContext.
    public class Student
    {
        // Define the properties of a Student here.
    }

    public class Bill
    {
        // Define the properties of a Bill here.
    }

    public class Payment
    {
        // Define the properties of a Payment here.
    }
}
