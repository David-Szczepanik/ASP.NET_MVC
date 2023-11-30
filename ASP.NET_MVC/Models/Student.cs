namespace ASP.NET_MVC.Models {
    public class Student {
        public int Id { get; set; }
       // [DisplayName("FirstName")]

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
