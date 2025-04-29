using SQLite; 
using System;

namespace EmployeeManagementSystem.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement] 
        public int Id { get; set; }

        [NotNull]
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        //public double Salary { get; set; }
        public string EmployeeName { get; set; }

        public static User CurrentUser { get; set; } 
    }
}
