using CrudRazorAppWeb.Data;
using CrudRazorAppWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CrudRazorAppWeb.Pages.Categories
{
    public class DeleteModel : PageModel
    {
        private readonly AppDbContext _db;

        public DeleteModel(AppDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public Category Category { get; set; }
        public void OnGet(int id)
        {
            Category = _db.Categories.Find(id);
        }

        public async Task<IActionResult> OnPost()
        {
                var CategoryFromDb = _db.Categories.Find(Category.Id);
                if(CategoryFromDb != null)
                {
                    _db.Categories.Remove(CategoryFromDb);
                    await _db.SaveChangesAsync();
				return RedirectToPage("Index");
			}

            return Page();
        }
    }
}
