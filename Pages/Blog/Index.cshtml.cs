using ProjektBoat.Interfaces;
using ProjektBoat.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProjektBoat.Pages.Blog
{
    
    public class IndexModel : PageModel
    {
        private IBlog _blog;
        public List<BlogPost> BlogPost { get; private set; }
        public IndexModel(IBlog blog)
        {
            _blog = blog;
        }
        public void OnGet()
        {
            BlogPost = _blog.GetAllBlogPosts();
        }
    }
}
