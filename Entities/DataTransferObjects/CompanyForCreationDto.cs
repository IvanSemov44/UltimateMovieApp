﻿using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects
{
    public class CompanyForCreationDto
    {
        [Required(ErrorMessage = "Company name is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Name is 30 characters.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Address  is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Address is 30 characters.")]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = "Country  is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Country is 30 characters.")]
        public string Country { get; set; } = string.Empty;

        public IEnumerable<EmployeeForCreationDto>? Employees { get; set; }
    }
}
