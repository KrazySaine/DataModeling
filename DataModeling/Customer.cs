namespace DataModeling
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public string EmailAddress { get; set; }
        public ICollection<PhoneNumbers> PhoneNumbers { get; set; }
        public ICollection<Addresses> Addresses { get; set; }
        public ICollection<Likes> Likes { get; set; }
    }
    public class PhoneNumbers //one to many
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public string PhoneNumber { get; set; }
    }
    public class Addresses //many to one
    {
        public int Id { get; set; }
        public Customer Customer { set; get; }
        public string Address { get; set; }
    }
    public class Likes //many to many
    {
        public int Id { get; set; }
        public Customer Customer{ get; set; }
        public string Like {  get; set; }
    }



}
