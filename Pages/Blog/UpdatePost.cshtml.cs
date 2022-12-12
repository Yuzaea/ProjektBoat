using ProjektBoat.Interfaces;
using ProjektBoat.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProjektBoat.Pages.Blog
{
    public class UpdatePostModel : PageModel
    {
        private IBlog _blog;
        [BindProperty]
        public BlogPost BlogPost { get; set; }
        public UpdatePostModel(IBlog blog)
        {
            _blog = blog;
        }

        public void OnGet(int id)
        {
            BlogPost = _blog.GetBlogPost(id);
        }

        public IActionResult OnPost()
        {
            _blog.UpdateBlogPost(BlogPost);
            return RedirectToPage("Index");
        }
    }
}
