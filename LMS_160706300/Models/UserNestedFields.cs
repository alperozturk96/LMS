namespace LMS_160706300.Models
{
    public class UserNestedFields
    {
        public string LoanDate { get; set; }
        public string LoanExpireDate { get; set; }
        public string[] BorrowedBookName { get; set; } = new string[5];
    }
}
