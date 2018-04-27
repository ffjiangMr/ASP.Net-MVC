namespace WebApplication.DataAccessLayer
{
    #region using directive

    using System.Data.Entity;
    using WebApplication.Models;

    #endregion

    public class SalesERPDAL : DbContext
    {
        #region DbSet

        public DbSet<Employee> Employees { get; set; }

        #endregion 

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("TblEmployee");
            base.OnModelCreating(modelBuilder);
        }
    }
}