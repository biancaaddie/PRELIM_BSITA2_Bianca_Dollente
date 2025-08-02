namespace Library_Management_System.Models
{
    public class User
    {
        public int Id { get; set; }

       
        public string FullName { get; set; }

    
        public string Email { get; set; }

        public string Password { get; set; }

   
        public string Role { get; set; }

   
        public DateTime Date_Registered { get; set; }

        public List<Book> BorrowedBooks { get; set; } = new List<Book>();
    }
}
