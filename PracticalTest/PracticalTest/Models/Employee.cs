using System.ComponentModel.DataAnnotations;

namespace PracticalTest.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeNo { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }
    }
}
