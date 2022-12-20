using Microsoft.AspNetCore.Mvc.Rendering;

namespace DocumentManagementSystem.UI.Models
{
    public class UserCreateModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int DeparmentId { get; set; }
        public SelectList Departments { get; set; }
    }
}
