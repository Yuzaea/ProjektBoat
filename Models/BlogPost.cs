using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;

namespace ProjektBoat.Models
{
    public class BlogPost
    {
        [Required(ErrorMessage = "Title of the post is required"), MaxLength(30)]
        public string Title { get; set; }
        public int PostId { get; set; }
        public string Description { get; set; }
        [Required]
        [Range(typeof(DateTime), "18/11/2022", "18/11/2023", ErrorMessage = "Datoen er uden for intervallet")]
        public DateTime DateTime { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            else
            {
                BlogPost other = (BlogPost)obj;
                if (other.PostId == PostId)
                    return true;
                else
                    return false;
            }
        }
    }
}
