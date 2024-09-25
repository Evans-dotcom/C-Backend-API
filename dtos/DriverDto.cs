using System.ComponentModel.DataAnnotations;
using System;

namespace UserAuthenticate.dtos
{
    public class DriverDto
    {
        [Required(ErrorMessage = "Driver name is required.")]
        public string DriverName { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [RegularExpression(@"^(07|01)\d{8}$", ErrorMessage = "Phone number must start with '07' or '01' and be exactly 10 digits.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "ID Number is required.")]
        public string IdNo { get; set; }

        [Required(ErrorMessage = "Date of Birth is required.")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Car model is required.")]
        public string Car_Model { get; set; }

        [Required(ErrorMessage = "License number is required.")]
        public string LicenseNumber { get; set; }

        [Required(ErrorMessage = "Car plate number is required.")]
        public string CarPlateNumber { get; set; }

        [Required(ErrorMessage = "Car color is required.")]
        public string CarColour { get; set; }

        [Required(ErrorMessage = "Car seats are required.")]
        public int CarSeats { get; set; }

        public double CurrentLongitude { get; set; }
        public double CurrentLatitude { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        public string UserPassword { get; set; }

        public string SecurityQuestionOne { get; set; }

        public string AnswerOne { get; set; }

        public string SecurityQuestionTwo { get; set; }

        public string AnswerTwo { get; set; }

        public string CreatedBy { get; set; }
    }
}
