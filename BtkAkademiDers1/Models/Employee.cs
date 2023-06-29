﻿namespace BtkAkademiDers1.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName.ToUpper()}";
        public int Age { get; set; }
    }
}
