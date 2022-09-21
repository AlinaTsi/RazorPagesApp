using CrudRazorAppWeb.Model;
using Microsoft.EntityFrameworkCore;

namespace CrudRazorAppWeb.Data
{
	public class AppDbContext:DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
		{

		}

		public DbSet<Category> Categories { get; set; }
	}
}
