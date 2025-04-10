using System.ComponentModel.DataAnnotations.Schema;

namespace Almajed_Services_Website.Models
{
    public class JobRequests
    {

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public int PhoneNumber { get; set; }

        [NotMapped]
        public IFormFile ResumeFile { get; set; }
    }
}
