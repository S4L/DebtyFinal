using System;
using System.ComponentModel.DataAnnotations;

namespace DebtyFinal.Models
{
    public class Credential
    {
        [Required]
        public Guid CredentialID { get; set; }
        [Required]
        public string Password { get; set; }
    }
}