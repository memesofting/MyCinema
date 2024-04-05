using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace MyCinemaWeb.Models
{
	public class Movie
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string? Title { get; set; }
		public string? Genre { get; set; }
		public string? Duration { get; set; }
		public DateTime ShowDate { get; set; }
		public string? Location { get; set; }
	}
}