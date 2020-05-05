using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab2.Models
{
    public class Employee
    {
 
            [Required]
            public int Id { get; set; }
            [Required]
            public string Name { get; set; }
            [Required]
            public int Salary { get; set; }
            [Required]
            public string Address { get; set; }
        public object Employees { get; internal set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}