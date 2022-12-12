using ProjektBoat.Interfaces;
using ProjektBoat.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProjektBoat.Pages.Blog
{
    public class BlogEventModel : PageModel
    {
        //public List<BlogPost> BlogPostList { get; private set; }
        private IBlog _blog;

        //[BindProperty]
        public BlogPost BlogPost { get; set; }
        public BlogEventModel(IBlog blog)
        {
            _blog = blog;
        }
        public void OnGet(int id)
        {
            BlogPost = _blog.GetBlogPost(id);
        }
    }
}
