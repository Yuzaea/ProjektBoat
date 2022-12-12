using ProjektBoat.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjektBoat.Models;

namespace ProjektBoat.Pages.Blog
{
    public class DeletePostModel : PageModel
    {
        private IBlog _blog;

        [BindProperty]
        public BlogPost BlogPost { get; set; }
        public DeletePostModel(IBlog blog)
        {
            _blog = blog;
        }
        public void OnGet(int id)
        {
            BlogPost = _blog.GetBlogPost(id);
        }
        public IActionResult OnPost()
        {
            _blog.DeleteBlogPost(BlogPost.PostId);
            return RedirectToPage("Index");
        }
    }
}
