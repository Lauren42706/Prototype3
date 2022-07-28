using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prototype2WebApi.Models
{
    [Table("Authentication")]
    public class Authentication
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int AuthenticationId { get; set; }

        public string EmailAddress { get; set; }
        public string Pin { get; set; }
        public DateTime LastLoginTime { get; set; }
        public bool Enabled { get; set; }
    }
}
