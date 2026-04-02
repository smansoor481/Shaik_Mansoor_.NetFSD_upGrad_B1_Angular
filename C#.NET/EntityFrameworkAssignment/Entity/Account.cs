namespace EntityFrameworkAssignment.Entity
{
    public class Account
    {
        public int AccountId { get; set; }
        public string? AccountType { get; set; }
        public string? Customer {  get; set; }
        public double Balance { get; set; }
        public string? Branch { get; set; }
        public DateTime? CreatedDate { get; set; } 

    }
}
