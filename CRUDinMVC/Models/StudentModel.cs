﻿using System.ComponentModel.DataAnnotations;

namespace CRUDinMVC.Models
{
    public class StudentModel
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "City Name is required.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Address is as  required.")]
        public string Address { get; set; }
    }
}