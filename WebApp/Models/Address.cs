﻿using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Address
    {
        [Key]
        public string Id { get; set; }

        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [DataType(DataType.PhoneNumber)]
        public int PhoneNumber { get; set; }

        [DataType(DataType.Text)]
        public string Street { get; set; }

        [DataType(DataType.Text)]
        public string City { get; set; }

        [DataType(DataType.PostalCode)]
        public int PostalCode { get; set; }

        public virtual ICollection<Repair> Repairs { get; set; }
    }
}