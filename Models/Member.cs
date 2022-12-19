using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ProjektBoat.Models
{
    public class Member
    {
        public Member(int id, string name, int age, string phoneNo, string mail, string certificate, bool admin, string password)
        {
                ID = id;
                Name = name;
                Age = age;
                PhoneNo = phoneNo;
                Mail = mail;
                Certificate = certificate;
                Admin = admin;
                Password = password;
        }

        public Member() //default constructor
        {

        }

        [Required] 
        [Range(typeof(int), "1", "1000", ErrorMessage = "ID er uden for intervallet")]  
        public int ID { get; set; }

        [Required(ErrorMessage = "Der mangler at udfyldes navn og efternavn")] 
        public string Name { get; set; }

        [Required]
        [Range (typeof(int), "0", "120", ErrorMessage = "Der mangler at udfyldes alder")]  
        public int Age { get; set; }
        
        [Required(ErrorMessage = "Telefonnummer mangler at blive udfyldt"), MaxLength(8)] 
        public string PhoneNo { get; set; }

        [Required(ErrorMessage = "Der mangler at udfyldes email")] 
        public string Mail { get; set; }

        [Required(ErrorMessage = "Der mangles at udfylde hvilket certifikat(er) du har")] 
        public string Certificate { get; set; }
        
        [Required(ErrorMessage = "Der mangler at angive om du har admin tilladelse")] 
        public bool Admin { get; set; }

        [Required(ErrorMessage = "Der mangler at angive et password")]
        public string Password { get; set; }
    }
}
