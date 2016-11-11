using Microsoft.EntityFrameworkCore;
namespace EFCorePGSQL.Models {
	public class InstituteContext : DbContext {
		public DbSet<Student> Students { get; set; }
		protected override void OnModelCreating(ModelBuilder builder) {
			builder.Entity<Student>().HasKey(m => m.Id);
			base.OnModelCreating(builder);
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)  {
			string constr = Utility.GetConnectionString("ConnectionStrings:DefaultConnection");
			optionsBuilder.UseNpgsql(constr);
		}
	}
}