using System;
using System.ComponentModel.DataAnnotations;

namespace DebtyFinal.Models
{
    public class Credential
    {
        [Key]
        public Guid CredentialID { get; set; }
        [Required]
        public string Password { get; set; }
    }
}