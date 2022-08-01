using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prototype2WebApi.Models
{
    [Table("UserInfoData")]
    public class UserInfoData
    {
        /// <summary>
        /// Sample Data. This can still propbably be used for the final
        /// app.
        /// </summary>

        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string CellNumber { get; set; }
        public string Password { get; set; }
        public DateTime DateTime { get; set; }

        [ForeignKey("Authentication")]
        public int AuthenticationId { get; set; }
        public Authentication? Authentication { get; set; }
    }
}
