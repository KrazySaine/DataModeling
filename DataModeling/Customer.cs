using DataModeling;

namespace DataModeling
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public string EmailAddress { get; set; }
        public int PhoneID { get; set; }
        public string AddressID { get; set; }
        public string LikesID { get; set; }

        public Addresses Addresses { get; set; }
        public ICollection<Likes> Likes { get; set; }
    }
    public class PhoneNumbers //one to many
    {
        public int PhoneId { get; set; }
        
        public string PhoneNumber { get; set; }

        public ICollection<Customer> { get; set; }

}
    public class Addresses //many to one
    {
        public int AddressId { get; set; }
        public Customer Customer { set; get; }
        public string Address { get; set; }
    }
    public class Likes //many to many
    {
        public int LikesId { get; set; }
        public string Like {  get; set; }
        public ICollection <Customer> Customers { get; set; }
    }



}
