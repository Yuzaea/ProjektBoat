using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjektBoat.Interfaces;
using ProjektBoat.Models;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;

namespace ProjektBoat.Pages.Blog
{
    public class CreatePostModel : PageModel
    {
        private IBlog blogRepo;
       // private IWebHostEnvironment webHostEnvironment;


        [BindProperty]
        public IFormFile Photo { get; set; }

        [BindProperty]
        public BlogPost Blog { get; set; }

        public CreatePostModel(IBlog repo) //, IWebHostEnvironment webHost)
        {
           // webHostEnvironment = webHost;
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
            //if (Photo != null)        - Spørg poul
            //{
            //    if (BlogPost.BlogImage != null)
            //    {
            //        string filePath = Path.Combine(webHostEnvironment.WebRootPath, "/images/BlogImages", BlogPost.BlogImage);
            //        System.IO.File.Delete(filePath);
            //    }

            //    BlogPost.BlogImage = ProcessUploadedFile();
            //}
            blogRepo.AddBlogPost(Blog);
            return RedirectToPage("Index");
        }
        //private string ProcessUploadedFile()
        //{
        //    string uniqueFileName = null;
        //    if (Photo != null)
        //    {
        //        string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images/EventImages");
        //        uniqueFileName = Guid.NewGuid().ToString() + "_" + Photo.FileName;
        //        string filePath = Path.Combine(uploadsFolder, uniqueFileName);
        //        using (var fileStream = new FileStream(filePath, FileMode.Create))
        //        {
        //            Photo.CopyTo(fileStream);
        //        }
        //    }
        //    return uniqueFileName;
        //}
    }
}
