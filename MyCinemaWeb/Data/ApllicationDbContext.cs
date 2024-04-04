using Microsoft.EntityFrameworkCore;
using MyCinemaWeb.Models;

namespace MyCinemaWeb.Data
{
	public class ApllicationDbContext :DbContext
	{
		public ApllicationDbContext(DbContextOptions<ApllicationDbContext> options) :base(options)
		{
			
		}

		public DbSet<Movie> Movies { get; set; }
	}
}
