using System.ComponentModel.DataAnnotations;
using System;

namespace UserAuthenticate.models
{
public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        public string IdNo { get; set; }

        [Required]
        public string CustomerName { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Gender { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        public string OTP { get; set; }
        public DateTime? OTPExpiryTime { get; set; }

        [Required]
        public bool IsActive { get; set; }

        public bool Enabled { get; set; }

        [Required]
        public string UserPassword { get; set; }

        public DateTime LastLogin { get; set; }

        public string SecurityQuestionOne { get; set; }
        public string AnswerOne { get; set; }

        public string SecurityQuestionTwo { get; set; }
        public string AnswerTwo { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public string CreatedBy { get; set; }

        [Required]
        public DateTime ModifiedOn { get; set; }

        [Required]
        public string ModifiedBy { get; set; }

        [Required]
        public Guid GUID { get; set; }
    }

}

