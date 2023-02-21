using System.ComponentModel.DataAnnotations;

namespace method2Postgresql.Models.Domain
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? PhoneNo { get; set; }

        public string? EmailID { get; set; }
        public string? Password { get; set; }
    }
}
