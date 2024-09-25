using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserAuthenticate.models
{
    public class Driver
    {
        public int DriverId { get; set; }
        [Required]
        public string DriverName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string IdNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime DOB { get; set; }
        public string OTP { get; set; }
        public DateTime? OTPExpiryTime { get; set; }
        public string Car_Model { get; set; }
        public string LicenseNumber { get; set; }
        public string CarPlateNumber { get; set; }
        public string CarColour { get; set; }
        public int CarSeats { get; set; }
        [Column(TypeName = "decimal(10, 8)")]
        public decimal CurrentLongitude { get; set; }
        [Column(TypeName = "decimal(10, 8)")]
        public decimal CurrentLatitude { get; set; }
        public DateTime? LastUpdate { get; set; }
        [Column(TypeName = "decimal(3, 2)")]
        public decimal Rating { get; set; }
        public bool IsActive { get; set; }
        public bool Enabled { get; set; }
        [Required]
        public string UserPassword { get; set; }
        public DateTime? LastLogin { get; set; }
        public string SecurityQuestionOne { get; set; }
        public string AnswerOne { get; set; }
        public string SecurityQuestionTwo { get; set; }
        public string AnswerTwo { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public Guid GUID { get; set; }
    }
}
