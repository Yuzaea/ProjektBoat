using ProjektBoat.Models;

namespace ProjektBoat.Interfaces
{
    public interface IBlog
    {
        List<BlogPost> GetAllBlogPosts();
        BlogPost GetBlogPost(int id);
        void AddBlogPost(BlogPost post);
        void DeleteBlogPost(int id);
        void UpdateBlogPost(BlogPost post);
    }
}
