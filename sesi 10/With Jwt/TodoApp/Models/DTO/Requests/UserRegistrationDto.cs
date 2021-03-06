using System.ComponentModel.DataAnnotations;

namespace TodoApp.Models.DTO.Requests
{
    public class UserRegistrationDto
    {
        [Required]
        public string Username {get; set;}
        [Required]
        public string Email {get; set;}
        [Required]
        public string Password {get; set;}
    }
}