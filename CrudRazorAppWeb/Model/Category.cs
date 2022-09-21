using System.ComponentModel.DataAnnotations;

namespace CrudRazorAppWeb.Model
{
	public class Category
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		[Range(1,100,ErrorMessage ="Age should be in range from 1 to 100.")]
		public int Age { get; set; }

	}
}
