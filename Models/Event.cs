using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace ProjektBoat.Models
{
    public class Event
    {

        [Required]
        [Range(typeof(int), "1", "1000", ErrorMessage = "Id er uden for intervallet")]
        public int EventID { get; set; }


        [Required(ErrorMessage = "Name is required"), MaxLength(30)]
        public string Name { get; set; }

        public string? ImageURL { get; set; }


        public int? participent { get; set; }


        [Required]
        [Range(typeof(DateTime), "18/11/1990", "18/11/2300", ErrorMessage = "Datoen er uden for intervallet")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Desciption is required"), MinLength(1)]
        public string Description { get; set; }

        public int? MaxParticipents { get; set; }

        public Event(int eventID, string name, DateTime date, string imageURL, string description, int maxParticipents)
        {
            EventID = eventID;
            Name = name;
            ImageURL = imageURL;
            Date = date;
            Description = description;
            MaxParticipents = maxParticipents;
        }
        public Event() { }

        public Event(int eventID, string name, DateTime date, string description, int maxParticipents)
        {
            EventID = eventID;
            Name = name;
            Date = date;
            Description = description;
            MaxParticipents = maxParticipents;
        }
        
        
    }
}