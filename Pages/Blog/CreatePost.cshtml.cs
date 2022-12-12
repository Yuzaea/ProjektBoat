using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjektBoat.Interfaces;
using ProjektBoat.Models;
using Microsoft.Extensions.Logging;

namespace ProjektBoat.Pages.Blog
{
    public class CreatePostModel : PageModel
    {
        private IBlog blogRepo;

        [BindProperty]
        public BlogPost Blog { get; set; }

        public CreatePostModel(IBlog repo)
        {
            this.blogRepo = repo;
        }

        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            blogRepo.AddBlogPost(Blog);
            return RedirectToPage("Index");
        }
    }
}
