using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(255)]
        [Display(Name = "姓名")]
        public string Name { get; set; }
        
        public bool IsSubscribedToNewsletter { get; set; }
        
        public MembershipType MembershipType { get; set; }

        [Display(Name = "類型")]
        public byte MembershipTypeId { get; set; }

        [Display(Name = "生日")]
        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}