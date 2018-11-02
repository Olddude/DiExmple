using DiExmple.Domain;
using Microsoft.EntityFrameworkCore;

namespace DiExmple.Persistance
{
	public sealed class MsSqlTodoDataContext : DbContext
	{
		public MsSqlTodoDataContext(DbContextOptions<MsSqlTodoDataContext> optionsBuilder)
			: base(optionsBuilder)
		{
			this.ChangeTracker.AutoDetectChangesEnabled = false;
			this.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.ApplyConfiguration(new MsSqlTodoConfiguration());
		}

		public DbSet<Todo> Todos { get; set; }
	}
}
