﻿using Microsoft.EntityFrameworkCore;
using MyCinemaWeb.Models;

namespace MyCinemaWeb.Data
{
	public class ApplicationDbContext :DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
		{
			
		}

		public DbSet<Movie> Movies { get; set; }
	}
}
