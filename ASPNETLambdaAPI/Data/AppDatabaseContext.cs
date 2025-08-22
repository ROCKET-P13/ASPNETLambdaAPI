using Microsoft.EntityFrameworkCore;
using ASPNETLambdaAPI.Entities;

namespace ASPNETLambdaAPI.Data;

public class AppDatabaseContext (DbContextOptions<AppDatabaseContext> options): DbContext(options)
{
	public DbSet<Book> Books { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Book>(entity =>
		{
			entity.ToTable("Book");
			entity.Property(e => e.Id).HasColumnName("id");
			entity.Property(e => e.Title).HasColumnName("title");
			entity.Property(e => e.ISBN).HasColumnName("isbn");
			entity.Property(e => e.Authors).HasColumnName("authors");
			entity.Property(e => e.CoverPage).HasColumnName("cover_page");
		});
	}
};