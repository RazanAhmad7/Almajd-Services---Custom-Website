namespace Almajed_Services_Website.Models
{
    public class RequestForQuotation
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string ContactPerson {  get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string ServiceName { get; set; }
        public int NumberOfPeople { get; set; }
        public string StaffCategory { get; set; }
        public string AdditionalNotes { get; set; }

    }
}
