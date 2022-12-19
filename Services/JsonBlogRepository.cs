using ProjektBoat.Helpers;
using ProjektBoat.Interfaces;
using ProjektBoat.Models;

namespace ProjektBoat.Services
{
    public class JsonBlogRepository : IBlog
    {
        string jsonFileName = @"Data\JsonPosts.json";
        public void AddBlogPost(BlogPost post)
        {
            List<BlogPost> posts = GetAllBlogPosts();
            posts.Add(post);
            JsonFileWriter.WriteToBlogJson(posts, jsonFileName);
        }

        public void DeleteBlogPost(int id)
        {
            BlogPost postToDelete = GetBlogPost(id);
            List<BlogPost> blogPosts = GetAllBlogPosts();
            blogPosts.Remove(postToDelete);
            JsonFileWriter.WriteToBlogJson(blogPosts, jsonFileName);
        }

        public List<BlogPost> GetAllBlogPosts()
        {
            return JsonFileReader.ReadBlogJson(jsonFileName);
        }

        public BlogPost GetBlogPost(int id)
        {
            List<BlogPost> blogPosts = GetAllBlogPosts();
            foreach (BlogPost item in blogPosts)
            {
                if (item.PostId == id)
                    return item;

            }
            return new BlogPost();
        }

        public void UpdateBlogPost(BlogPost post)
        {
            if (post != null)
            {
                List<BlogPost> posts = GetAllBlogPosts();
                foreach (BlogPost p in posts)
                {
                    if (p.PostId == post.PostId)
                    {
                        p.PostId = post.PostId;
                        p.Title = post.Title;
                        p.ShortDescription = post.ShortDescription;
                        p.Description = post.Description;
                        p.DateTime = post.DateTime;

                    }
                }
                JsonFileWriter.WriteToBlogJson(posts, jsonFileName);
            }
        }
    }
}
